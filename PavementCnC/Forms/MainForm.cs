using Autodesk.AutoCAD.Windows.Data;
using PavementCnC.Functions;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PavementCnC.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var pavementLayers = ImportFromAutocad.GetAllLayersContainingString(Variables.pavementLayerStart);
            Variables.currentPavements = pavementLayers.Select(x => x.Split('+').Skip(1).ToArray()).ToList();
            if (Variables.currentPavements.Count != 0)
            {
                pavementTypeBox.DataSource = Variables.currentPavements.Select(x => x[0]).ToList();
                pavementTypeBox.SelectedIndex = 0;
                pavementListBox.DataSource = Variables.currentPavements[0];
            }
            if (Variables.hatchStyles.Count != 0 && Variables.hatchStyles != null)
            {
                hatchStyleBox.DataSource = Variables.hatchStyles.Select(x => x["styleName"]).ToList();
                hatchStyleBox.SelectedIndex = 0;
            }
        }

        private void bCreatePaveType_Click(object sender, EventArgs e)
        {
            var paveTypeCreata = new CreatePavementLayersForm(this);
            paveTypeCreata.Show();
        }

        private void pavementTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pavementListBox.DataSource = Variables.currentPavements[pavementTypeBox.SelectedIndex];
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            MainForm obj = (MainForm)Application.OpenForms["MainForm"];
            obj.Close();
        }

        private void cPaveHatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExportResultsToAutocad.CreateNewHatch(Variables.pavementLayerStart, Variables.currentPavements[pavementTypeBox.SelectedIndex], Variables.hatchStyles[hatchStyleBox.SelectedIndex]);
            this.Show();
        }
    }
}
