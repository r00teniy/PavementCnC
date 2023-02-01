using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using PavementCnC.Functions;
using PavementCnC.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PavementCnC.Forms
{
    public partial class CreatePavementLayersForm : Form
    {
        internal string ErrorText = "";
        internal Color selectedColor;
        internal LineWeight selectedLineWeight = LineWeight.ByLayer;
        internal int selectedTransparency;
        internal MainForm mainForm;
        public CreatePavementLayersForm(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
            typeOfРavementBox.SelectedIndex = 0;
            pointOfUseBox.SelectedIndex = 0;
        }

        private void typeOfРavement_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Array.IndexOf(Variables.typeOfPavement, typeOfРavementBox.SelectedItem.ToString()))
            {
                case 0://asphalt
                    acceptedLoadLabel.Visible = true;
                    acceptedLoadBox.Visible = true; // all but rubber
                    //concrete & asphalt
                    paramBox.Visible = true;
                    paramLabel.Visible = true;
                    //loose fill
                    isInGeogridBox.Visible = false;
                    fillMaterial.Visible = false;
                    fillMaterialBox.Visible = false;
                    grainSize.Visible = false;
                    grainSizeBox.Visible = false;
                    //rubber
                    safeDropHeight.Visible = false;
                    safeDropHeightBox.Visible = false;
                    rubberManufacturer.Visible = false;
                    rubberManufacturerBox.Visible = false;
                    rubberMaterialName.Visible = false;
                    rubberMaterialNameBox.Visible = false;
                    rubberThickness.Visible = false;
                    rubberThicknessBox.Visible = false;
                    rubberModelLabel.Visible = false;
                    rubberModelBox.Visible = false;
                    //Tiles
                    tileCollection.Visible = false;
                    tileCollectionBox.Visible = false;
                    tileManufacturer.Visible = false;
                    tileManufacturerBox.Visible = false;
                    tileSize.Visible = false;
                    tileSizeBox.Visible = false;
                    break;
                case 1: //tiles
                    acceptedLoadLabel.Visible = true;
                    acceptedLoadBox.Visible = true;// all but rubber
                    //concrete & asphalt
                    paramBox.Visible = false;
                    paramLabel.Visible = false;
                    //loose fill
                    isInGeogridBox.Visible = false;
                    fillMaterial.Visible = false;
                    fillMaterialBox.Visible = false;
                    grainSize.Visible = false;
                    grainSizeBox.Visible = false;
                    //rubber
                    safeDropHeight.Visible = false;
                    safeDropHeightBox.Visible = false;
                    rubberManufacturer.Visible = false;
                    rubberManufacturerBox.Visible = false;
                    rubberMaterialName.Visible = false;
                    rubberMaterialNameBox.Visible = false;
                    rubberThickness.Visible = false;
                    rubberThicknessBox.Visible = false;
                    rubberModelLabel.Visible = false;
                    rubberModelBox.Visible = false;
                    //Tiles
                    tileCollection.Visible = true;
                    tileCollectionBox.Visible = true;
                    tileManufacturer.Visible = true;
                    tileManufacturerBox.Visible = true;
                    tileSize.Visible = true;
                    tileSizeBox.Visible = true;
                    break;
                case 2: //loose fill
                    acceptedLoadLabel.Visible = true;
                    acceptedLoadBox.Visible = true;// all but rubber
                    //concrete & asphalt
                    paramBox.Visible = false;
                    paramLabel.Visible = false;
                    //loose fill
                    isInGeogridBox.Visible = true;
                    fillMaterial.Visible = true;
                    fillMaterialBox.Visible = true;
                    grainSize.Visible = true;
                    grainSizeBox.Visible = true;
                    //rubber
                    safeDropHeight.Visible = false;
                    safeDropHeightBox.Visible = false;
                    rubberManufacturer.Visible = false;
                    rubberManufacturerBox.Visible = false;
                    rubberMaterialName.Visible = false;
                    rubberMaterialNameBox.Visible = false;
                    rubberThickness.Visible = false;
                    rubberThicknessBox.Visible = false;
                    rubberModelLabel.Visible = false;
                    rubberModelBox.Visible = false;
                    //Tiles
                    tileCollection.Visible = false;
                    tileCollectionBox.Visible = false;
                    tileManufacturer.Visible = false;
                    tileManufacturerBox.Visible = false;
                    tileSize.Visible = false;
                    tileSizeBox.Visible = false;
                    break;
                case 3: //concrete
                    acceptedLoadLabel.Visible = true;
                    acceptedLoadBox.Visible = true;// all but rubber
                    //concrete & asphalt
                    paramBox.Visible = true;
                    paramLabel.Visible = true;
                    //loose fill
                    isInGeogridBox.Visible = false;
                    fillMaterial.Visible = false;
                    fillMaterialBox.Visible = false;
                    grainSize.Visible = false;
                    grainSizeBox.Visible = false;
                    //rubber
                    safeDropHeight.Visible = false;
                    safeDropHeightBox.Visible = false;
                    rubberManufacturer.Visible = false;
                    rubberManufacturerBox.Visible = false;
                    rubberMaterialName.Visible = false;
                    rubberMaterialNameBox.Visible = false;
                    rubberThickness.Visible = false;
                    rubberThicknessBox.Visible = false;
                    rubberModelLabel.Visible = false;
                    rubberModelBox.Visible = false;
                    //Tiles
                    tileCollection.Visible = false;
                    tileCollectionBox.Visible = false;
                    tileManufacturer.Visible = false;
                    tileManufacturerBox.Visible = false;
                    tileSize.Visible = false;
                    tileSizeBox.Visible = false;
                    break;
                case 4: //rubber
                    acceptedLoadLabel.Visible = false;
                    acceptedLoadBox.Visible = false; // all but rubber
                    //concrete & asphalt
                    paramBox.Visible = false;
                    paramLabel.Visible = false;
                    //loose fill
                    isInGeogridBox.Visible = false;
                    fillMaterial.Visible = false;
                    fillMaterialBox.Visible = false;
                    grainSize.Visible = false;
                    grainSizeBox.Visible = false;
                    //rubber
                    safeDropHeight.Visible = true;
                    safeDropHeightBox.Visible = true;
                    rubberManufacturer.Visible = true;
                    rubberManufacturerBox.Visible = true;
                    rubberMaterialName.Visible = true;
                    rubberMaterialNameBox.Visible = true;
                    rubberThickness.Visible = true;
                    rubberThicknessBox.Visible = true;
                    rubberModelLabel.Visible = true;
                    rubberModelBox.Visible = true;
                    //Tiles
                    tileCollection.Visible = false;
                    tileCollectionBox.Visible = false;
                    tileManufacturer.Visible = false;
                    tileManufacturerBox.Visible = false;
                    tileSize.Visible = false;
                    tileSizeBox.Visible = false;
                    break;
                case 5: //grass in geogrid
                    acceptedLoadLabel.Visible = true;
                    acceptedLoadBox.Visible = true; // all but rubber
                    //concrete & asphalt
                    paramBox.Visible = true;
                    paramLabel.Visible = true;
                    //loose fill
                    isInGeogridBox.Visible = false;
                    fillMaterial.Visible = false;
                    fillMaterialBox.Visible = false;
                    grainSize.Visible = false;
                    grainSizeBox.Visible = false;
                    //rubber
                    safeDropHeight.Visible = false;
                    safeDropHeightBox.Visible = false;
                    rubberManufacturer.Visible = false;
                    rubberManufacturerBox.Visible = false;
                    rubberMaterialName.Visible = false;
                    rubberMaterialNameBox.Visible = false;
                    rubberThickness.Visible = false;
                    rubberThicknessBox.Visible = false;
                    rubberModelLabel.Visible = false;
                    rubberModelBox.Visible = false;
                    //Tiles
                    tileCollection.Visible = false;
                    tileCollectionBox.Visible = false;
                    tileManufacturer.Visible = false;
                    tileManufacturerBox.Visible = false;
                    tileSize.Visible = false;
                    tileSizeBox.Visible = false;
                    break;
                default:
                    throw new System.Exception("Неизвестный тип покрытия");
            }
        }

        private void createLayerButton_Click(object sender, EventArgs e)
        {
            var accLoad = acceptedLoadBox.Text.Replace(',','.');
            if (CheckInputData())
            {
                switch (Array.IndexOf(Variables.typeOfPavement, typeOfРavementBox.SelectedItem.ToString()))
                {
                    case 0: //apshalt
                        Variables.currentPavements.Add(new string[] { pavementTypeNameBox.Text, Variables.typeOfPavement[0], Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], colorBox.Text,accLoad });
                        ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+{pavementTypeNameBox.Text}+{Variables.typeOfPavement[0]}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{colorBox.Text}+{accLoad}", selectedColor, selectedLineWeight, selectedTransparency);
                        break;
                    case 1: //tiles
                        Variables.currentPavements.Add(new string[] { pavementTypeNameBox.Text, Variables.typeOfPavement[1], Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], tileSizeBox.Text, colorBox.Text, tileManufacturerBox.Text, tileCollectionBox.Text, accLoad });
                        ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+{pavementTypeNameBox.Text}+{Variables.typeOfPavement[1]}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{tileSizeBox.Text}+{colorBox.Text}+{tileManufacturerBox.Text}+{tileCollectionBox.Text}+{accLoad}", selectedColor, selectedLineWeight, selectedTransparency);
                        break;
                    case 2: //loose fill
                        var inGeogrid = isInGeogridBox.Checked ? "в георешетке" : " ";
                        Variables.currentPavements.Add(new string[] { pavementTypeNameBox.Text, Variables.typeOfPavement[2], Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], colorBox.Text, fillMaterialBox.Text, grainSizeBox.Text, inGeogrid, accLoad });
                        ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+{pavementTypeNameBox.Text}+{Variables.typeOfPavement[2]}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{fillMaterialBox.Text}+{grainSizeBox.Text}+{inGeogrid}+{colorBox.Text}+{accLoad}", selectedColor, selectedLineWeight, selectedTransparency);
                        break;
                    case 3: // concrete
                        Variables.currentPavements.Add(new string[] { pavementTypeNameBox.Text, Variables.typeOfPavement[3], Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], paramBox.Text, colorBox.Text, accLoad });
                        ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+{pavementTypeNameBox.Text}+{Variables.typeOfPavement[3]}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{paramBox.Text}+{colorBox.Text}+{accLoad}", selectedColor, selectedLineWeight, selectedTransparency);
                        break;
                    case 4: //rubber
                        Variables.currentPavements.Add(new string[] { pavementTypeNameBox.Text, Variables.typeOfPavement[4], Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], rubberMaterialNameBox.Text, rubberManufacturerBox.Text, colorBox.Text, rubberModelBox.Text, rubberThicknessBox.Text, safeDropHeightBox.Text.Replace(',', '.') });
                        ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+{pavementTypeNameBox.Text}+{Variables.typeOfPavement[4]}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{rubberMaterialNameBox.Text}+{rubberManufacturerBox.Text}+{colorBox.Text}+{rubberModelBox.Text}+{rubberThicknessBox.Text}+{safeDropHeightBox.Text.Replace(',','.')}", selectedColor, selectedLineWeight, selectedTransparency);
                        break;
                    case 5: //grass in geogrid
                        Variables.currentPavements.Add(new string[] { pavementTypeNameBox.Text, Variables.typeOfPavement[5], Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], paramBox.Text, colorBox.Text, accLoad });
                        ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+{pavementTypeNameBox.Text}+{Variables.typeOfPavement[5]}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{paramBox.Text}+{colorBox.Text}+{accLoad}", selectedColor, selectedLineWeight, selectedTransparency);
                        break;
                    default:
                        throw new System.Exception("Неизвестный тип покрытия");
                }
                mainForm.pavementTypeBox.DataSource = Variables.currentPavements.Select(x => x[0]).ToList();
                mainForm.pavementTypeBox.SelectedIndex = Variables.currentPavements.Count - 1;
                mainForm.pavementListBox.DataSource = Variables.currentPavements[Variables.currentPavements.Count - 1];
                MessageBox.Show("Слой создан", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ErrorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            CreatePavementLayersForm obj = (CreatePavementLayersForm)Application.OpenForms["CreatePavementLayersForm"];
            obj.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            mainForm.Show();
        }
        private bool CheckInputData()
        {
            ErrorText = "";
            var output = true;
            if (selectedColor == null)
            { output = false; }
            if (!FormValidation.CheckTextField(typeOfРavementBox.Text, Variables.typeOfPavement))
            {
                output = false;
                ErrorText += "Ошибка в типе покрытия \n";
            }
            if (!FormValidation.CheckTextField(pointOfUseBox.Text, Variables.pointOfUseText))
            {
                output = false;
                ErrorText += "Ошибка в места применения \n";
            }
            if (!FormValidation.CheckTextField(pavementTypeNameBox.Text))
            {
                output = false;
                ErrorText += "Необходимо ввести имя типа покрытия \n";
            }
            if (typeOfРavementBox.SelectedIndex != 4)
            {
                var acceptedLoad = FormValidation.CheckDoubleField(acceptedLoadBox.Text);
                if (acceptedLoad == null)
                {
                    output = false;
                    ErrorText += "Допустимая нагрузка должна быть числом \n";
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
            if (!FormValidation.CheckTextField(colorBox.Text))
            {
                output = false;
                ErrorText += "Необходимо ввести цвет покрытия \n";
            }
            switch (Array.IndexOf(Variables.typeOfPavement, typeOfРavementBox.SelectedItem.ToString()))
            {
                case 0: // asphalt
                    if (!FormValidation.CheckTextField(paramBox.Text))
                    {
                        output = false;
                        ErrorText += "Необходимо ввести параметры покрытия \n";
                    }
                    break;
                case 1: //tiles
                    if (!FormValidation.CheckTextField(tileCollectionBox.Text))
                    {
                        output = false;
                        ErrorText += "Необходимо ввести коллекцию \n";
                    }
                    if (!FormValidation.CheckTextField(tileManufacturerBox.Text))
                    {
                        output = false;
                        ErrorText += "Необходимо ввести производителя \n";
                    }
                    if (!FormValidation.CheckTextField(tileSizeBox.Text))
                    {
                        output = false;
                        ErrorText += "Необходимо ввести размер \n";
                    }
                    break;
                case 2: //lose fill
                    if (!FormValidation.CheckTextField(fillMaterialBox.Text))
                    {
                        output = false;
                        ErrorText += "Необходимо ввести материал \n";
                    }
                    if (!FormValidation.CheckTextField(grainSizeBox.Text))
                    {
                        output = false;
                        ErrorText += "Необходимо ввести фракцию \n";
                    }
                    break;
                case 3: //concrete
                    if (!FormValidation.CheckTextField(paramBox.Text))
                    {
                        output = false;
                        ErrorText += "Необходимо ввести параметры бетона \n";
                    }
                    break;
                case 4: //rubber
                    if (!FormValidation.CheckTextField(rubberManufacturerBox.Text))
                    {
                        output = false;
                        ErrorText += "Необходимо ввести производителя покрытия \n";
                    }
                    if (!FormValidation.CheckTextField(rubberMaterialNameBox.Text))
                    {
                        output = false;
                        ErrorText += "Необходимо ввести материал покрытия \n";
                    }
                    var thickness = FormValidation.CheckIntField(rubberThicknessBox.Text);
                    if (thickness == null)
                    {
                        output = false;
                        ErrorText += "Необходимо ввести толщину покрытия \n";
                    }
                    var safeDrop = FormValidation.CheckDoubleField(safeDropHeightBox.Text);
                    if (thickness == null)
                    {
                        output = false;
                        ErrorText += "Необходимо ввести безопасную высоту падения покрытия \n";
                    }
                    break;
                case 5:
                    if (!FormValidation.CheckTextField(paramBox.Text))
                    {
                        output = false;
                        ErrorText += "Необходимо ввести параметры решетки \n";
                    }
                    break;
                default:
                    throw new System.Exception("Неизвестный тип покрытия");
            }

            return output;
        }

        private void colorSelect_Click(object sender, EventArgs e)
        {
            selectedColor = ImportFromAutocad.PromptForColor();
            colorLabel.Text = "Ошибка, повторите выбор";
            colorLabel.ForeColor = System.Drawing.Color.Red;
            colorLabel.Text = $"Выбран цвет: {selectedColor.ColorNameForDisplay}";
            colorLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void lineweightSelect_Click(object sender, EventArgs e)
        {
            selectedLineWeight = ImportFromAutocad.PromptForLineweight();
            lineweightLabel.Text = $"Выбрана толщина: {selectedLineWeight.ToString()}";
            lineweightLabel.ForeColor = System.Drawing.Color.Green;
        }
    }
}
