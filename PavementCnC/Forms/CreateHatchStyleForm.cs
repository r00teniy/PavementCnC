
using Autodesk.AutoCAD.Colors;
using PavementCnC.Functions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PavementCnC.Forms
{
    public partial class CreateHatchStyleForm : Form
    {
        private MainForm mainForm;
        private string selectedPattern;
        private string ErrorText = "";
        private List<Dictionary<string, string>> variableToSet;

        public CreateHatchStyleForm(Form callingForm, ref List<Dictionary<string, string>> targetVariable)
        {
            mainForm = callingForm as MainForm;
            variableToSet = targetVariable;
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void patternSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectedPattern = ImportFromAutocad.PromptForHatchPattern();
            this.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            CreateHatchStyleForm obj = (CreateHatchStyleForm)Application.OpenForms["CreateHatchStyleForm"];
            obj.Close();
        }

        private void createStyle_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                variableToSet.Add( new Dictionary<string, string> { { "styleName", styleNameBox.Text }, { "patName", selectedPattern }, { "scale", scaleBox.Text }, { "rotation", rotationBox.Text }, { "hasBackground", hasBackground.Checked ? "true" : "false" } });
                MessageBox.Show("Стиль добавилен", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.pavementHatchStyleBox.DataSource = Variables.pavementHatchStyles;
                mainForm.pavementHatchStyleBox.SelectedIndex = Variables.pavementHatchStyles.Count - 1;
                MessageBox.Show("Стиль создан", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ErrorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckInput()
        {
            var output = true;
            if (!FormValidation.CheckTextField(styleNameBox.Text))
            {
                output = false;
                ErrorText += "Необходимо указать имя \n";
            }
            if (FormValidation.CheckDoubleField(scaleBox.Text) == null)
            {
                output = false;
                ErrorText += "Ошибка в типе покрытия \n";
            }
            if (FormValidation.CheckDoubleField(rotationBox.Text) == null)
            {
                output = false;
                ErrorText += "Ошибка в типе покрытия \n";
            }
            return output;
        }
    }
}
