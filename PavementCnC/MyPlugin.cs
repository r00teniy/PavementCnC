using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;

[assembly: ExtensionApplication(typeof(PavementCnC.MyPlugin))]

namespace PavementCnC
{
    internal class MyPlugin : IExtensionApplication

    {
        void IExtensionApplication.Initialize()
        {
            Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
            ed.WriteMessage("Program PavementCnC loaded \n");
        }
        void IExtensionApplication.Terminate()
        {

        }
    }
}