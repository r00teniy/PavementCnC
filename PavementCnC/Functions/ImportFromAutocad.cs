using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace PavementCnC.Functions;

public static class ImportFromAutocad
{
    static Document doc = Application.DocumentManager.MdiActiveDocument;
    static Database db = Application.DocumentManager.MdiActiveDocument.Database;
    static Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;

    public static List<T> GetAllElementsOfTypeOnLayer<T>(string layer, string xrefName = null) where T : Entity
    {
        List<T> output = new ();
        using (DocumentLock lk = doc.LockDocument())
        {
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                var bT = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                BlockTableRecord bTr;
                XrefGraphNode xref;
                if (xrefName == null)
                {
                    bTr = (BlockTableRecord)tr.GetObject(bT[BlockTableRecord.ModelSpace], OpenMode.ForRead);
                }
                else
                {
                    XrefGraph XrGraph = db.GetHostDwgXrefGraph(false);
                    xref = XrGraph.GetXrefNode(0);
                    for (int i = 1; i < XrGraph.NumNodes; i++)
                    {
                        XrefGraphNode XrNode = XrGraph.GetXrefNode(i);
                        if (XrNode.Name == xrefName)
                        {
                            xref = XrNode;
                            break;
                        }
                    }
                    bTr = (BlockTableRecord)tr.GetObject(xref.BlockTableRecordId, OpenMode.ForRead); 
                }
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
                tr.Commit();
            }
        }
        return output;
    }
    public static List<string> GetAllLayersContainingString(string str)
    {
        List<string> output = new ();
        using (Transaction tr = db.TransactionManager.StartTransaction())
        {
            using (DocumentLock acLckDoc = doc.LockDocument())
            {
                LayerTable lt = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForRead);
                foreach (ObjectId item in lt)
                {
                    LayerTableRecord layer = (LayerTableRecord)tr.GetObject(item, OpenMode.ForRead);
                    if (layer.Name.Contains(str))
                    {
                        output.Add(layer.Name);
                    }
                }
            }
            tr.Commit();
        }
        return output;
    }
    public static Point3d GetInsertionPoint()
    {
        PromptPointOptions pPtOpts = new ("\nВыберете точку положения таблицы: ");
        return ed.GetPoint(pPtOpts).Value;
    }
}
