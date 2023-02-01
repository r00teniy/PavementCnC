namespace PavementCnC.Forms
{
    partial class CreateCurbLayerForm
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
            this.createCurbLayerButton = new System.Windows.Forms.Button();
            this.curbColorBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.curbManufacturerBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.curbNameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.curbSizeBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.curbCodeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.curbMaterialBox = new System.Windows.Forms.ComboBox();
            this.lineweightLabel = new System.Windows.Forms.Label();
            this.lineweightSelect = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorSelect = new System.Windows.Forms.Button();
            this.transparencyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createCurbLayerButton
            // 
            this.createCurbLayerButton.Location = new System.Drawing.Point(110, 171);
            this.createCurbLayerButton.Name = "createCurbLayerButton";
            this.createCurbLayerButton.Size = new System.Drawing.Size(130, 23);
            this.createCurbLayerButton.TabIndex = 91;
            this.createCurbLayerButton.Text = "Создать слой борта";
            this.createCurbLayerButton.UseVisualStyleBackColor = true;
            this.createCurbLayerButton.Click += new System.EventHandler(this.createCurbLayerButton_Click);
            // 
            // curbColorBox
            // 
            this.curbColorBox.Location = new System.Drawing.Point(110, 142);
            this.curbColorBox.Name = "curbColorBox";
            this.curbColorBox.Size = new System.Drawing.Size(130, 20);
            this.curbColorBox.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 89;
            this.label12.Text = "Цвет:";
            // 
            // curbManufacturerBox
            // 
            this.curbManufacturerBox.Location = new System.Drawing.Point(110, 116);
            this.curbManufacturerBox.Name = "curbManufacturerBox";
            this.curbManufacturerBox.Size = new System.Drawing.Size(130, 20);
            this.curbManufacturerBox.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "Производитель:";
            // 
            // curbNameBox
            // 
            this.curbNameBox.Location = new System.Drawing.Point(110, 90);
            this.curbNameBox.Name = "curbNameBox";
            this.curbNameBox.Size = new System.Drawing.Size(130, 20);
            this.curbNameBox.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "Наименование:";
            // 
            // curbSizeBox
            // 
            this.curbSizeBox.Location = new System.Drawing.Point(110, 64);
            this.curbSizeBox.Name = "curbSizeBox";
            this.curbSizeBox.Size = new System.Drawing.Size(130, 20);
            this.curbSizeBox.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Размер:";
            // 
            // curbCodeBox
            // 
            this.curbCodeBox.Location = new System.Drawing.Point(110, 38);
            this.curbCodeBox.Name = "curbCodeBox";
            this.curbCodeBox.Size = new System.Drawing.Size(130, 20);
            this.curbCodeBox.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Код:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Материал борта:";
            // 
            // curbMaterialBox
            // 
            this.curbMaterialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.curbMaterialBox.FormattingEnabled = true;
            this.curbMaterialBox.Location = new System.Drawing.Point(110, 12);
            this.curbMaterialBox.Name = "curbMaterialBox";
            this.curbMaterialBox.Size = new System.Drawing.Size(130, 21);
            this.curbMaterialBox.TabIndex = 79;
            // 
            // lineweightLabel
            // 
            this.lineweightLabel.AutoSize = true;
            this.lineweightLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineweightLabel.Location = new System.Drawing.Point(251, 102);
            this.lineweightLabel.Name = "lineweightLabel";
            this.lineweightLabel.Size = new System.Drawing.Size(83, 13);
            this.lineweightLabel.TabIndex = 100;
            this.lineweightLabel.Text = "Выберите цвет";
            // 
            // lineweightSelect
            // 
            this.lineweightSelect.Location = new System.Drawing.Point(254, 76);
            this.lineweightSelect.Name = "lineweightSelect";
            this.lineweightSelect.Size = new System.Drawing.Size(142, 23);
            this.lineweightSelect.TabIndex = 99;
            this.lineweightSelect.Text = "Выбрать толщину линий";
            this.lineweightSelect.UseVisualStyleBackColor = true;
            this.lineweightSelect.Click += new System.EventHandler(this.lineweightSelect_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorLabel.Location = new System.Drawing.Point(251, 60);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(83, 13);
            this.colorLabel.TabIndex = 98;
            this.colorLabel.Text = "Выберите цвет";
            // 
            // colorSelect
            // 
            this.colorSelect.Location = new System.Drawing.Point(254, 34);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(142, 23);
            this.colorSelect.TabIndex = 97;
            this.colorSelect.Text = "Выбрать цвет";
            this.colorSelect.UseVisualStyleBackColor = true;
            this.colorSelect.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // transparencyBox
            // 
            this.transparencyBox.Location = new System.Drawing.Point(340, 122);
            this.transparencyBox.Name = "transparencyBox";
            this.transparencyBox.Size = new System.Drawing.Size(56, 20);
            this.transparencyBox.TabIndex = 96;
            this.transparencyBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Прозрачность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Параметры нового слоя:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(290, 171);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 23);
            this.closeButton.TabIndex = 93;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CreateCurbLayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 197);
            this.Controls.Add(this.lineweightLabel);
            this.Controls.Add(this.lineweightSelect);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorSelect);
            this.Controls.Add(this.transparencyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.createCurbLayerButton);
            this.Controls.Add(this.curbColorBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.curbManufacturerBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.curbNameBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.curbSizeBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.curbCodeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.curbMaterialBox);
            this.Name = "CreateCurbLayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание слоя борта";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createCurbLayerButton;
        private System.Windows.Forms.TextBox curbColorBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox curbManufacturerBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox curbNameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox curbSizeBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox curbCodeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox curbMaterialBox;
        private System.Windows.Forms.Label lineweightLabel;
        private System.Windows.Forms.Button lineweightSelect;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Button colorSelect;
        private System.Windows.Forms.TextBox transparencyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeButton;
    }
}