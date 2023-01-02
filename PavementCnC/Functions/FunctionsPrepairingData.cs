using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.BoundaryRepresentation;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using AcBr = Autodesk.AutoCAD.BoundaryRepresentation;

namespace PavementCnC.Functions;

public static class FunctionsPrepairingData
{
    //General stuff
    static Document doc = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument;
    static Editor ed = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument.Editor;
    static Database db = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument.Database;
    static RXClass rxClassBlockReference = RXObject.GetClass(typeof(BlockReference));
    static RXClass rxClassPolyline = RXObject.GetClass(typeof(Polyline));
    static RXClass rxClassText = RXObject.GetClass(typeof(DBText));
    //Point Containment for checking out if point is inside plot or outside it
    public static Region RegionFromClosedCurve(Curve curve)
    {
        if (!curve.Closed)
            throw new ArgumentException("Curve must be closed.");
        DBObjectCollection curves = new DBObjectCollection();
        curves.Add(curve);
        using (DBObjectCollection regions = Region.CreateFromCurves(curves))
        {
            if (regions == null || regions.Count == 0)
                throw new InvalidOperationException("Failed to create regions");
            if (regions.Count > 1)
                throw new InvalidOperationException("Multiple regions created");
            return regions.Cast<Region>().First();
        }
    }
    public static PointContainment GetPointContainment(Curve curve, Point3d point)
    {
        if (!curve.Closed)
            throw new ArgumentException("Полилиния границы должна быть замкнута");
        Region region = RegionFromClosedCurve(curve);
        if (region == null)
            throw new InvalidOperationException("Ошибка, проверьте полилинию границы");
        using (region)
        { return GetPointContainment(region, point); }
    }
    public static PointContainment GetPointContainment(Region region, Point3d point)
    {
        PointContainment result = PointContainment.Outside;
        using (Brep brep = new Brep(region))
        {
            if (brep != null)
            {
                using (BrepEntity ent = brep.GetPointContainment(point, out result))
                {
                    if (ent is AcBr.Face)
                        result = PointContainment.Inside;
                    else
                        result = PointContainment.OnBoundary;
                }
            }
        }
        return result;
    }
    //Getting hatch border points to check if it is inside plot or not
    public static List<Point3d> GetHatchBorderPoints(Hatch hat)
    {
        List<Point3d> output = new ();

        return output;
    }
    //Function that returns Polyline from HatchLoop
    public static Polyline GetBorderFromHatchLoop(HatchLoop loop, Plane plane)
    {
        //Modified code from Rivilis Restore Hatch Boundary program
        Polyline looparea = new Polyline();
        if (loop.IsPolyline)
        {
            using (Polyline poly = new Polyline())
            {
                int iVertex = 0;
                foreach (BulgeVertex bv in loop.Polyline)
                {
                    poly.AddVertexAt(iVertex++, bv.Vertex, bv.Bulge, 0.0, 0.0);
                }
                if (looparea != null)
                {
                    try
                    {
                        looparea.JoinEntity(poly);
                    }
                    catch
                    {
                        throw new System.Exception("Граница штриховки не может быть воссоздана");
                    }
                }
                else
                {
                    looparea = poly;
                }
            }
        }
        else
        {
            foreach (Curve2d cv in loop.Curves)
            {
                LineSegment2d line2d = cv as LineSegment2d;
                CircularArc2d arc2d = cv as CircularArc2d;
                EllipticalArc2d ellipse2d = cv as EllipticalArc2d;
                NurbCurve2d spline2d = cv as NurbCurve2d;
                if (line2d != null)
                {
                    using (Line ent = new Line())
                    {
                        try
                        {
                            ent.StartPoint = new Point3d(plane, line2d.StartPoint);
                            ent.EndPoint = new Point3d(plane, line2d.EndPoint);
                            looparea.JoinEntity(ent);
                        }
                        catch
                        {
                            looparea.AddVertexAt(0, line2d.StartPoint, 0, 0, 0);
                            looparea.AddVertexAt(1, line2d.EndPoint, 0, 0, 0);
                        }

                    }
                }
                else if (arc2d != null)
                {
                    try
                    {
                        if (arc2d.IsClosed() || Math.Abs(arc2d.EndAngle - arc2d.StartAngle) < 1e-5)
                        {
                            using (Circle ent = new Circle(new Point3d(plane, arc2d.Center), plane.Normal, arc2d.Radius))
                            {
                                looparea.JoinEntity(ent);
                            }
                        }
                        else
                        {
                            if (arc2d.IsClockWise)
                            {
                                arc2d = arc2d.GetReverseParameterCurve() as CircularArc2d;
                            }
                            double angle = new Vector3d(plane, arc2d.ReferenceVector).AngleOnPlane(plane);
                            double startAngle = arc2d.StartAngle + angle;
                            double endAngle = arc2d.EndAngle + angle;
                            using (Arc ent = new Arc(new Point3d(plane, arc2d.Center), plane.Normal, arc2d.Radius, startAngle, endAngle))
                            {
                                looparea.JoinEntity(ent);
                            }
                        }
                    }
                    catch
                    {
                        // Calculating Bulge
                        double deltaAng = arc2d.EndAngle - arc2d.StartAngle;
                        if (deltaAng < 0)
                            deltaAng += 2 * Math.PI;
                        double GetArcBulge = Math.Tan(deltaAng * 0.25);
                        //Adding first arc to polyline
                        looparea.AddVertexAt(0, new Point2d(arc2d.StartPoint.X, arc2d.StartPoint.Y), GetArcBulge, 0, 0);
                        looparea.AddVertexAt(1, new Point2d(arc2d.EndPoint.X, arc2d.EndPoint.Y), 0, 0, 0);
                    }
                }
                else if (ellipse2d != null)
                {
                    using (Ellipse ent = new Ellipse(new Point3d(plane, ellipse2d.Center), plane.Normal, new Vector3d(plane, ellipse2d.MajorAxis) * ellipse2d.MajorRadius, ellipse2d.MinorRadius / ellipse2d.MajorRadius, ellipse2d.StartAngle, ellipse2d.EndAngle))
                    {
                        ent.GetType().InvokeMember("StartParam", BindingFlags.SetProperty, null, ent, new object[] { ellipse2d.StartAngle });
                        ent.GetType().InvokeMember("EndParam", BindingFlags.SetProperty, null, ent, new object[] { ellipse2d.EndAngle });

                        looparea.JoinEntity(ent);
                    }
                }
                else if (spline2d != null)
                {
                    if (spline2d.HasFitData)
                    {
                        NurbCurve2dFitData n2fd = spline2d.FitData;
                        using (Point3dCollection p3ds = new Point3dCollection())
                        {
                            foreach (Point2d p in n2fd.FitPoints) p3ds.Add(new Point3d(plane, p));
                            using (Spline ent = new Spline(p3ds, new Vector3d(plane, n2fd.StartTangent), new Vector3d(plane, n2fd.EndTangent), /* n2fd.KnotParam, */  n2fd.Degree, n2fd.FitTolerance.EqualPoint))
                            {
                                looparea.JoinEntity(ent);
                            }
                        }
                    }
                    else
                    {
                        NurbCurve2dData n2fd = spline2d.DefinitionData;
                        using (Point3dCollection p3ds = new Point3dCollection())
                        {
                            DoubleCollection knots = new DoubleCollection(n2fd.Knots.Count);
                            foreach (Point2d p in n2fd.ControlPoints) p3ds.Add(new Point3d(plane, p));
                            foreach (double k in n2fd.Knots) knots.Add(k);
                            double period = 0;
                            using (Spline ent = new Spline(n2fd.Degree, n2fd.Rational, spline2d.IsClosed(), spline2d.IsPeriodic(out period), p3ds, knots, n2fd.Weights, n2fd.Knots.Tolerance, n2fd.Knots.Tolerance))
                            {
                                looparea.JoinEntity(ent);
                            }
                        }
                    }
                }
            }
        }
        return looparea;
    }
    //Function to get areas for a list on hatches.
    public static List<double> GetHatchArea(List<Hatch> hatchList)
    {
        List<double> hatchAreaList = new ();
        using (DocumentLock lk = doc.LockDocument())
        {
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                var bT = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                var bTr = (BlockTableRecord)tr.GetObject(bT[BlockTableRecord.ModelSpace], OpenMode.ForRead);
                for (var i = 0; i < hatchList.Count; i++)
                {
                    try
                    {
                        hatchAreaList[i] += hatchList[i].Area;
                    }
                    catch
                    {
                        //changing to count self-intersecting hatches
                        Plane plane = hatchList[i].GetPlane();
                        double corArea = 0.0;
                        for (int k = 0; k < hatchList[i].NumberOfLoops; k++)
                        {
                            HatchLoop loop = hatchList[i].GetLoopAt(k);
                            HatchLoopTypes hlt = hatchList[i].LoopTypeAt(k);
                            Polyline looparea = GetBorderFromHatchLoop(loop, plane);
                            // Can get correct value from AcadObject, but need to add in first
                            bTr.AppendEntity(looparea);
                            tr.AddNewlyCreatedDBObject(looparea, true);
                            object pl = looparea.AcadObject;
                            var corrval = (double)pl.GetType().InvokeMember("Area", BindingFlags.GetProperty, null, pl, null);
                            looparea.Erase(); // Erasing polyline we just created
                            if (hlt == HatchLoopTypes.External) // External loops with +
                            {
                                corArea += corrval;
                            }
                            else // Internal with -
                            {
                                corArea -= corrval;
                            }
                        }
                        hatchAreaList[i] += corArea;
                    }
                }
            }
        }
        return hatchAreaList;
    }
}