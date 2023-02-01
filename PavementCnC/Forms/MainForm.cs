using Autodesk.AutoCAD.DatabaseServices;
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
            var greeneryLayers = ImportFromAutocad.GetAllLayersContainingString(Variables.greeneryLayerStart);
            Variables.currentGreenery = greeneryLayers.Select(x => x.Split('+').Skip(1).ToArray()).ToList();
            if (Variables.currentPavements.Count != 0 && pavementLayers.Count != 0)
            {
                pavementTypeBox.DataSource = Variables.currentPavements.Select(x => x[0]).ToList();
                pavementTypeBox.SelectedIndex = 0;
                pavementListBox.DataSource = Variables.currentPavements[0];
            }
            if (Variables.currentGreenery.Count != 0 && greeneryLayers.Count != 0)
            {
                greeneryTypeBox.DataSource = Variables.currentGreenery.Select(x => x[1]).ToList();
                greeneryTypeBox.SelectedIndex = 0;
                greeneryListBox.DataSource = Variables.currentGreenery[0];
            }
            if (Variables.pavementHatchStyles.Count != 0 && Variables.pavementHatchStyles != null)
            {
                pavementHatchStyleBox.DataSource = Variables.pavementHatchStyles.Select(x => x["styleName"]).ToList();
                pavementHatchStyleBox.SelectedIndex = 0;
            }
            if (Variables.greeneryHatchStyles != null && Variables.greeneryHatchStyles.Count != 0)
            {
                greeneryHatchStyleBox.DataSource = Variables.greeneryHatchStyles.Select(x => x["styleName"]).ToList();
                greeneryHatchStyleBox.SelectedIndex = 0;
            }
            tableTypeBox.SelectedIndex = 0;
        }

        private void bCreatePaveType_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            ExportResultsToAutocad.CreateNewHatch(Variables.pavementLayerStart, Variables.currentPavements[pavementTypeBox.SelectedIndex], Variables.pavementHatchStyles[pavementHatchStyleBox.SelectedIndex]);
            this.Show();
        }

        private void PavementHatchStyleCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateHatchStyleForm hatchStyleForm= new CreateHatchStyleForm(this, ref Variables.pavementHatchStyles);
            hatchStyleForm.Show();
        }

        private void pavementHatchStyleDelete_Click(object sender, EventArgs e)
        {
            Variables.pavementHatchStyles.Remove(Variables.pavementHatchStyles[pavementHatchStyleBox.SelectedIndex]);
        }

        private void greneryHatchStyleCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateHatchStyleForm hatchStyleForm = new CreateHatchStyleForm(this, ref Variables.pavementHatchStyles);
            hatchStyleForm.Show();
        }

        private void greeneryHatchStyleDelete_Click(object sender, EventArgs e)
        {
            Variables.greeneryHatchStyles.Remove(Variables.greeneryHatchStyles[greeneryHatchStyleBox.SelectedIndex]);
        }

        private void greeneryTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            greeneryListBox.DataSource = Variables.currentGreenery[greeneryTypeBox.SelectedIndex];
        }

        private void greeneryHatchCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExportResultsToAutocad.CreateNewHatch(Variables.greeneryLayerStart, Variables.currentGreenery[greeneryTypeBox.SelectedIndex], Variables.greeneryHatchStyles[greeneryHatchStyleBox.SelectedIndex]);
            this.Show();
        }

        private void greeneryLayerCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateGreeneryLayerForm greeneryLayerForm = new CreateGreeneryLayerForm(this);
            greeneryLayerForm.Show();
        }

        private void tableCreateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            switch (tableTypeBox.SelectedIndex)
            {
                case 0:
                    WorkWithTables.CreateAutocadTable("Ведомость бортового камня", WorkWithTables.CreateTableData(TableType.Curbs, ModelCreation.GetCurbs(ImportFromAutocad.GetAllElementsOfTypeOnLayer<Polyline>(Variables.plotBorderLayer))));
                    break;
                case 1:
                    WorkWithTables.CreateAutocadTable("Ведомость покрытий", WorkWithTables.CreateTableData(TableType.Pavements, ModelCreation.GetPavements(ImportFromAutocad.GetAllElementsOfTypeOnLayer<Polyline>(Variables.plotBorderLayer))));
                    break;
                case 2:
                    WorkWithTables.CreateAutocadTable("Ведомость штучного озеленения", WorkWithTables.CreateTableData(TableType.ItemGreenery, ModelCreation.GetGreeneryItems(ImportFromAutocad.GetAllElementsOfTypeOnLayer<Polyline>(Variables.plotBorderLayer))));
                    break;
                case 3:
                    WorkWithTables.CreateAutocadTable("Ведомость площадного озеленения", WorkWithTables.CreateTableData(TableType.AreaGreenery, ModelCreation.GetGreeneryAreas(ImportFromAutocad.GetAllElementsOfTypeOnLayer<Polyline>(Variables.plotBorderLayer))));
                    break;
                case 4:
                    WorkWithTables.CreateAutocadTable("Ведомость газонов", WorkWithTables.CreateTableData(TableType.GrassGreenery, ModelCreation.GetGreeneryAreas(ImportFromAutocad.GetAllElementsOfTypeOnLayer<Polyline>(Variables.plotBorderLayer))));
                    break;
                case 5:
                    WorkWithTables.CreateAutocadTable("Ведомость МАФ", WorkWithTables.CreateTableData(TableType.StreetFurniture, ModelCreation.GetStreetFurniture()));
                    break;
            }
            this.Show();
        }

        private void createCurbLayerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCurbLayerForm curbLayerForm = new CreateCurbLayerForm(this);
            curbLayerForm.Show();
        }
    }
}
