using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
namespace PavementCnC.Functions;
    public static class ExportResultsToAutocad
    {
        static Document doc = Application.DocumentManager.MdiActiveDocument;
        static Database db = Application.DocumentManager.MdiActiveDocument.Database;
        public static void CreateLayerIfDontExist(string layerName, short colorIndex, double lw)
        {
            using (DocumentLock lk = doc.LockDocument())
            {
                using (Transaction tr = db.TransactionManager.StartTransaction())
                {
                    LayerTable lt = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForWrite);
                    if (!lt.Has(layerName)) //Checking if layer already exist
                    {
                        LayerTableRecord newLayer = new LayerTableRecord()
                        {
                            Name = layerName,
                            Color = Color.FromColorIndex(ColorMethod.ByAci, colorIndex),
                            LineWeight = (LineWeight)(lw * 100),
                            IsPlottable = true
                        };
                        lt.UpgradeOpen();
                        lt.Add(newLayer);
                        tr.AddNewlyCreatedDBObject(newLayer, true);
                    }
                tr.Commit();
                }
            }
        }
        //Create Mleaders for everything
        //Create hatch  based on layer? pattern/size/color?
    }
