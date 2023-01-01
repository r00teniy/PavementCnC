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

namespace PavementCnC.Functions
{
    internal class Functions
    {
        //General stuff
        Document doc = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument;
        Editor ed = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument.Editor;
        Database db = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument.Database;
        RXClass rxClassBlockReference = RXObject.GetClass(typeof(BlockReference));
        RXClass rxClassPolyline = RXObject.GetClass(typeof(Polyline));
        RXClass rxClassText = RXObject.GetClass(typeof(DBText));

    }
}