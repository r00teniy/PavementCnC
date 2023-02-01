using System.Windows.Forms;
namespace PavementCnC.Forms
{
    partial class CreatePavementLayersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.typeOfРavementBox = new System.Windows.Forms.ComboBox();
            this.pointOfUseBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pavementTypeNameBox = new System.Windows.Forms.TextBox();
            this.acceptedLoadBox = new System.Windows.Forms.TextBox();
            this.fillMaterialBox = new System.Windows.Forms.TextBox();
            this.grainSizeBox = new System.Windows.Forms.TextBox();
            this.isInGeogridBox = new System.Windows.Forms.CheckBox();
            this.rubberMaterialNameBox = new System.Windows.Forms.TextBox();
            this.rubberManufacturerBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.rubberThicknessBox = new System.Windows.Forms.TextBox();
            this.safeDropHeightBox = new System.Windows.Forms.TextBox();
            this.grainSize = new System.Windows.Forms.Label();
            this.rubberMaterialName = new System.Windows.Forms.Label();
            this.rubberManufacturer = new System.Windows.Forms.Label();
            this.rubberThickness = new System.Windows.Forms.Label();
            this.safeDropHeight = new System.Windows.Forms.Label();
            this.tileSizeBox = new System.Windows.Forms.TextBox();
            this.tileSize = new System.Windows.Forms.Label();
            this.tileManufacturerBox = new System.Windows.Forms.TextBox();
            this.tileManufacturer = new System.Windows.Forms.Label();
            this.tileCollectionBox = new System.Windows.Forms.TextBox();
            this.tileCollection = new System.Windows.Forms.Label();
            this.createLayerButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.transparencyBox = new System.Windows.Forms.TextBox();
            this.colorSelect = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.lineweightLabel = new System.Windows.Forms.Label();
            this.lineweightSelect = new System.Windows.Forms.Button();
            this.acceptedLoadLabel = new System.Windows.Forms.Label();
            this.fillMaterial = new System.Windows.Forms.Label();
            this.paramBox = new System.Windows.Forms.TextBox();
            this.paramLabel = new System.Windows.Forms.Label();
            this.colorLab = new System.Windows.Forms.Label();
            this.rubberModelBox = new System.Windows.Forms.TextBox();
            this.rubberModelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид покрытия:";
            // 
            // typeOfРavementBox
            // 
            this.typeOfРavementBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfРavementBox.FormattingEnabled = true;
            this.typeOfРavementBox.Items.AddRange(new object[] {
            "Асфальтовое",
            "Плиточное",
            "Насыпное",
            "Резиновое",
            "Бетонное",
            "Газон в георешетке"});
            this.typeOfРavementBox.Location = new System.Drawing.Point(126, 10);
            this.typeOfРavementBox.Name = "typeOfРavementBox";
            this.typeOfРavementBox.Size = new System.Drawing.Size(130, 21);
            this.typeOfРavementBox.TabIndex = 1;
            this.typeOfРavementBox.SelectedIndexChanged += new System.EventHandler(this.typeOfРavement_SelectedIndexChanged);
            // 
            // pointOfUseBox
            // 
            this.pointOfUseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pointOfUseBox.FormattingEnabled = true;
            this.pointOfUseBox.Items.AddRange(new object[] {
            "проезды автотранспорта",
            "стоянки автотранспорта",
            "тротуары и дорожки",
            "пожарные проезды",
            "отмостка",
            "детские площадки",
            "спортивные площадки",
            "хозяйственные площадки",
            "площадки отдыха",
            "территория озеленения"});
            this.pointOfUseBox.Location = new System.Drawing.Point(126, 37);
            this.pointOfUseBox.Name = "pointOfUseBox";
            this.pointOfUseBox.Size = new System.Drawing.Size(130, 21);
            this.pointOfUseBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Место применения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип/Код покрытия:";
            // 
            // pavementTypeNameBox
            // 
            this.pavementTypeNameBox.Location = new System.Drawing.Point(126, 64);
            this.pavementTypeNameBox.Name = "pavementTypeNameBox";
            this.pavementTypeNameBox.Size = new System.Drawing.Size(130, 20);
            this.pavementTypeNameBox.TabIndex = 5;
            // 
            // acceptedLoadBox
            // 
            this.acceptedLoadBox.Location = new System.Drawing.Point(154, 115);
            this.acceptedLoadBox.Name = "acceptedLoadBox";
            this.acceptedLoadBox.Size = new System.Drawing.Size(102, 20);
            this.acceptedLoadBox.TabIndex = 7;
            this.acceptedLoadBox.Text = "0";
            // 
            // fillMaterialBox
            // 
            this.fillMaterialBox.Location = new System.Drawing.Point(154, 140);
            this.fillMaterialBox.Name = "fillMaterialBox";
            this.fillMaterialBox.Size = new System.Drawing.Size(102, 20);
            this.fillMaterialBox.TabIndex = 11;
            this.fillMaterialBox.Visible = false;
            // 
            // grainSizeBox
            // 
            this.grainSizeBox.Location = new System.Drawing.Point(154, 167);
            this.grainSizeBox.Name = "grainSizeBox";
            this.grainSizeBox.Size = new System.Drawing.Size(102, 20);
            this.grainSizeBox.TabIndex = 13;
            this.grainSizeBox.Visible = false;
            // 
            // isInGeogridBox
            // 
            this.isInGeogridBox.AutoSize = true;
            this.isInGeogridBox.Location = new System.Drawing.Point(154, 198);
            this.isInGeogridBox.Name = "isInGeogridBox";
            this.isInGeogridBox.Size = new System.Drawing.Size(101, 17);
            this.isInGeogridBox.TabIndex = 15;
            this.isInGeogridBox.Text = "в георешетке?";
            this.isInGeogridBox.UseVisualStyleBackColor = true;
            this.isInGeogridBox.Visible = false;
            // 
            // rubberMaterialNameBox
            // 
            this.rubberMaterialNameBox.Location = new System.Drawing.Point(154, 142);
            this.rubberMaterialNameBox.Name = "rubberMaterialNameBox";
            this.rubberMaterialNameBox.Size = new System.Drawing.Size(102, 20);
            this.rubberMaterialNameBox.TabIndex = 17;
            this.rubberMaterialNameBox.Visible = false;
            // 
            // rubberManufacturerBox
            // 
            this.rubberManufacturerBox.Location = new System.Drawing.Point(154, 169);
            this.rubberManufacturerBox.Name = "rubberManufacturerBox";
            this.rubberManufacturerBox.Size = new System.Drawing.Size(102, 20);
            this.rubberManufacturerBox.TabIndex = 19;
            this.rubberManufacturerBox.Visible = false;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(154, 89);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(102, 20);
            this.colorBox.TabIndex = 21;
            // 
            // rubberThicknessBox
            // 
            this.rubberThicknessBox.Location = new System.Drawing.Point(154, 195);
            this.rubberThicknessBox.Name = "rubberThicknessBox";
            this.rubberThicknessBox.Size = new System.Drawing.Size(102, 20);
            this.rubberThicknessBox.TabIndex = 23;
            this.rubberThicknessBox.Visible = false;
            // 
            // safeDropHeightBox
            // 
            this.safeDropHeightBox.Location = new System.Drawing.Point(154, 221);
            this.safeDropHeightBox.Name = "safeDropHeightBox";
            this.safeDropHeightBox.Size = new System.Drawing.Size(102, 20);
            this.safeDropHeightBox.TabIndex = 25;
            this.safeDropHeightBox.Visible = false;
            // 
            // grainSize
            // 
            this.grainSize.AutoSize = true;
            this.grainSize.Location = new System.Drawing.Point(13, 169);
            this.grainSize.Name = "grainSize";
            this.grainSize.Size = new System.Drawing.Size(115, 13);
            this.grainSize.TabIndex = 12;
            this.grainSize.Text = "Фракция материала:";
            this.grainSize.Visible = false;
            // 
            // rubberMaterialName
            // 
            this.rubberMaterialName.AutoSize = true;
            this.rubberMaterialName.Location = new System.Drawing.Point(13, 144);
            this.rubberMaterialName.Name = "rubberMaterialName";
            this.rubberMaterialName.Size = new System.Drawing.Size(112, 13);
            this.rubberMaterialName.TabIndex = 16;
            this.rubberMaterialName.Text = "Материал покрытия:";
            this.rubberMaterialName.Visible = false;
            // 
            // rubberManufacturer
            // 
            this.rubberManufacturer.AutoSize = true;
            this.rubberManufacturer.Location = new System.Drawing.Point(13, 169);
            this.rubberManufacturer.Name = "rubberManufacturer";
            this.rubberManufacturer.Size = new System.Drawing.Size(141, 13);
            this.rubberManufacturer.TabIndex = 18;
            this.rubberManufacturer.Text = "Производитель покрытия:";
            this.rubberManufacturer.Visible = false;
            // 
            // rubberThickness
            // 
            this.rubberThickness.AutoSize = true;
            this.rubberThickness.Location = new System.Drawing.Point(13, 197);
            this.rubberThickness.Name = "rubberThickness";
            this.rubberThickness.Size = new System.Drawing.Size(130, 13);
            this.rubberThickness.TabIndex = 22;
            this.rubberThickness.Text = "Толщина покрытия, мм:";
            this.rubberThickness.Visible = false;
            // 
            // safeDropHeight
            // 
            this.safeDropHeight.AutoSize = true;
            this.safeDropHeight.Location = new System.Drawing.Point(13, 223);
            this.safeDropHeight.Name = "safeDropHeight";
            this.safeDropHeight.Size = new System.Drawing.Size(129, 13);
            this.safeDropHeight.TabIndex = 24;
            this.safeDropHeight.Text = "Max высота падения, м:";
            this.safeDropHeight.Visible = false;
            // 
            // tileSizeBox
            // 
            this.tileSizeBox.Location = new System.Drawing.Point(154, 140);
            this.tileSizeBox.Name = "tileSizeBox";
            this.tileSizeBox.Size = new System.Drawing.Size(102, 20);
            this.tileSizeBox.TabIndex = 27;
            this.tileSizeBox.Visible = false;
            // 
            // tileSize
            // 
            this.tileSize.AutoSize = true;
            this.tileSize.Location = new System.Drawing.Point(13, 142);
            this.tileSize.Name = "tileSize";
            this.tileSize.Size = new System.Drawing.Size(87, 13);
            this.tileSize.TabIndex = 26;
            this.tileSize.Text = "Размер плитки:";
            this.tileSize.Visible = false;
            // 
            // tileManufacturerBox
            // 
            this.tileManufacturerBox.Location = new System.Drawing.Point(154, 168);
            this.tileManufacturerBox.Name = "tileManufacturerBox";
            this.tileManufacturerBox.Size = new System.Drawing.Size(102, 20);
            this.tileManufacturerBox.TabIndex = 29;
            this.tileManufacturerBox.Visible = false;
            // 
            // tileManufacturer
            // 
            this.tileManufacturer.AutoSize = true;
            this.tileManufacturer.Location = new System.Drawing.Point(13, 170);
            this.tileManufacturer.Name = "tileManufacturer";
            this.tileManufacturer.Size = new System.Drawing.Size(127, 13);
            this.tileManufacturer.TabIndex = 28;
            this.tileManufacturer.Text = "Производитель плитки:";
            this.tileManufacturer.Visible = false;
            // 
            // tileCollectionBox
            // 
            this.tileCollectionBox.Location = new System.Drawing.Point(154, 194);
            this.tileCollectionBox.Name = "tileCollectionBox";
            this.tileCollectionBox.Size = new System.Drawing.Size(102, 20);
            this.tileCollectionBox.TabIndex = 33;
            this.tileCollectionBox.Visible = false;
            // 
            // tileCollection
            // 
            this.tileCollection.AutoSize = true;
            this.tileCollection.Location = new System.Drawing.Point(13, 196);
            this.tileCollection.Name = "tileCollection";
            this.tileCollection.Size = new System.Drawing.Size(103, 13);
            this.tileCollection.TabIndex = 32;
            this.tileCollection.Text = "Коллекция плитки:";
            this.tileCollection.Visible = false;
            // 
            // createLayerButton
            // 
            this.createLayerButton.Location = new System.Drawing.Point(270, 149);
            this.createLayerButton.Name = "createLayerButton";
            this.createLayerButton.Size = new System.Drawing.Size(141, 41);
            this.createLayerButton.TabIndex = 34;
            this.createLayerButton.Text = "Создать слой для покрытия";
            this.createLayerButton.UseVisualStyleBackColor = true;
            this.createLayerButton.Click += new System.EventHandler(this.createLayerButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(295, 219);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 23);
            this.closeButton.TabIndex = 35;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Параметры нового слоя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Прозрачность:";
            // 
            // transparencyBox
            // 
            this.transparencyBox.Location = new System.Drawing.Point(355, 120);
            this.transparencyBox.Name = "transparencyBox";
            this.transparencyBox.Size = new System.Drawing.Size(56, 20);
            this.transparencyBox.TabIndex = 41;
            this.transparencyBox.Text = "0";
            // 
            // colorSelect
            // 
            this.colorSelect.Location = new System.Drawing.Point(269, 32);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(142, 23);
            this.colorSelect.TabIndex = 43;
            this.colorSelect.Text = "Выбрать цвет";
            this.colorSelect.UseVisualStyleBackColor = true;
            this.colorSelect.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorLabel.Location = new System.Drawing.Point(266, 58);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(83, 13);
            this.colorLabel.TabIndex = 44;
            this.colorLabel.Text = "Выберите цвет";
            // 
            // lineweightLabel
            // 
            this.lineweightLabel.AutoSize = true;
            this.lineweightLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineweightLabel.Location = new System.Drawing.Point(266, 100);
            this.lineweightLabel.Name = "lineweightLabel";
            this.lineweightLabel.Size = new System.Drawing.Size(83, 13);
            this.lineweightLabel.TabIndex = 46;
            this.lineweightLabel.Text = "Выберите цвет";
            // 
            // lineweightSelect
            // 
            this.lineweightSelect.Location = new System.Drawing.Point(269, 74);
            this.lineweightSelect.Name = "lineweightSelect";
            this.lineweightSelect.Size = new System.Drawing.Size(142, 23);
            this.lineweightSelect.TabIndex = 45;
            this.lineweightSelect.Text = "Выбрать толщину линий";
            this.lineweightSelect.UseVisualStyleBackColor = true;
            this.lineweightSelect.Click += new System.EventHandler(this.lineweightSelect_Click);
            // 
            // acceptedLoadLabel
            // 
            this.acceptedLoadLabel.AutoSize = true;
            this.acceptedLoadLabel.Location = new System.Drawing.Point(13, 117);
            this.acceptedLoadLabel.Name = "acceptedLoadLabel";
            this.acceptedLoadLabel.Size = new System.Drawing.Size(136, 13);
            this.acceptedLoadLabel.TabIndex = 6;
            this.acceptedLoadLabel.Text = "Допустимая нагрузка, т.:";
            // 
            // fillMaterial
            // 
            this.fillMaterial.AutoSize = true;
            this.fillMaterial.Location = new System.Drawing.Point(13, 142);
            this.fillMaterial.Name = "fillMaterial";
            this.fillMaterial.Size = new System.Drawing.Size(114, 13);
            this.fillMaterial.TabIndex = 10;
            this.fillMaterial.Text = "Насыпной материал:";
            this.fillMaterial.Visible = false;
            // 
            // paramBox
            // 
            this.paramBox.Location = new System.Drawing.Point(154, 141);
            this.paramBox.Name = "paramBox";
            this.paramBox.Size = new System.Drawing.Size(102, 20);
            this.paramBox.TabIndex = 49;
            // 
            // paramLabel
            // 
            this.paramLabel.AutoSize = true;
            this.paramLabel.Location = new System.Drawing.Point(13, 143);
            this.paramLabel.Name = "paramLabel";
            this.paramLabel.Size = new System.Drawing.Size(69, 13);
            this.paramLabel.TabIndex = 48;
            this.paramLabel.Text = "Параметры:";
            // 
            // colorLab
            // 
            this.colorLab.AutoSize = true;
            this.colorLab.Location = new System.Drawing.Point(13, 91);
            this.colorLab.Name = "colorLab";
            this.colorLab.Size = new System.Drawing.Size(87, 13);
            this.colorLab.TabIndex = 47;
            this.colorLab.Text = "Цвет покрытия:";
            // 
            // rubberModelBox
            // 
            this.rubberModelBox.Location = new System.Drawing.Point(155, 117);
            this.rubberModelBox.Name = "rubberModelBox";
            this.rubberModelBox.Size = new System.Drawing.Size(102, 20);
            this.rubberModelBox.TabIndex = 51;
            this.rubberModelBox.Visible = false;
            // 
            // rubberModelLabel
            // 
            this.rubberModelLabel.AutoSize = true;
            this.rubberModelLabel.Location = new System.Drawing.Point(14, 119);
            this.rubberModelLabel.Name = "rubberModelLabel";
            this.rubberModelLabel.Size = new System.Drawing.Size(112, 13);
            this.rubberModelLabel.TabIndex = 50;
            this.rubberModelLabel.Text = "Название покрытия:";
            this.rubberModelLabel.Visible = false;
            // 
            // CreatePavementLayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 250);
            this.Controls.Add(this.rubberModelBox);
            this.Controls.Add(this.rubberModelLabel);
            this.Controls.Add(this.paramBox);
            this.Controls.Add(this.paramLabel);
            this.Controls.Add(this.colorLab);
            this.Controls.Add(this.lineweightLabel);
            this.Controls.Add(this.lineweightSelect);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorSelect);
            this.Controls.Add(this.transparencyBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.createLayerButton);
            this.Controls.Add(this.tileCollectionBox);
            this.Controls.Add(this.tileCollection);
            this.Controls.Add(this.tileManufacturerBox);
            this.Controls.Add(this.tileManufacturer);
            this.Controls.Add(this.tileSizeBox);
            this.Controls.Add(this.tileSize);
            this.Controls.Add(this.safeDropHeightBox);
            this.Controls.Add(this.safeDropHeight);
            this.Controls.Add(this.rubberThicknessBox);
            this.Controls.Add(this.rubberThickness);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.rubberManufacturerBox);
            this.Controls.Add(this.rubberManufacturer);
            this.Controls.Add(this.rubberMaterialNameBox);
            this.Controls.Add(this.rubberMaterialName);
            this.Controls.Add(this.isInGeogridBox);
            this.Controls.Add(this.grainSizeBox);
            this.Controls.Add(this.grainSize);
            this.Controls.Add(this.fillMaterialBox);
            this.Controls.Add(this.fillMaterial);
            this.Controls.Add(this.acceptedLoadBox);
            this.Controls.Add(this.acceptedLoadLabel);
            this.Controls.Add(this.pavementTypeNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pointOfUseBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeOfРavementBox);
            this.Controls.Add(this.label1);
            this.Name = "CreatePavementLayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание покрытия";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox typeOfРavementBox;
        private ComboBox pointOfUseBox;
        private Label label2;
        private Label label3;
        private TextBox pavementTypeNameBox;
        private TextBox acceptedLoadBox;
        private TextBox fillMaterialBox;
        private TextBox grainSizeBox;
        private CheckBox isInGeogridBox;
        private TextBox rubberMaterialNameBox;
        private TextBox rubberManufacturerBox;
        private TextBox colorBox;
        private TextBox rubberThicknessBox;
        private TextBox safeDropHeightBox;
        private Label grainSize;
        private Label rubberMaterialName;
        private Label rubberManufacturer;
        private Label rubberThickness;
        private Label safeDropHeight;
        private TextBox tileSizeBox;
        private Label tileSize;
        private TextBox tileManufacturerBox;
        private Label tileManufacturer;
        private TextBox tileCollectionBox;
        private Label tileCollection;
        private Button createLayerButton;
        private Button closeButton;
        private Label label5;
        private Label label7;
        private TextBox transparencyBox;
        private Button colorSelect;
        private Label colorLabel;
        private Label lineweightLabel;
        private Button lineweightSelect;
        private Label acceptedLoadLabel;
        private Label fillMaterial;
        private TextBox paramBox;
        private Label paramLabel;
        private Label colorLab;
        private TextBox rubberModelBox;
        private Label rubberModelLabel;
    }
}