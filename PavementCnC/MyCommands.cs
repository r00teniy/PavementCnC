using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PavementCnC.Forms;
using PavementCnC.Functions;

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