using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;

[assembly: ExtensionApplication(typeof(PavementCnC.MyPlugin))]

namespace PavementCnC
{
    internal class MyPlugin : IExtensionApplication

    {
        void IExtensionApplication.Initialize()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            ed.WriteMessage("Program PavementCnC loaded \n");
        }
        void IExtensionApplication.Terminate()
        {

        }
    }
}