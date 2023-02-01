using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using System;
using System.Windows.Forms;
using PavementCnC.Functions;
using System.Text.RegularExpressions;
using System.Linq;

namespace PavementCnC.Forms
{
    public partial class CreateGreeneryLayerForm : Form
    {
        internal string ErrorText = "";
        internal Color selectedColor;
        internal LineWeight selectedLineWeight = LineWeight.ByLayer;
        internal int selectedTransparency;
        internal MainForm mainForm;
        internal string stool;
        public CreateGreeneryLayerForm(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
            itemOrAreaBox.SelectedIndex = 0;
            typeOfGreeneryBox.DataSource = Variables.typeOfItemGreenery;
            typeOfGreeneryBox.SelectedIndex = 0;
            rolledBox.SelectedIndex = 0;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            mainForm.Show();
        }
        private void itemOrAreaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeOfGreeneryBox.DataSource = itemOrAreaBox.SelectedIndex == 0 ? Variables.typeOfItemGreenery : Variables.typeOfAreaGreenery;
            typeOfGreeneryBox.SelectedIndex = 0;
        }

        private void typeOfGreeneryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemOrAreaBox.SelectedIndex == 0)
            {
                numberOfPlantsPerSQMBox.Visible = false;
                plantsPerSQMLabel.Visible = false;
                seedsBox.Visible = false;
                seedsLabel.Visible = false;
                rolledBox.Visible = false;
                rolledLabel.Visible = false;
                specialMaterialAreaBox.Visible = true;
                specialMaterialAreaLabel.Visible = true;
                specialMaterialBox.Visible = true;
                specialMaterialLabel.Visible = true;
                withSpecialPavementBox.Visible = true;
                switch (typeOfGreeneryBox.SelectedIndex)
                {
                    case 0:
                    case 1:
                        plantHeightBox.Visible = true;
                        plantHeightLabel.Visible = true;
                        plantTrunkGirthBox.Visible = true;
                        trunkGirthLabel.Visible = true;
                        plantCrownSizeBox.Visible = true;
                        plantCrownSizeLabel.Visible = true;
                        break;
                    case 2:
                        plantHeightBox.Visible = true;
                        plantHeightLabel.Visible = true;
                        plantTrunkGirthBox.Visible = false;
                        trunkGirthLabel.Visible = false;
                        plantCrownSizeBox.Visible = false;
                        plantCrownSizeLabel.Visible = false;
                        break;
                    case 3:
                        plantHeightBox.Visible = false;
                        plantHeightLabel.Visible = false;
                        plantTrunkGirthBox.Visible = false;
                        trunkGirthLabel.Visible = false;
                        plantCrownSizeBox.Visible = false;
                        plantCrownSizeLabel.Visible = false;
                        break;
                    default:
                        MessageBox.Show($"Такой тип озеленения не поддерживается ({typeOfGreeneryBox.Text})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                numberOfPlantsPerSQMBox.Visible = true;
                plantsPerSQMLabel.Visible = true;
                plantTrunkGirthBox.Visible = false;
                trunkGirthLabel.Visible = false;
                switch (typeOfGreeneryBox.SelectedIndex)
                {
                    case 0:
                    case 1:
                        plantHeightBox.Visible = true;
                        plantHeightLabel.Visible = true;
                        plantCrownSizeBox.Visible = true;
                        plantCrownSizeLabel.Visible = true;
                        seedsBox.Visible = false;
                        seedsLabel.Visible = false;
                        rolledBox.Visible = false;
                        rolledLabel.Visible = false;
                        numberOfPlantsPerSQMBox.Visible = true;
                        plantsPerSQMLabel.Visible = true;
                        specialMaterialAreaBox.Visible = false;
                        specialMaterialAreaLabel.Visible = false;
                        specialMaterialBox.Visible = true;
                        specialMaterialLabel.Visible = true;
                        withSpecialPavementBox.Visible = true;
                        break;
                    case 2:
                    case 3:
                        plantHeightBox.Visible = false;
                        plantHeightLabel.Visible = false;
                        plantCrownSizeBox.Visible = false;
                        plantCrownSizeLabel.Visible = false;
                        seedsBox.Visible = false;
                        seedsLabel.Visible = false;
                        rolledBox.Visible = false;
                        rolledLabel.Visible = false;
                        numberOfPlantsPerSQMBox.Visible = true;
                        plantsPerSQMLabel.Visible = true;
                        specialMaterialAreaBox.Visible = false;
                        specialMaterialAreaLabel.Visible = false;
                        specialMaterialBox.Visible = true;
                        specialMaterialLabel.Visible = true;
                        withSpecialPavementBox.Visible = true;
                        break;
                    case 4:
                        plantHeightBox.Visible = false;
                        plantHeightLabel.Visible = false;
                        plantCrownSizeBox.Visible = false;
                        plantCrownSizeLabel.Visible = false;
                        numberOfPlantsPerSQMBox.Visible = false;
                        plantsPerSQMLabel.Visible = false;
                        specialMaterialAreaBox.Visible = false;
                        specialMaterialAreaLabel.Visible = false;
                        specialMaterialBox.Visible = false;
                        specialMaterialLabel.Visible = false;
                        seedsBox.Visible = true;
                        seedsLabel.Visible = true;
                        rolledBox.Visible = true;
                        rolledLabel.Visible = true;
                        withSpecialPavementBox.Visible = false;
                        break;
                    default:
                        MessageBox.Show($"Такой тип озеленения не поддерживается ({typeOfGreeneryBox.Text})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
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
            CreateGreeneryLayerForm obj = (CreateGreeneryLayerForm)Application.OpenForms["CreateGreeneryLayerForm"];
            obj.Close();
        }

        private void createLayerButton_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                var withSpecialMat = withSpecialPavementBox.Checked ? "1" : "0";
                var specialMaterial = specialMaterialBox.Text.Trim() == "" ? "-" : specialMaterialBox.Text.Trim();
                var specialMaterialArea = specialMaterialAreaBox.Text.Trim() == "" ? "-" : specialMaterialAreaBox.Text.Trim();
                if (itemOrAreaBox.SelectedIndex == 0)
                {
                    switch (typeOfGreeneryBox.SelectedIndex)
                    {
                        case 0:
                        case 1:
                            Variables.currentGreenery.Add(new string[] { Variables.ItemOrArea[0], codeBox.Text.Trim(), typeOfGreeneryBox.Text.Trim(), nameBox.Text.Trim(), plantHeightBox.Text.Trim(), plantTrunkGirthBox.Text.Trim(), plantCrownSizeBox.Text.Trim(), stoolbedSizeBox.Text.Trim(), withSpecialMat, specialMaterial, specialMaterialArea, "нет", "нет" });
                            ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.greeneryLayerStart}+{Variables.ItemOrArea[0]}+{codeBox.Text.Trim()}+{typeOfGreeneryBox.Text.Trim()}+{nameBox.Text.Trim()}+{plantHeightBox.Text.Trim()}+{plantTrunkGirthBox.Text.Trim()}+{plantCrownSizeBox.Text.Trim()}+{stoolbedSizeBox.Text.Trim()}+{withSpecialMat}+{specialMaterial}+{specialMaterialArea}+нет+нет", selectedColor, selectedLineWeight, selectedTransparency);
                            break;
                        case 2:
                            Variables.currentGreenery.Add(new string[] { Variables.ItemOrArea[0], codeBox.Text, typeOfGreeneryBox.Text.Trim(), nameBox.Text.Trim(), plantHeightBox.Text.Trim(), stoolbedSizeBox.Text.Trim(), withSpecialMat, specialMaterialAreaBox.Text.Trim() });
                            ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.greeneryLayerStart}+{Variables.ItemOrArea[0]}+{codeBox.Text.Trim()}+{typeOfGreeneryBox.Text.Trim()}+{nameBox.Text.Trim()}+{plantHeightBox.Text.Trim()}+{stoolbedSizeBox.Text.Trim()}+{withSpecialMat}+{specialMaterial}+{specialMaterialArea}", selectedColor, selectedLineWeight, selectedTransparency);
                            break;
                        case 3:
                            Variables.currentGreenery.Add(new string[] { Variables.ItemOrArea[0], codeBox.Text, typeOfGreeneryBox.Text, nameBox.Text, stoolbedSizeBox.Text, withSpecialMat, specialMaterial, specialMaterialArea });
                            ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.greeneryLayerStart}+{Variables.ItemOrArea[0]}+{codeBox.Text}+{typeOfGreeneryBox.Text}+{nameBox.Text}+{stoolbedSizeBox.Text}+{withSpecialMat}+{specialMaterial}+{specialMaterialArea}", selectedColor, selectedLineWeight, selectedTransparency);
                            break;
                        default:
                            MessageBox.Show($"Такой тип озеленения не поддерживается ({typeOfGreeneryBox.Text})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    MessageBox.Show("Слой создан", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    switch (typeOfGreeneryBox.SelectedIndex)
                    {
                        case 0:
                        case 1:
                            Variables.currentGreenery.Add(new string[] { Variables.ItemOrArea[1], codeBox.Text.Trim(), typeOfGreeneryBox.Text.Trim(), nameBox.Text.Trim(), plantHeightBox.Text.Trim(), plantCrownSizeBox.Text.Trim(), stoolbedSizeBox.Text.Trim(), withSpecialMat, specialMaterial });
                            ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.greeneryLayerStart}+{Variables.ItemOrArea[1]}+{codeBox.Text.Trim()}+{typeOfGreeneryBox.Text.Trim()}+{nameBox.Text.Trim()}+{plantHeightBox.Text.Trim()}+{plantCrownSizeBox.Text.Trim()}+{numberOfPlantsPerSQMBox.Text.Trim()}+{stoolbedSizeBox.Text.Trim()}+{withSpecialMat}+{specialMaterial}", selectedColor, selectedLineWeight, selectedTransparency);
                            break;
                        case 2:
                        case 3:
                            Variables.currentGreenery.Add(new string[] { Variables.ItemOrArea[1], codeBox.Text.Trim(), typeOfGreeneryBox.Text.Trim(), nameBox.Text.Trim(), stoolbedSizeBox.Text.Trim(),numberOfPlantsPerSQMBox.Text.Trim(), withSpecialMat, specialMaterialBox.Text.Trim() });
                            ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.greeneryLayerStart}+{Variables.ItemOrArea[1]}+{codeBox.Text.Trim()}+{typeOfGreeneryBox.Text.Trim()}+{nameBox.Text.Trim()}+{stoolbedSizeBox.Text.Trim()}+{numberOfPlantsPerSQMBox.Text.Trim()}+{withSpecialMat}+{specialMaterial}", selectedColor, selectedLineWeight, selectedTransparency);
                            break;
                        case 4:
                            Variables.currentGreenery.Add(new string[] { Variables.ItemOrArea[1], codeBox.Text.Trim(), typeOfGreeneryBox.Text.Trim(), nameBox.Text.Trim(), rolledBox.Text.Trim(), seedsBox.Text.Trim() });
                            ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.greeneryLayerStart}+{Variables.ItemOrArea[1]}+{codeBox.Text.Trim()}+{typeOfGreeneryBox.Text.Trim()}+{nameBox.Text.Trim()}+{rolledBox.Text.Trim()}+{seedsBox.Text.Trim()}", selectedColor, selectedLineWeight, selectedTransparency);
                            break;
                        default:
                            MessageBox.Show($"Такой тип озеленения не поддерживается ({typeOfGreeneryBox.Text})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                }
                mainForm.greeneryTypeBox.DataSource = Variables.currentGreenery.Select(x => x[0]).ToList();
                mainForm.greeneryTypeBox.SelectedIndex = Variables.currentGreenery.Count - 1;
                mainForm.greeneryListBox.DataSource = Variables.currentGreenery[Variables.currentGreenery.Count - 1];
            }
            else
            {
                MessageBox.Show(ErrorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckInput()
        {
            ErrorText = "";
            var output = true;
            if (!FormValidation.CheckTextField(codeBox.Text.Trim()))
            {
                output = false;
                ErrorText += "Необходимо вписать код \n";
            }
            if (!FormValidation.CheckTextField(nameBox.Text.Trim()))
            {
                output = false;
                ErrorText += "Необходимо вписать название элемента \n";
            }
            if ((typeOfGreeneryBox.SelectedIndex != 4 && itemOrAreaBox.SelectedIndex == 1) || itemOrAreaBox.SelectedIndex == 0)
            {
                stool = stoolbedSizeBox.Text.Trim().Replace(',', '.');
                if (!FormValidation.CheckTextField(stool) || !Regex.IsMatch(stool, @"^\d+\.?\d*[x,х]\d+\.?\d*$", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant))
                {
                    output = false;
                    ErrorText += "Ошибка в объёме кома, правильный формат ДиаметрХвысота\n";
                }
            }
            if (withSpecialPavementBox.Checked && ((typeOfGreeneryBox.SelectedIndex != 4 && itemOrAreaBox.SelectedIndex == 1) || itemOrAreaBox.SelectedIndex == 0))
            {
                if (!FormValidation.CheckTextField(specialMaterialBox.Text.Trim()))
                {
                    output = false;
                    ErrorText += "Необходимо указать мульчирующий материал \n";
                }
                var stoolM3 = FormValidation.CheckDoubleField(specialMaterialAreaBox.Text.Trim());
                if (stoolM3 == null)
                {
                    output = false;
                    ErrorText += "Необходимо указать площадь мульчирования, для штриховок укажите 0 \n";
                }
            }
            if (itemOrAreaBox.SelectedIndex == 0)
            {
                switch (typeOfGreeneryBox.SelectedIndex)
                {
                    case 0:
                    case 1:
                        var plantHeight = FormValidation.CheckDoubleField(plantHeightBox.Text.Trim());
                        if (plantHeight == null)
                        {
                            output = false;
                            ErrorText += "Необходимо указать высоту растения \n";
                        }
                        var crownSize = FormValidation.CheckDoubleField(plantCrownSizeBox.Text.Trim());
                        if (crownSize == null)
                        {
                            output = false;
                            ErrorText += "Необходимо указать диаметр кроны \n";
                        }
                        var trunkgirth = FormValidation.CheckDoubleField(plantTrunkGirthBox.Text.Trim());
                        if (trunkgirth == null)
                        {
                            output = false;
                            ErrorText += "Необходимо указать обхват ствола \n";
                        }
                        break;
                    case 2:
                        var plantHeight2 = FormValidation.CheckDoubleField(plantHeightBox.Text.Trim());
                        if (plantHeight2 == null)
                        {
                            output = false;
                            ErrorText += "Необходимо указать высоту растения \n";
                        }
                        break;
                    case 3:
                        break;
                    default:
                        MessageBox.Show($"Такой тип озеленения не поддерживается ({typeOfGreeneryBox.Text})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                var plPerSQM = FormValidation.CheckDoubleField(numberOfPlantsPerSQMBox.Text.Trim());
                if (plPerSQM == null && typeOfGreeneryBox.Text != "Газон")
                {
                    output = false;
                    ErrorText += "Необходимо указать кол-во растений на 1м2 \n";
                }
                switch (typeOfGreeneryBox.SelectedIndex)
                {
                    case 0:
                    case 1:
                        var plantHeight = FormValidation.CheckDoubleField(plantHeightBox.Text.Trim());
                        if (plantHeight == null)
                        {
                            output = false;
                            ErrorText += "Необходимо указать высоту растения \n";
                        }
                        var crownSize = FormValidation.CheckDoubleField(plantCrownSizeBox.Text.Trim());
                        if (crownSize == null)
                        {
                            output = false;
                            ErrorText += "Необходимо указать диаметр кроны \n";
                        }
                        break;
                    case 2:
                    case 3:
                        break;
                    case 4:
                        if (!FormValidation.CheckTextField(seedsBox.Text))
                        {
                            output = false;
                            ErrorText += "Необходимо указать состав семян \n";
                        }
                        break;
                    default:
                        MessageBox.Show($"Такой тип озеленения не поддерживается ({typeOfGreeneryBox.Text})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
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
                ErrorText += "Выберите цвет";
            }
            return output;
        }
    }
}
