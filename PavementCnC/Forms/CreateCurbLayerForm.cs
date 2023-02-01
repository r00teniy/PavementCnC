using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using PavementCnC.Functions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PavementCnC.Forms
{
    public partial class CreateCurbLayerForm : Form
    {
        internal string ErrorText = "";
        internal Color selectedColor;
        internal LineWeight selectedLineWeight = LineWeight.ByLayer;
        internal int selectedTransparency;
        internal MainForm mainForm;
        public CreateCurbLayerForm(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
            curbMaterialBox.DataSource = Variables.typeOfCurb;
            curbMaterialBox.SelectedIndex = 0;
        }

        private void colorSelect_Click(object sender, EventArgs e)
        {
            selectedColor = ImportFromAutocad.PromptForColor();
            colorLabel.Text = $"Выбран цвет: {selectedColor.ColorNameForDisplay}";
            colorLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void lineweightSelect_Click(object sender, EventArgs e)
        {
            selectedLineWeight = ImportFromAutocad.PromptForLineweight();
            lineweightLabel.Text = $"Выбрана толщина: {selectedLineWeight}";
            lineweightLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            CreateCurbLayerForm obj = (CreateCurbLayerForm)Application.OpenForms["CreateCurbLayerForm"];
            obj.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void createCurbLayerButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                Variables.currentCurbs.Add(new string[] { curbCodeBox.Text.Trim(), curbMaterialBox.Text.Trim(), curbSizeBox.Text.Trim(), curbNameBox.Text.Trim(), curbManufacturerBox.Text.Trim(), curbColorBox.Text.Trim(), curbColorBox.Text.Trim() });
                ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.curbLayerStart}+{curbCodeBox.Text.Trim()}+{curbMaterialBox.Text.Trim()}+{curbSizeBox.Text.Trim()}+{curbNameBox.Text.Trim()}+{curbManufacturerBox.Text.Trim()}+{curbColorBox.Text.Trim()}", selectedColor, selectedLineWeight, selectedTransparency);
                MessageBox.Show("Слой создан", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ErrorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateUserInput()
        {
            ErrorText = "";
            var output = true;
            if (!FormValidation.CheckTextField(curbCodeBox.Text.Trim()))
            {
                output = false;
                ErrorText += "Необходимо вписать код \n";
            }
            if (!FormValidation.CheckTextField(curbSizeBox.Text.Trim()))
            {
                output = false;
                ErrorText += "Необходимо вписать размер \n";
            }
            if (!FormValidation.CheckTextField(curbNameBox.Text.Trim()))
            {
                output = false;
                ErrorText += "Необходимо вписать наименование \n";
            }
            if (!FormValidation.CheckTextField(curbManufacturerBox.Text.Trim()))
            {
                output = false;
                ErrorText += "Необходимо вписать производителя \n";
            }
            if (!FormValidation.CheckTextField(curbColorBox.Text.Trim()))
            {
                output = false;
                ErrorText += "Необходимо вписать цвет борта \n";
            }
            var transp = FormValidation.CheckIntField(transparencyBox.Text);
            if (transp == null || transp < 0 || transp > 100)
            {
                output = false;
                ErrorText += "Необходимо ввести прозрачность от 0 до 100";
            }
            else
            {
                selectedTransparency = (int)transp;
            }
            if (selectedColor == null)
            {
                output = false;
                ErrorText += "Выберите цвет слоя";
            }
            return output;
        }
    }
}
