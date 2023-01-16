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
            this.label4 = new System.Windows.Forms.Label();
            this.concreteClassBox = new System.Windows.Forms.TextBox();
            this.fillMaterialBox = new System.Windows.Forms.TextBox();
            this.grainSizeBox = new System.Windows.Forms.TextBox();
            this.isInGeogridBox = new System.Windows.Forms.CheckBox();
            this.rubberMaterialNameBox = new System.Windows.Forms.TextBox();
            this.rubberManufacturerBox = new System.Windows.Forms.TextBox();
            this.rubberColorBox = new System.Windows.Forms.TextBox();
            this.rubberThicknessBox = new System.Windows.Forms.TextBox();
            this.safeDropHeightBox = new System.Windows.Forms.TextBox();
            this.concreteClass = new System.Windows.Forms.Label();
            this.grainSize = new System.Windows.Forms.Label();
            this.fillMaterial = new System.Windows.Forms.Label();
            this.rubberMaterialName = new System.Windows.Forms.Label();
            this.rubberManufacturer = new System.Windows.Forms.Label();
            this.isInsideGeogrid = new System.Windows.Forms.Label();
            this.rubberColor = new System.Windows.Forms.Label();
            this.rubberThickness = new System.Windows.Forms.Label();
            this.safeDropHeight = new System.Windows.Forms.Label();
            this.tileSizeBox = new System.Windows.Forms.TextBox();
            this.tileSize = new System.Windows.Forms.Label();
            this.tileManufacturerBox = new System.Windows.Forms.TextBox();
            this.tileManufacturer = new System.Windows.Forms.Label();
            this.tileColorBox = new System.Windows.Forms.TextBox();
            this.tileColor = new System.Windows.Forms.Label();
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
            this.acceptedLoadBox.Location = new System.Drawing.Point(154, 90);
            this.acceptedLoadBox.Name = "acceptedLoadBox";
            this.acceptedLoadBox.Size = new System.Drawing.Size(102, 20);
            this.acceptedLoadBox.TabIndex = 7;
            this.acceptedLoadBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Допустимая нагрузка, т.:";
            // 
            // concreteClassBox
            // 
            this.concreteClassBox.Location = new System.Drawing.Point(154, 116);
            this.concreteClassBox.Name = "concreteClassBox";
            this.concreteClassBox.Size = new System.Drawing.Size(102, 20);
            this.concreteClassBox.TabIndex = 9;
            this.concreteClassBox.Visible = false;
            // 
            // fillMaterialBox
            // 
            this.fillMaterialBox.Location = new System.Drawing.Point(154, 116);
            this.fillMaterialBox.Name = "fillMaterialBox";
            this.fillMaterialBox.Size = new System.Drawing.Size(102, 20);
            this.fillMaterialBox.TabIndex = 11;
            this.fillMaterialBox.Visible = false;
            // 
            // grainSizeBox
            // 
            this.grainSizeBox.Location = new System.Drawing.Point(154, 142);
            this.grainSizeBox.Name = "grainSizeBox";
            this.grainSizeBox.Size = new System.Drawing.Size(102, 20);
            this.grainSizeBox.TabIndex = 13;
            this.grainSizeBox.Visible = false;
            // 
            // isInGeogridBox
            // 
            this.isInGeogridBox.AutoSize = true;
            this.isInGeogridBox.Location = new System.Drawing.Point(154, 168);
            this.isInGeogridBox.Name = "isInGeogridBox";
            this.isInGeogridBox.Size = new System.Drawing.Size(15, 14);
            this.isInGeogridBox.TabIndex = 15;
            this.isInGeogridBox.UseVisualStyleBackColor = true;
            this.isInGeogridBox.Visible = false;
            // 
            // rubberMaterialNameBox
            // 
            this.rubberMaterialNameBox.Location = new System.Drawing.Point(154, 116);
            this.rubberMaterialNameBox.Name = "rubberMaterialNameBox";
            this.rubberMaterialNameBox.Size = new System.Drawing.Size(102, 20);
            this.rubberMaterialNameBox.TabIndex = 17;
            this.rubberMaterialNameBox.Visible = false;
            // 
            // rubberManufacturerBox
            // 
            this.rubberManufacturerBox.Location = new System.Drawing.Point(154, 144);
            this.rubberManufacturerBox.Name = "rubberManufacturerBox";
            this.rubberManufacturerBox.Size = new System.Drawing.Size(102, 20);
            this.rubberManufacturerBox.TabIndex = 19;
            this.rubberManufacturerBox.Visible = false;
            // 
            // rubberColorBox
            // 
            this.rubberColorBox.Location = new System.Drawing.Point(154, 170);
            this.rubberColorBox.Name = "rubberColorBox";
            this.rubberColorBox.Size = new System.Drawing.Size(102, 20);
            this.rubberColorBox.TabIndex = 21;
            this.rubberColorBox.Visible = false;
            // 
            // rubberThicknessBox
            // 
            this.rubberThicknessBox.Location = new System.Drawing.Point(154, 196);
            this.rubberThicknessBox.Name = "rubberThicknessBox";
            this.rubberThicknessBox.Size = new System.Drawing.Size(102, 20);
            this.rubberThicknessBox.TabIndex = 23;
            this.rubberThicknessBox.Visible = false;
            // 
            // safeDropHeightBox
            // 
            this.safeDropHeightBox.Location = new System.Drawing.Point(154, 222);
            this.safeDropHeightBox.Name = "safeDropHeightBox";
            this.safeDropHeightBox.Size = new System.Drawing.Size(102, 20);
            this.safeDropHeightBox.TabIndex = 25;
            this.safeDropHeightBox.Visible = false;
            // 
            // concreteClass
            // 
            this.concreteClass.AutoSize = true;
            this.concreteClass.Location = new System.Drawing.Point(13, 118);
            this.concreteClass.Name = "concreteClass";
            this.concreteClass.Size = new System.Drawing.Size(79, 13);
            this.concreteClass.TabIndex = 8;
            this.concreteClass.Text = "Класс бетона:";
            this.concreteClass.Visible = false;
            // 
            // grainSize
            // 
            this.grainSize.AutoSize = true;
            this.grainSize.Location = new System.Drawing.Point(13, 144);
            this.grainSize.Name = "grainSize";
            this.grainSize.Size = new System.Drawing.Size(115, 13);
            this.grainSize.TabIndex = 12;
            this.grainSize.Text = "Фракция материала:";
            this.grainSize.Visible = false;
            // 
            // fillMaterial
            // 
            this.fillMaterial.AutoSize = true;
            this.fillMaterial.Location = new System.Drawing.Point(13, 118);
            this.fillMaterial.Name = "fillMaterial";
            this.fillMaterial.Size = new System.Drawing.Size(114, 13);
            this.fillMaterial.TabIndex = 10;
            this.fillMaterial.Text = "Насыпной материал:";
            this.fillMaterial.Visible = false;
            // 
            // rubberMaterialName
            // 
            this.rubberMaterialName.AutoSize = true;
            this.rubberMaterialName.Location = new System.Drawing.Point(13, 118);
            this.rubberMaterialName.Name = "rubberMaterialName";
            this.rubberMaterialName.Size = new System.Drawing.Size(112, 13);
            this.rubberMaterialName.TabIndex = 16;
            this.rubberMaterialName.Text = "Материал покрытия:";
            this.rubberMaterialName.Visible = false;
            // 
            // rubberManufacturer
            // 
            this.rubberManufacturer.AutoSize = true;
            this.rubberManufacturer.Location = new System.Drawing.Point(13, 146);
            this.rubberManufacturer.Name = "rubberManufacturer";
            this.rubberManufacturer.Size = new System.Drawing.Size(141, 13);
            this.rubberManufacturer.TabIndex = 18;
            this.rubberManufacturer.Text = "Производитель покрытия:";
            this.rubberManufacturer.Visible = false;
            // 
            // isInsideGeogrid
            // 
            this.isInsideGeogrid.AutoSize = true;
            this.isInsideGeogrid.Location = new System.Drawing.Point(14, 169);
            this.isInsideGeogrid.Name = "isInsideGeogrid";
            this.isInsideGeogrid.Size = new System.Drawing.Size(83, 13);
            this.isInsideGeogrid.TabIndex = 14;
            this.isInsideGeogrid.Text = "В георешетке?";
            this.isInsideGeogrid.Visible = false;
            // 
            // rubberColor
            // 
            this.rubberColor.AutoSize = true;
            this.rubberColor.Location = new System.Drawing.Point(13, 172);
            this.rubberColor.Name = "rubberColor";
            this.rubberColor.Size = new System.Drawing.Size(87, 13);
            this.rubberColor.TabIndex = 20;
            this.rubberColor.Text = "Цвет покрытия:";
            this.rubberColor.Visible = false;
            // 
            // rubberThickness
            // 
            this.rubberThickness.AutoSize = true;
            this.rubberThickness.Location = new System.Drawing.Point(13, 198);
            this.rubberThickness.Name = "rubberThickness";
            this.rubberThickness.Size = new System.Drawing.Size(130, 13);
            this.rubberThickness.TabIndex = 22;
            this.rubberThickness.Text = "Толщина покрытия, мм:";
            this.rubberThickness.Visible = false;
            // 
            // safeDropHeight
            // 
            this.safeDropHeight.AutoSize = true;
            this.safeDropHeight.Location = new System.Drawing.Point(13, 224);
            this.safeDropHeight.Name = "safeDropHeight";
            this.safeDropHeight.Size = new System.Drawing.Size(129, 13);
            this.safeDropHeight.TabIndex = 24;
            this.safeDropHeight.Text = "Max высота падения, м:";
            this.safeDropHeight.Visible = false;
            // 
            // tileSizeBox
            // 
            this.tileSizeBox.Location = new System.Drawing.Point(154, 116);
            this.tileSizeBox.Name = "tileSizeBox";
            this.tileSizeBox.Size = new System.Drawing.Size(102, 20);
            this.tileSizeBox.TabIndex = 27;
            this.tileSizeBox.Visible = false;
            // 
            // tileSize
            // 
            this.tileSize.AutoSize = true;
            this.tileSize.Location = new System.Drawing.Point(13, 118);
            this.tileSize.Name = "tileSize";
            this.tileSize.Size = new System.Drawing.Size(87, 13);
            this.tileSize.TabIndex = 26;
            this.tileSize.Text = "Размер плитки:";
            this.tileSize.Visible = false;
            // 
            // tileManufacturerBox
            // 
            this.tileManufacturerBox.Location = new System.Drawing.Point(154, 144);
            this.tileManufacturerBox.Name = "tileManufacturerBox";
            this.tileManufacturerBox.Size = new System.Drawing.Size(102, 20);
            this.tileManufacturerBox.TabIndex = 29;
            this.tileManufacturerBox.Visible = false;
            // 
            // tileManufacturer
            // 
            this.tileManufacturer.AutoSize = true;
            this.tileManufacturer.Location = new System.Drawing.Point(13, 146);
            this.tileManufacturer.Name = "tileManufacturer";
            this.tileManufacturer.Size = new System.Drawing.Size(127, 13);
            this.tileManufacturer.TabIndex = 28;
            this.tileManufacturer.Text = "Производитель плитки:";
            this.tileManufacturer.Visible = false;
            // 
            // tileColorBox
            // 
            this.tileColorBox.Location = new System.Drawing.Point(154, 172);
            this.tileColorBox.Name = "tileColorBox";
            this.tileColorBox.Size = new System.Drawing.Size(102, 20);
            this.tileColorBox.TabIndex = 31;
            this.tileColorBox.Visible = false;
            // 
            // tileColor
            // 
            this.tileColor.AutoSize = true;
            this.tileColor.Location = new System.Drawing.Point(13, 174);
            this.tileColor.Name = "tileColor";
            this.tileColor.Size = new System.Drawing.Size(73, 13);
            this.tileColor.TabIndex = 30;
            this.tileColor.Text = "Цвет плитки:";
            this.tileColor.Visible = false;
            // 
            // tileCollectionBox
            // 
            this.tileCollectionBox.Location = new System.Drawing.Point(154, 198);
            this.tileCollectionBox.Name = "tileCollectionBox";
            this.tileCollectionBox.Size = new System.Drawing.Size(102, 20);
            this.tileCollectionBox.TabIndex = 33;
            this.tileCollectionBox.Visible = false;
            // 
            // tileCollection
            // 
            this.tileCollection.AutoSize = true;
            this.tileCollection.Location = new System.Drawing.Point(13, 200);
            this.tileCollection.Name = "tileCollection";
            this.tileCollection.Size = new System.Drawing.Size(103, 13);
            this.tileCollection.TabIndex = 32;
            this.tileCollection.Text = "Коллекция плитки:";
            this.tileCollection.Visible = false;
            // 
            // createLayerButton
            // 
            this.createLayerButton.Location = new System.Drawing.Point(295, 149);
            this.createLayerButton.Name = "createLayerButton";
            this.createLayerButton.Size = new System.Drawing.Size(96, 41);
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
            // CreatePavementLayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 250);
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
            this.Controls.Add(this.tileColorBox);
            this.Controls.Add(this.tileColor);
            this.Controls.Add(this.tileManufacturerBox);
            this.Controls.Add(this.tileManufacturer);
            this.Controls.Add(this.tileSizeBox);
            this.Controls.Add(this.tileSize);
            this.Controls.Add(this.safeDropHeightBox);
            this.Controls.Add(this.safeDropHeight);
            this.Controls.Add(this.rubberThicknessBox);
            this.Controls.Add(this.rubberThickness);
            this.Controls.Add(this.rubberColorBox);
            this.Controls.Add(this.rubberColor);
            this.Controls.Add(this.rubberManufacturerBox);
            this.Controls.Add(this.rubberManufacturer);
            this.Controls.Add(this.rubberMaterialNameBox);
            this.Controls.Add(this.rubberMaterialName);
            this.Controls.Add(this.isInGeogridBox);
            this.Controls.Add(this.isInsideGeogrid);
            this.Controls.Add(this.grainSizeBox);
            this.Controls.Add(this.grainSize);
            this.Controls.Add(this.fillMaterialBox);
            this.Controls.Add(this.fillMaterial);
            this.Controls.Add(this.concreteClassBox);
            this.Controls.Add(this.concreteClass);
            this.Controls.Add(this.acceptedLoadBox);
            this.Controls.Add(this.label4);
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
        private Label label4;
        private TextBox concreteClassBox;
        private TextBox fillMaterialBox;
        private TextBox grainSizeBox;
        private CheckBox isInGeogridBox;
        private TextBox rubberMaterialNameBox;
        private TextBox rubberManufacturerBox;
        private TextBox rubberColorBox;
        private TextBox rubberThicknessBox;
        private TextBox safeDropHeightBox;
        private Label concreteClass;
        private Label grainSize;
        private Label fillMaterial;
        private Label rubberMaterialName;
        private Label rubberManufacturer;
        private Label isInsideGeogrid;
        private Label rubberColor;
        private Label rubberThickness;
        private Label safeDropHeight;
        private TextBox tileSizeBox;
        private Label tileSize;
        private TextBox tileManufacturerBox;
        private Label tileManufacturer;
        private TextBox tileColorBox;
        private Label tileColor;
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
    }
}