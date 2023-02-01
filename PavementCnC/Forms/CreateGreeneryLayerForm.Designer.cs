namespace PavementCnC.Forms
{
    partial class CreateGreeneryLayerForm
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
            this.lineweightLabel = new System.Windows.Forms.Label();
            this.lineweightSelect = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorSelect = new System.Windows.Forms.Button();
            this.transparencyBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.createLayerButton = new System.Windows.Forms.Button();
            this.itemOrAreaBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specialMaterialLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.specialMaterialBox = new System.Windows.Forms.TextBox();
            this.stoolbedSizeBox = new System.Windows.Forms.TextBox();
            this.plantTrunkGirthBox = new System.Windows.Forms.TextBox();
            this.trunkGirthLabel = new System.Windows.Forms.Label();
            this.plantCrownSizeBox = new System.Windows.Forms.TextBox();
            this.plantCrownSizeLabel = new System.Windows.Forms.Label();
            this.numberOfPlantsPerSQMBox = new System.Windows.Forms.TextBox();
            this.typeOfGreeneryBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.specialMaterialAreaBox = new System.Windows.Forms.TextBox();
            this.plantHeightBox = new System.Windows.Forms.TextBox();
            this.seedsBox = new System.Windows.Forms.TextBox();
            this.rolledBox = new System.Windows.Forms.ComboBox();
            this.specialMaterialAreaLabel = new System.Windows.Forms.Label();
            this.plantHeightLabel = new System.Windows.Forms.Label();
            this.plantsPerSQMLabel = new System.Windows.Forms.Label();
            this.seedsLabel = new System.Windows.Forms.Label();
            this.withSpecialPavementBox = new System.Windows.Forms.CheckBox();
            this.rolledLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lineweightLabel
            // 
            this.lineweightLabel.AutoSize = true;
            this.lineweightLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineweightLabel.Location = new System.Drawing.Point(259, 97);
            this.lineweightLabel.Name = "lineweightLabel";
            this.lineweightLabel.Size = new System.Drawing.Size(83, 13);
            this.lineweightLabel.TabIndex = 55;
            this.lineweightLabel.Text = "Выберите цвет";
            // 
            // lineweightSelect
            // 
            this.lineweightSelect.Location = new System.Drawing.Point(262, 71);
            this.lineweightSelect.Name = "lineweightSelect";
            this.lineweightSelect.Size = new System.Drawing.Size(142, 23);
            this.lineweightSelect.TabIndex = 54;
            this.lineweightSelect.Text = "Выбрать толщину линий";
            this.lineweightSelect.UseVisualStyleBackColor = true;
            this.lineweightSelect.Click += new System.EventHandler(this.lineweightSelect_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorLabel.Location = new System.Drawing.Point(259, 55);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(83, 13);
            this.colorLabel.TabIndex = 53;
            this.colorLabel.Text = "Выберите цвет";
            // 
            // colorSelect
            // 
            this.colorSelect.Location = new System.Drawing.Point(262, 29);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(142, 23);
            this.colorSelect.TabIndex = 52;
            this.colorSelect.Text = "Выбрать цвет";
            this.colorSelect.UseVisualStyleBackColor = true;
            this.colorSelect.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // transparencyBox
            // 
            this.transparencyBox.Location = new System.Drawing.Point(348, 117);
            this.transparencyBox.Name = "transparencyBox";
            this.transparencyBox.Size = new System.Drawing.Size(56, 20);
            this.transparencyBox.TabIndex = 51;
            this.transparencyBox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Прозрачность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Параметры нового слоя:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(288, 237);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 23);
            this.closeButton.TabIndex = 48;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // createLayerButton
            // 
            this.createLayerButton.Location = new System.Drawing.Point(263, 146);
            this.createLayerButton.Name = "createLayerButton";
            this.createLayerButton.Size = new System.Drawing.Size(141, 41);
            this.createLayerButton.TabIndex = 47;
            this.createLayerButton.Text = "Создать слой для озеленения";
            this.createLayerButton.UseVisualStyleBackColor = true;
            this.createLayerButton.Click += new System.EventHandler(this.createLayerButton_Click);
            // 
            // itemOrAreaBox
            // 
            this.itemOrAreaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemOrAreaBox.FormattingEnabled = true;
            this.itemOrAreaBox.Items.AddRange(new object[] {
            "Штучное",
            "Площадное"});
            this.itemOrAreaBox.Location = new System.Drawing.Point(113, 4);
            this.itemOrAreaBox.Name = "itemOrAreaBox";
            this.itemOrAreaBox.Size = new System.Drawing.Size(130, 21);
            this.itemOrAreaBox.TabIndex = 57;
            this.itemOrAreaBox.SelectedIndexChanged += new System.EventHandler(this.itemOrAreaBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Площадное/штучное:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Код:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Название рус.(лат.):";
            // 
            // specialMaterialLabel
            // 
            this.specialMaterialLabel.AutoSize = true;
            this.specialMaterialLabel.Location = new System.Drawing.Point(0, 165);
            this.specialMaterialLabel.Name = "specialMaterialLabel";
            this.specialMaterialLabel.Size = new System.Drawing.Size(108, 13);
            this.specialMaterialLabel.TabIndex = 62;
            this.specialMaterialLabel.Text = "Мульчир. материал:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Размер кома ДхВ,м:";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(113, 56);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(130, 20);
            this.codeBox.TabIndex = 67;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(113, 82);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(130, 20);
            this.nameBox.TabIndex = 68;
            // 
            // specialMaterialBox
            // 
            this.specialMaterialBox.Location = new System.Drawing.Point(113, 161);
            this.specialMaterialBox.Name = "specialMaterialBox";
            this.specialMaterialBox.Size = new System.Drawing.Size(130, 20);
            this.specialMaterialBox.TabIndex = 69;
            // 
            // stoolbedSizeBox
            // 
            this.stoolbedSizeBox.Location = new System.Drawing.Point(113, 108);
            this.stoolbedSizeBox.Name = "stoolbedSizeBox";
            this.stoolbedSizeBox.Size = new System.Drawing.Size(130, 20);
            this.stoolbedSizeBox.TabIndex = 71;
            // 
            // plantTrunkGirthBox
            // 
            this.plantTrunkGirthBox.Location = new System.Drawing.Point(113, 266);
            this.plantTrunkGirthBox.Name = "plantTrunkGirthBox";
            this.plantTrunkGirthBox.Size = new System.Drawing.Size(130, 20);
            this.plantTrunkGirthBox.TabIndex = 75;
            // 
            // trunkGirthLabel
            // 
            this.trunkGirthLabel.AutoSize = true;
            this.trunkGirthLabel.Location = new System.Drawing.Point(0, 269);
            this.trunkGirthLabel.Name = "trunkGirthLabel";
            this.trunkGirthLabel.Size = new System.Drawing.Size(98, 13);
            this.trunkGirthLabel.TabIndex = 74;
            this.trunkGirthLabel.Text = "Обхват ствола, м:";
            // 
            // plantCrownSizeBox
            // 
            this.plantCrownSizeBox.Location = new System.Drawing.Point(113, 240);
            this.plantCrownSizeBox.Name = "plantCrownSizeBox";
            this.plantCrownSizeBox.Size = new System.Drawing.Size(130, 20);
            this.plantCrownSizeBox.TabIndex = 77;
            // 
            // plantCrownSizeLabel
            // 
            this.plantCrownSizeLabel.AutoSize = true;
            this.plantCrownSizeLabel.Location = new System.Drawing.Point(0, 243);
            this.plantCrownSizeLabel.Name = "plantCrownSizeLabel";
            this.plantCrownSizeLabel.Size = new System.Drawing.Size(105, 13);
            this.plantCrownSizeLabel.TabIndex = 76;
            this.plantCrownSizeLabel.Text = "Диаметр кроны, м:";
            // 
            // numberOfPlantsPerSQMBox
            // 
            this.numberOfPlantsPerSQMBox.Location = new System.Drawing.Point(113, 266);
            this.numberOfPlantsPerSQMBox.Name = "numberOfPlantsPerSQMBox";
            this.numberOfPlantsPerSQMBox.Size = new System.Drawing.Size(130, 20);
            this.numberOfPlantsPerSQMBox.TabIndex = 79;
            this.numberOfPlantsPerSQMBox.Visible = false;
            // 
            // typeOfGreeneryBox
            // 
            this.typeOfGreeneryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfGreeneryBox.FormattingEnabled = true;
            this.typeOfGreeneryBox.Location = new System.Drawing.Point(113, 29);
            this.typeOfGreeneryBox.Name = "typeOfGreeneryBox";
            this.typeOfGreeneryBox.Size = new System.Drawing.Size(130, 21);
            this.typeOfGreeneryBox.TabIndex = 81;
            this.typeOfGreeneryBox.SelectedIndexChanged += new System.EventHandler(this.typeOfGreeneryBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Вид озеленения:";
            // 
            // specialMaterialAreaBox
            // 
            this.specialMaterialAreaBox.Location = new System.Drawing.Point(113, 188);
            this.specialMaterialAreaBox.Name = "specialMaterialAreaBox";
            this.specialMaterialAreaBox.Size = new System.Drawing.Size(130, 20);
            this.specialMaterialAreaBox.TabIndex = 70;
            // 
            // plantHeightBox
            // 
            this.plantHeightBox.Location = new System.Drawing.Point(113, 214);
            this.plantHeightBox.Name = "plantHeightBox";
            this.plantHeightBox.Size = new System.Drawing.Size(130, 20);
            this.plantHeightBox.TabIndex = 73;
            // 
            // seedsBox
            // 
            this.seedsBox.Location = new System.Drawing.Point(113, 108);
            this.seedsBox.Name = "seedsBox";
            this.seedsBox.Size = new System.Drawing.Size(130, 20);
            this.seedsBox.TabIndex = 83;
            this.seedsBox.Visible = false;
            // 
            // rolledBox
            // 
            this.rolledBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Посевной",
            "Рулонный"});
            this.rolledBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolledBox.FormattingEnabled = true;
            this.rolledBox.Items.AddRange(new object[] {
            "посевной",
            "рулонный"});
            this.rolledBox.Location = new System.Drawing.Point(113, 134);
            this.rolledBox.Name = "rolledBox";
            this.rolledBox.Size = new System.Drawing.Size(130, 21);
            this.rolledBox.TabIndex = 85;
            this.rolledBox.Visible = false;
            // 
            // specialMaterialAreaLabel
            // 
            this.specialMaterialAreaLabel.AutoSize = true;
            this.specialMaterialAreaLabel.Location = new System.Drawing.Point(0, 191);
            this.specialMaterialAreaLabel.Name = "specialMaterialAreaLabel";
            this.specialMaterialAreaLabel.Size = new System.Drawing.Size(96, 13);
            this.specialMaterialAreaLabel.TabIndex = 64;
            this.specialMaterialAreaLabel.Text = "Площадь мульчи:";
            // 
            // plantHeightLabel
            // 
            this.plantHeightLabel.AutoSize = true;
            this.plantHeightLabel.Location = new System.Drawing.Point(1, 217);
            this.plantHeightLabel.Name = "plantHeightLabel";
            this.plantHeightLabel.Size = new System.Drawing.Size(112, 13);
            this.plantHeightLabel.TabIndex = 72;
            this.plantHeightLabel.Text = "Высота растения, м:";
            // 
            // plantsPerSQMLabel
            // 
            this.plantsPerSQMLabel.AutoSize = true;
            this.plantsPerSQMLabel.Location = new System.Drawing.Point(0, 269);
            this.plantsPerSQMLabel.Name = "plantsPerSQMLabel";
            this.plantsPerSQMLabel.Size = new System.Drawing.Size(82, 13);
            this.plantsPerSQMLabel.TabIndex = 78;
            this.plantsPerSQMLabel.Text = "Норма на 1м2:";
            this.plantsPerSQMLabel.Visible = false;
            // 
            // seedsLabel
            // 
            this.seedsLabel.AutoSize = true;
            this.seedsLabel.Location = new System.Drawing.Point(0, 111);
            this.seedsLabel.Name = "seedsLabel";
            this.seedsLabel.Size = new System.Drawing.Size(110, 13);
            this.seedsLabel.TabIndex = 82;
            this.seedsLabel.Text = "Состав травосмеси:";
            this.seedsLabel.Visible = false;
            // 
            // withSpecialPavementBox
            // 
            this.withSpecialPavementBox.AutoSize = true;
            this.withSpecialPavementBox.Checked = true;
            this.withSpecialPavementBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.withSpecialPavementBox.Location = new System.Drawing.Point(113, 136);
            this.withSpecialPavementBox.Name = "withSpecialPavementBox";
            this.withSpecialPavementBox.Size = new System.Drawing.Size(122, 17);
            this.withSpecialPavementBox.TabIndex = 86;
            this.withSpecialPavementBox.Text = "С мульчированием";
            this.withSpecialPavementBox.UseVisualStyleBackColor = true;
            // 
            // rolledLabel
            // 
            this.rolledLabel.AutoSize = true;
            this.rolledLabel.Location = new System.Drawing.Point(0, 137);
            this.rolledLabel.Name = "rolledLabel";
            this.rolledLabel.Size = new System.Drawing.Size(67, 13);
            this.rolledLabel.TabIndex = 84;
            this.rolledLabel.Text = "Тип газона:";
            this.rolledLabel.Visible = false;
            // 
            // CreateGreeneryLayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 287);
            this.Controls.Add(this.withSpecialPavementBox);
            this.Controls.Add(this.rolledBox);
            this.Controls.Add(this.rolledLabel);
            this.Controls.Add(this.seedsBox);
            this.Controls.Add(this.seedsLabel);
            this.Controls.Add(this.typeOfGreeneryBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numberOfPlantsPerSQMBox);
            this.Controls.Add(this.plantsPerSQMLabel);
            this.Controls.Add(this.plantCrownSizeBox);
            this.Controls.Add(this.plantCrownSizeLabel);
            this.Controls.Add(this.plantTrunkGirthBox);
            this.Controls.Add(this.trunkGirthLabel);
            this.Controls.Add(this.plantHeightBox);
            this.Controls.Add(this.plantHeightLabel);
            this.Controls.Add(this.stoolbedSizeBox);
            this.Controls.Add(this.specialMaterialAreaBox);
            this.Controls.Add(this.specialMaterialBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.specialMaterialAreaLabel);
            this.Controls.Add(this.specialMaterialLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemOrAreaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineweightLabel);
            this.Controls.Add(this.lineweightSelect);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorSelect);
            this.Controls.Add(this.transparencyBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.createLayerButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "CreateGreeneryLayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание слоя озеленения";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lineweightLabel;
        private System.Windows.Forms.Button lineweightSelect;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Button colorSelect;
        private System.Windows.Forms.TextBox transparencyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button createLayerButton;
        private System.Windows.Forms.ComboBox itemOrAreaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label specialMaterialLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox specialMaterialBox;
        private System.Windows.Forms.TextBox stoolbedSizeBox;
        private System.Windows.Forms.TextBox plantTrunkGirthBox;
        private System.Windows.Forms.Label trunkGirthLabel;
        private System.Windows.Forms.TextBox plantCrownSizeBox;
        private System.Windows.Forms.Label plantCrownSizeLabel;
        private System.Windows.Forms.TextBox numberOfPlantsPerSQMBox;
        private System.Windows.Forms.ComboBox typeOfGreeneryBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox specialMaterialAreaBox;
        private System.Windows.Forms.TextBox plantHeightBox;
        private System.Windows.Forms.TextBox seedsBox;
        private System.Windows.Forms.ComboBox rolledBox;
        private System.Windows.Forms.Label specialMaterialAreaLabel;
        private System.Windows.Forms.Label plantHeightLabel;
        private System.Windows.Forms.Label plantsPerSQMLabel;
        private System.Windows.Forms.Label seedsLabel;
        private System.Windows.Forms.CheckBox withSpecialPavementBox;
        private System.Windows.Forms.Label rolledLabel;
    }
}