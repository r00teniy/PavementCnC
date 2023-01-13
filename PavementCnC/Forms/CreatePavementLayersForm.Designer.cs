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
            this.acceptedLoad = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.materialCodeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип покрытия:";
            // 
            // pavementTypeNameBox
            // 
            this.pavementTypeNameBox.Location = new System.Drawing.Point(126, 64);
            this.pavementTypeNameBox.Name = "pavementTypeNameBox";
            this.pavementTypeNameBox.Size = new System.Drawing.Size(130, 20);
            this.pavementTypeNameBox.TabIndex = 5;
            // 
            // acceptedLoad
            // 
            this.acceptedLoad.Location = new System.Drawing.Point(154, 115);
            this.acceptedLoad.Name = "acceptedLoad";
            this.acceptedLoad.Size = new System.Drawing.Size(102, 20);
            this.acceptedLoad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Допустимая нагрузка, т.:";
            // 
            // concreteClassBox
            // 
            this.concreteClassBox.Location = new System.Drawing.Point(154, 141);
            this.concreteClassBox.Name = "concreteClassBox";
            this.concreteClassBox.Size = new System.Drawing.Size(102, 20);
            this.concreteClassBox.TabIndex = 9;
            this.concreteClassBox.Visible = false;
            // 
            // fillMaterialBox
            // 
            this.fillMaterialBox.Location = new System.Drawing.Point(154, 141);
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
            this.isInGeogridBox.Location = new System.Drawing.Point(154, 193);
            this.isInGeogridBox.Name = "isInGeogridBox";
            this.isInGeogridBox.Size = new System.Drawing.Size(15, 14);
            this.isInGeogridBox.TabIndex = 15;
            this.isInGeogridBox.UseVisualStyleBackColor = true;
            this.isInGeogridBox.Visible = false;
            // 
            // rubberMaterialNameBox
            // 
            this.rubberMaterialNameBox.Location = new System.Drawing.Point(154, 141);
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
            // rubberColorBox
            // 
            this.rubberColorBox.Location = new System.Drawing.Point(154, 195);
            this.rubberColorBox.Name = "rubberColorBox";
            this.rubberColorBox.Size = new System.Drawing.Size(102, 20);
            this.rubberColorBox.TabIndex = 21;
            this.rubberColorBox.Visible = false;
            // 
            // rubberThicknessBox
            // 
            this.rubberThicknessBox.Location = new System.Drawing.Point(154, 221);
            this.rubberThicknessBox.Name = "rubberThicknessBox";
            this.rubberThicknessBox.Size = new System.Drawing.Size(102, 20);
            this.rubberThicknessBox.TabIndex = 23;
            this.rubberThicknessBox.Visible = false;
            // 
            // safeDropHeightBox
            // 
            this.safeDropHeightBox.Location = new System.Drawing.Point(154, 247);
            this.safeDropHeightBox.Name = "safeDropHeightBox";
            this.safeDropHeightBox.Size = new System.Drawing.Size(102, 20);
            this.safeDropHeightBox.TabIndex = 25;
            this.safeDropHeightBox.Visible = false;
            // 
            // concreteClass
            // 
            this.concreteClass.AutoSize = true;
            this.concreteClass.Location = new System.Drawing.Point(13, 143);
            this.concreteClass.Name = "concreteClass";
            this.concreteClass.Size = new System.Drawing.Size(79, 13);
            this.concreteClass.TabIndex = 8;
            this.concreteClass.Text = "Класс бетона:";
            this.concreteClass.Visible = false;
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
            // fillMaterial
            // 
            this.fillMaterial.AutoSize = true;
            this.fillMaterial.Location = new System.Drawing.Point(13, 143);
            this.fillMaterial.Name = "fillMaterial";
            this.fillMaterial.Size = new System.Drawing.Size(114, 13);
            this.fillMaterial.TabIndex = 10;
            this.fillMaterial.Text = "Насыпной материал:";
            this.fillMaterial.Visible = false;
            // 
            // rubberMaterialName
            // 
            this.rubberMaterialName.AutoSize = true;
            this.rubberMaterialName.Location = new System.Drawing.Point(13, 143);
            this.rubberMaterialName.Name = "rubberMaterialName";
            this.rubberMaterialName.Size = new System.Drawing.Size(112, 13);
            this.rubberMaterialName.TabIndex = 16;
            this.rubberMaterialName.Text = "Материал покрытия:";
            this.rubberMaterialName.Visible = false;
            // 
            // rubberManufacturer
            // 
            this.rubberManufacturer.AutoSize = true;
            this.rubberManufacturer.Location = new System.Drawing.Point(13, 171);
            this.rubberManufacturer.Name = "rubberManufacturer";
            this.rubberManufacturer.Size = new System.Drawing.Size(141, 13);
            this.rubberManufacturer.TabIndex = 18;
            this.rubberManufacturer.Text = "Производитель покрытия:";
            this.rubberManufacturer.Visible = false;
            // 
            // isInsideGeogrid
            // 
            this.isInsideGeogrid.AutoSize = true;
            this.isInsideGeogrid.Location = new System.Drawing.Point(14, 194);
            this.isInsideGeogrid.Name = "isInsideGeogrid";
            this.isInsideGeogrid.Size = new System.Drawing.Size(83, 13);
            this.isInsideGeogrid.TabIndex = 14;
            this.isInsideGeogrid.Text = "В георешетке?";
            this.isInsideGeogrid.Visible = false;
            // 
            // rubberColor
            // 
            this.rubberColor.AutoSize = true;
            this.rubberColor.Location = new System.Drawing.Point(13, 197);
            this.rubberColor.Name = "rubberColor";
            this.rubberColor.Size = new System.Drawing.Size(87, 13);
            this.rubberColor.TabIndex = 20;
            this.rubberColor.Text = "Цвет покрытия:";
            this.rubberColor.Visible = false;
            // 
            // rubberThickness
            // 
            this.rubberThickness.AutoSize = true;
            this.rubberThickness.Location = new System.Drawing.Point(13, 223);
            this.rubberThickness.Name = "rubberThickness";
            this.rubberThickness.Size = new System.Drawing.Size(130, 13);
            this.rubberThickness.TabIndex = 22;
            this.rubberThickness.Text = "Толщина покрытия, мм:";
            this.rubberThickness.Visible = false;
            // 
            // safeDropHeight
            // 
            this.safeDropHeight.AutoSize = true;
            this.safeDropHeight.Location = new System.Drawing.Point(13, 249);
            this.safeDropHeight.Name = "safeDropHeight";
            this.safeDropHeight.Size = new System.Drawing.Size(129, 13);
            this.safeDropHeight.TabIndex = 24;
            this.safeDropHeight.Text = "Max высота падения, м:";
            this.safeDropHeight.Visible = false;
            // 
            // tileSizeBox
            // 
            this.tileSizeBox.Location = new System.Drawing.Point(154, 141);
            this.tileSizeBox.Name = "tileSizeBox";
            this.tileSizeBox.Size = new System.Drawing.Size(102, 20);
            this.tileSizeBox.TabIndex = 27;
            this.tileSizeBox.Visible = false;
            // 
            // tileSize
            // 
            this.tileSize.AutoSize = true;
            this.tileSize.Location = new System.Drawing.Point(13, 143);
            this.tileSize.Name = "tileSize";
            this.tileSize.Size = new System.Drawing.Size(87, 13);
            this.tileSize.TabIndex = 26;
            this.tileSize.Text = "Размер плитки:";
            this.tileSize.Visible = false;
            // 
            // tileManufacturerBox
            // 
            this.tileManufacturerBox.Location = new System.Drawing.Point(154, 169);
            this.tileManufacturerBox.Name = "tileManufacturerBox";
            this.tileManufacturerBox.Size = new System.Drawing.Size(102, 20);
            this.tileManufacturerBox.TabIndex = 29;
            this.tileManufacturerBox.Visible = false;
            // 
            // tileManufacturer
            // 
            this.tileManufacturer.AutoSize = true;
            this.tileManufacturer.Location = new System.Drawing.Point(13, 171);
            this.tileManufacturer.Name = "tileManufacturer";
            this.tileManufacturer.Size = new System.Drawing.Size(127, 13);
            this.tileManufacturer.TabIndex = 28;
            this.tileManufacturer.Text = "Производитель плитки:";
            this.tileManufacturer.Visible = false;
            // 
            // tileColorBox
            // 
            this.tileColorBox.Location = new System.Drawing.Point(154, 197);
            this.tileColorBox.Name = "tileColorBox";
            this.tileColorBox.Size = new System.Drawing.Size(102, 20);
            this.tileColorBox.TabIndex = 31;
            this.tileColorBox.Visible = false;
            // 
            // tileColor
            // 
            this.tileColor.AutoSize = true;
            this.tileColor.Location = new System.Drawing.Point(13, 199);
            this.tileColor.Name = "tileColor";
            this.tileColor.Size = new System.Drawing.Size(73, 13);
            this.tileColor.TabIndex = 30;
            this.tileColor.Text = "Цвет плитки:";
            this.tileColor.Visible = false;
            // 
            // tileCollectionBox
            // 
            this.tileCollectionBox.Location = new System.Drawing.Point(154, 223);
            this.tileCollectionBox.Name = "tileCollectionBox";
            this.tileCollectionBox.Size = new System.Drawing.Size(102, 20);
            this.tileCollectionBox.TabIndex = 33;
            this.tileCollectionBox.Visible = false;
            // 
            // tileCollection
            // 
            this.tileCollection.AutoSize = true;
            this.tileCollection.Location = new System.Drawing.Point(13, 225);
            this.tileCollection.Name = "tileCollection";
            this.tileCollection.Size = new System.Drawing.Size(103, 13);
            this.tileCollection.TabIndex = 32;
            this.tileCollection.Text = "Коллекция плитки:";
            this.tileCollection.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Создать покрытие";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // materialCodeBox
            // 
            this.materialCodeBox.Location = new System.Drawing.Point(154, 89);
            this.materialCodeBox.Name = "materialCodeBox";
            this.materialCodeBox.Size = new System.Drawing.Size(102, 20);
            this.materialCodeBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "MaterialCode:";
            // 
            // CreatePavementLayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(271, 309);
            this.Controls.Add(this.materialCodeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.acceptedLoad);
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
        private TextBox acceptedLoad;
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
        private Button button1;
        private Button button2;
        private TextBox materialCodeBox;
        private Label label5;
    }
}