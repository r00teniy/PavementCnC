using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PavementCnC.Functions;

namespace PavementCnC.Forms
{
    public partial class CreatePavementLayersForm : Form
    {
        public CreatePavementLayersForm()
        {
            InitializeComponent();
            typeOfРavementBox.SelectedIndex = 0;
            pointOfUseBox.SelectedIndex = 0;
        }

        private void typeOfРavement_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeOfРavementBox.SelectedItem.ToString())
            {
                case "Асфальтовое":
                    isInsideGeogrid.Visible = false;
                    isInGeogridBox.Visible = false;
                    fillMaterial.Visible = false;
                    fillMaterialBox.Visible = false;
                    grainSize.Visible = false;
                    grainSizeBox.Visible = false;
                    concreteClass.Visible = false;
                    concreteClassBox.Visible = false;
                    safeDropHeight.Visible = false;
                    safeDropHeightBox.Visible = false;
                    rubberColor.Visible = false;
                    rubberColorBox.Visible = false;
                    rubberManufacturer.Visible = false;
                    rubberManufacturerBox.Visible = false;
                    rubberMaterialName.Visible = false;
                    rubberMaterialNameBox.Visible = false;
                    rubberThickness.Visible = false;
                    rubberThicknessBox.Visible = false;
                    tileCollection.Visible = false;
                    tileCollectionBox.Visible = false;
                    tileColor.Visible = false;
                    tileColorBox.Visible = false;
                    tileManufacturer.Visible = false;
                    tileManufacturerBox.Visible = false;
                    tileSize.Visible = false;
                    tileSizeBox.Visible = false;
                    break;
                case "Плиточное":
                    isInsideGeogrid.Visible = false;
                    isInGeogridBox.Visible = false;
                    fillMaterial.Visible = false;
                    fillMaterialBox.Visible = false;
                    grainSize.Visible = false;
                    grainSizeBox.Visible = false;
                    concreteClass.Visible = false;
                    concreteClassBox.Visible = false;
                    safeDropHeight.Visible = false;
                    safeDropHeightBox.Visible = false;
                    rubberColor.Visible = false;
                    rubberColorBox.Visible = false;
                    rubberManufacturer.Visible = false;
                    rubberManufacturerBox.Visible = false;
                    rubberMaterialName.Visible = false;
                    rubberMaterialNameBox.Visible = false;
                    rubberThickness.Visible = false;
                    rubberThicknessBox.Visible = false;
                    tileCollection.Visible = true;
                    tileCollectionBox.Visible = true;
                    tileColor.Visible = true;
                    tileColorBox.Visible = true;
                    tileManufacturer.Visible = true;
                    tileManufacturerBox.Visible = true;
                    tileSize.Visible = true;
                    tileSizeBox.Visible = true;
                    break;
                case "Насыпное":
                    isInsideGeogrid.Visible = true;
                    isInGeogridBox.Visible = true;
                    fillMaterial.Visible = true;
                    fillMaterialBox.Visible = true;
                    grainSize.Visible = true;
                    grainSizeBox.Visible = true;
                    concreteClass.Visible = false;
                    concreteClassBox.Visible = false;
                    safeDropHeight.Visible = false;
                    safeDropHeightBox.Visible = false;
                    rubberColor.Visible = false;
                    rubberColorBox.Visible = false;
                    rubberManufacturer.Visible = false;
                    rubberManufacturerBox.Visible = false;
                    rubberMaterialName.Visible = false;
                    rubberMaterialNameBox.Visible = false;
                    rubberThickness.Visible = false;
                    rubberThicknessBox.Visible = false;
                    tileCollection.Visible = false;
                    tileCollectionBox.Visible = false;
                    tileColor.Visible = false;
                    tileColorBox.Visible = false;
                    tileManufacturer.Visible = false;
                    tileManufacturerBox.Visible = false;
                    tileSize.Visible = false;
                    tileSizeBox.Visible = false;
                    break;
                case "Бетонное":
                    isInsideGeogrid.Visible = false;
                    isInGeogridBox.Visible = false;
                    fillMaterial.Visible = false;
                    fillMaterialBox.Visible = false;
                    grainSize.Visible = false;
                    grainSizeBox.Visible = false;
                    concreteClass.Visible = true;
                    concreteClassBox.Visible = true;
                    safeDropHeight.Visible = false;
                    safeDropHeightBox.Visible = false;
                    rubberColor.Visible = false;
                    rubberColorBox.Visible = false;
                    rubberManufacturer.Visible = false;
                    rubberManufacturerBox.Visible = false;
                    rubberMaterialName.Visible = false;
                    rubberMaterialNameBox.Visible = false;
                    rubberThickness.Visible = false;
                    rubberThicknessBox.Visible = false;
                    tileCollection.Visible = false;
                    tileCollectionBox.Visible = false;
                    tileColor.Visible = false;
                    tileColorBox.Visible = false;
                    tileManufacturer.Visible = false;
                    tileManufacturerBox.Visible = false;
                    tileSize.Visible = false;
                    tileSizeBox.Visible = false;
                    break;
                case "Резиновое":
                    isInsideGeogrid.Visible = false;
                    isInGeogridBox.Visible = false;
                    fillMaterial.Visible = false;
                    fillMaterialBox.Visible = false;
                    grainSize.Visible = false;
                    grainSizeBox.Visible = false;
                    concreteClass.Visible = false;
                    concreteClassBox.Visible = false;
                    safeDropHeight.Visible = true;
                    safeDropHeightBox.Visible = true;
                    rubberColor.Visible = true;
                    rubberColorBox.Visible = true;
                    rubberManufacturer.Visible = true;
                    rubberManufacturerBox.Visible = true;
                    rubberMaterialName.Visible = true;
                    rubberMaterialNameBox.Visible = true;
                    rubberThickness.Visible = true;
                    rubberThicknessBox.Visible = true;
                    tileCollection.Visible = false;
                    tileCollectionBox.Visible = false;
                    tileColor.Visible = false;
                    tileColorBox.Visible = false;
                    tileManufacturer.Visible = false;
                    tileManufacturerBox.Visible = false;
                    tileSize.Visible = false;
                    tileSizeBox.Visible = false;
                    break;
                case "Газон в георешетке":
                    isInsideGeogrid.Visible = true;
                    isInGeogridBox.Visible = true;
                    fillMaterial.Visible = false;
                    fillMaterialBox.Visible = false;
                    grainSize.Visible = false;
                    grainSizeBox.Visible = false;
                    concreteClass.Visible = false;
                    concreteClassBox.Visible = false;
                    safeDropHeight.Visible = false;
                    safeDropHeightBox.Visible = false;
                    rubberColor.Visible = false;
                    rubberColorBox.Visible = false;
                    rubberManufacturer.Visible = false;
                    rubberManufacturerBox.Visible = false;
                    rubberMaterialName.Visible = false;
                    rubberMaterialNameBox.Visible = false;
                    rubberThickness.Visible = false;
                    rubberThicknessBox.Visible = false;
                    tileCollection.Visible = false;
                    tileCollectionBox.Visible = false;
                    tileColor.Visible = false;
                    tileColorBox.Visible = false;
                    tileManufacturer.Visible = false;
                    tileManufacturerBox.Visible = false;
                    tileSize.Visible = false;
                    tileSizeBox.Visible = false;
                    break;
                default:
                    throw new Exception("Неизвестный тип покрытия");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (typeOfРavementBox.SelectedItem.ToString())
            {
                case "Асфальтовое":
                    Variables.currentPavements.Add( new string[] { "Асфальтовое", pavementTypeNameBox.Text, Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], acceptedLoad.Text});
                    ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+Асфальтовое+{pavementTypeNameBox.Text}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{acceptedLoad.Text}", 1, 0.5);
                    break;
                case "Плиточное":
                    Variables.currentPavements.Add(new string[] { "Плиточное", tileSizeBox.Text, tileColorBox.Text, pavementTypeNameBox.Text, Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], acceptedLoad.Text, tileManufacturerBox.Text, tileCollectionBox.Text });
                    ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+Плиточное+{tileSizeBox.Text}+{tileColorBox.Text}+{pavementTypeNameBox.Text}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{acceptedLoad.Text}+{tileManufacturerBox.Text}+{tileCollectionBox.Text}", 1, 0.5);
                    break;
                case "Насыпное":
                    var inGeogrid = isInGeogridBox.Checked ? "в георешетке" : " ";
                    Variables.currentPavements.Add(new string[] { "Насыпное", fillMaterialBox.Text, inGeogrid, pavementTypeNameBox.Text, Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], acceptedLoad.Text, grainSizeBox.Text});
                    ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+Насыпное+{fillMaterialBox.Text}+{inGeogrid}+{pavementTypeNameBox.Text}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{acceptedLoad.Text}+{grainSizeBox.Text}", 1, 0.5);
                    break;
                case "Бетонное":
                    Variables.currentPavements.Add(new string[] { "Бетоное", pavementTypeNameBox.Text, Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], acceptedLoad.Text, concreteClassBox.Text});
                    ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+Бетоное+{pavementTypeNameBox.Text}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{acceptedLoad.Text}+{concreteClassBox.Text}",1,0.5);
                    break;
                case "Резиновое":
                    Variables.currentPavements.Add(new string[] { "Резиновое", pavementTypeNameBox.Text, rubberMaterialNameBox.Text, rubberManufacturerBox.Text, rubberColorBox.Text, Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], rubberThicknessBox.Text, safeDropHeightBox.Text});
                    ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+Резиновое+{pavementTypeNameBox.Text}+{rubberMaterialNameBox.Text}+{rubberManufacturerBox.Text}+{rubberColorBox.Text}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{rubberThicknessBox.Text}+{safeDropHeightBox.Text}",1,0.5);
                    break;
                case "Газон в георешетке":
                    var grassInGeogrid = isInGeogridBox.Checked ? "в георешетке" : "сеяный";
                    Variables.currentPavements.Add(new string[] { "Газонное",pavementTypeNameBox.Text, grassInGeogrid, Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())], acceptedLoad.Text});
                    ExportResultsToAutocad.CreateLayerIfDontExist($"{Variables.pavementLayerStart}+Газонное+{pavementTypeNameBox.Text}+{grassInGeogrid}+{Variables.pointOfUseLayer[Array.IndexOf(Variables.pointOfUseText, pointOfUseBox.SelectedItem.ToString())]}+{acceptedLoad.Text}",1,0.5);
                    break;
                default:
                    throw new Exception("Неизвестный тип покрытия");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreatePavementLayersForm obj = (CreatePavementLayersForm)Application.OpenForms["CreatePavementLayer"];
            obj.Close();
        }
        private bool CheckInputData()
        {
            var output = true;

            return output;
        }
    }
}
