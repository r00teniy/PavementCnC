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
    public class DataImportFromAutocad
    {
        Document doc = Application.DocumentManager.MdiActiveDocument;
        Database db = Application.DocumentManager.MdiActiveDocument.Database;
        public List<T> GetAllElementsOfTypeOnLayer<T>(string layer) where T : Entity
        {
            List<T> output = new List<T>();
            using (DocumentLock lk = doc.LockDocument())
            {
                using (Transaction tr = db.TransactionManager.StartTransaction())
                {
                    var bT = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                    var bTr = (BlockTableRecord)tr.GetObject(bT[BlockTableRecord.ModelSpace], OpenMode.ForWrite);
                    foreach (var item in bTr)
                    {
                        if (item.ObjectClass.IsDerivedFrom(RXObject.GetClass(typeof(T))))
                        {
                            var entity = (T)tr.GetObject(item, OpenMode.ForRead);
                            if (entity.Layer == layer)
                            {
                                output.Add(entity);
                            }
                        }
                    }
                }
            }
            return output;
        }
    }
}
