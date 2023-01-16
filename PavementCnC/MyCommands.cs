using Autodesk.AutoCAD.Runtime;
using PavementCnC.Forms;

[assembly: CommandClass(typeof(PavementCnC.MyCommands))]

namespace PavementCnC;

internal class MyCommands
{
    [CommandMethod("MyCom")]
    static public void MyCom()
    {
        var mainForm = new MainForm();
        mainForm.Show();
    }
}