namespace PavementCnC.Forms
{
    partial class MainForm
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
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hatchStyleDelete = new System.Windows.Forms.Button();
            this.hatchStyleCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pavementHatchStyleBox = new System.Windows.Forms.ComboBox();
            this.cPaveHatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pavementListBox = new System.Windows.Forms.ListBox();
            this.pavementTypeBox = new System.Windows.Forms.ComboBox();
            this.bCreatePaveType = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.greeneryHatchStyleDelete = new System.Windows.Forms.Button();
            this.greneryHatchStyleCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.greeneryHatchStyleBox = new System.Windows.Forms.ComboBox();
            this.greeneryHatchCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.greeneryListBox = new System.Windows.Forms.ListBox();
            this.greeneryTypeBox = new System.Windows.Forms.ComboBox();
            this.greeneryLayerCreate = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableTypeBox = new System.Windows.Forms.ComboBox();
            this.tableCreateButton = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.createCurbLayerButton = new System.Windows.Forms.Button();
            this.tabsControl.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabPage0);
            this.tabsControl.Controls.Add(this.tabPage1);
            this.tabsControl.Controls.Add(this.tabPage2);
            this.tabsControl.Controls.Add(this.tabPage3);
            this.tabsControl.Location = new System.Drawing.Point(12, 12);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(317, 222);
            this.tabsControl.TabIndex = 0;
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.createCurbLayerButton);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Size = new System.Drawing.Size(309, 196);
            this.tabPage0.TabIndex = 3;
            this.tabPage0.Text = "Борт";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cPaveHatch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pavementListBox);
            this.tabPage1.Controls.Add(this.pavementTypeBox);
            this.tabPage1.Controls.Add(this.bCreatePaveType);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(309, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Покрытия";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Детали покрытия:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hatchStyleDelete);
            this.groupBox1.Controls.Add(this.hatchStyleCreate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pavementHatchStyleBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Штриховка покрытия";
            // 
            // hatchStyleDelete
            // 
            this.hatchStyleDelete.Location = new System.Drawing.Point(9, 87);
            this.hatchStyleDelete.Name = "hatchStyleDelete";
            this.hatchStyleDelete.Size = new System.Drawing.Size(157, 22);
            this.hatchStyleDelete.TabIndex = 8;
            this.hatchStyleDelete.Text = "Удалить стиль штриховки";
            this.hatchStyleDelete.UseVisualStyleBackColor = true;
            this.hatchStyleDelete.Click += new System.EventHandler(this.pavementHatchStyleDelete_Click);
            // 
            // hatchStyleCreate
            // 
            this.hatchStyleCreate.Location = new System.Drawing.Point(9, 59);
            this.hatchStyleCreate.Name = "hatchStyleCreate";
            this.hatchStyleCreate.Size = new System.Drawing.Size(157, 22);
            this.hatchStyleCreate.TabIndex = 6;
            this.hatchStyleCreate.Text = "Создать стиль штриховки";
            this.hatchStyleCreate.UseVisualStyleBackColor = true;
            this.hatchStyleCreate.Click += new System.EventHandler(this.PavementHatchStyleCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите стиль штриховки";
            // 
            // pavementHatchStyleBox
            // 
            this.pavementHatchStyleBox.FormattingEnabled = true;
            this.pavementHatchStyleBox.Location = new System.Drawing.Point(9, 32);
            this.pavementHatchStyleBox.Name = "pavementHatchStyleBox";
            this.pavementHatchStyleBox.Size = new System.Drawing.Size(158, 21);
            this.pavementHatchStyleBox.TabIndex = 5;
            // 
            // cPaveHatch
            // 
            this.cPaveHatch.Location = new System.Drawing.Point(183, 166);
            this.cPaveHatch.Name = "cPaveHatch";
            this.cPaveHatch.Size = new System.Drawing.Size(120, 23);
            this.cPaveHatch.TabIndex = 4;
            this.cPaveHatch.Text = "Создать штриховку";
            this.cPaveHatch.UseVisualStyleBackColor = true;
            this.cPaveHatch.Click += new System.EventHandler(this.cPaveHatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите тип покрытия";
            // 
            // pavementListBox
            // 
            this.pavementListBox.FormattingEnabled = true;
            this.pavementListBox.Location = new System.Drawing.Point(183, 33);
            this.pavementListBox.Name = "pavementListBox";
            this.pavementListBox.Size = new System.Drawing.Size(120, 121);
            this.pavementListBox.TabIndex = 2;
            // 
            // pavementTypeBox
            // 
            this.pavementTypeBox.FormattingEnabled = true;
            this.pavementTypeBox.Location = new System.Drawing.Point(11, 52);
            this.pavementTypeBox.Name = "pavementTypeBox";
            this.pavementTypeBox.Size = new System.Drawing.Size(158, 21);
            this.pavementTypeBox.TabIndex = 1;
            this.pavementTypeBox.SelectedIndexChanged += new System.EventHandler(this.pavementTypeBox_SelectedIndexChanged);
            // 
            // bCreatePaveType
            // 
            this.bCreatePaveType.Location = new System.Drawing.Point(6, 6);
            this.bCreatePaveType.Name = "bCreatePaveType";
            this.bCreatePaveType.Size = new System.Drawing.Size(166, 22);
            this.bCreatePaveType.TabIndex = 0;
            this.bCreatePaveType.Text = "Создать новый тип покрытия";
            this.bCreatePaveType.UseVisualStyleBackColor = true;
            this.bCreatePaveType.Click += new System.EventHandler(this.bCreatePaveType_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.greeneryHatchCreate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.greeneryListBox);
            this.tabPage2.Controls.Add(this.greeneryTypeBox);
            this.tabPage2.Controls.Add(this.greeneryLayerCreate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(309, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Озеленение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Детали озеленения:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.greeneryHatchStyleDelete);
            this.groupBox2.Controls.Add(this.greneryHatchStyleCreate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.greeneryHatchStyleBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 116);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Штриховка озеленения";
            // 
            // greeneryHatchStyleDelete
            // 
            this.greeneryHatchStyleDelete.Location = new System.Drawing.Point(9, 87);
            this.greeneryHatchStyleDelete.Name = "greeneryHatchStyleDelete";
            this.greeneryHatchStyleDelete.Size = new System.Drawing.Size(157, 22);
            this.greeneryHatchStyleDelete.TabIndex = 8;
            this.greeneryHatchStyleDelete.Text = "Удалить стиль штриховки";
            this.greeneryHatchStyleDelete.UseVisualStyleBackColor = true;
            this.greeneryHatchStyleDelete.Click += new System.EventHandler(this.greeneryHatchStyleDelete_Click);
            // 
            // greneryHatchStyleCreate
            // 
            this.greneryHatchStyleCreate.Location = new System.Drawing.Point(9, 59);
            this.greneryHatchStyleCreate.Name = "greneryHatchStyleCreate";
            this.greneryHatchStyleCreate.Size = new System.Drawing.Size(157, 22);
            this.greneryHatchStyleCreate.TabIndex = 6;
            this.greneryHatchStyleCreate.Text = "Создать стиль штриховки";
            this.greneryHatchStyleCreate.UseVisualStyleBackColor = true;
            this.greneryHatchStyleCreate.Click += new System.EventHandler(this.greneryHatchStyleCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Выберите стиль штриховки";
            // 
            // greeneryHatchStyleBox
            // 
            this.greeneryHatchStyleBox.FormattingEnabled = true;
            this.greeneryHatchStyleBox.Location = new System.Drawing.Point(9, 32);
            this.greeneryHatchStyleBox.Name = "greeneryHatchStyleBox";
            this.greeneryHatchStyleBox.Size = new System.Drawing.Size(158, 21);
            this.greeneryHatchStyleBox.TabIndex = 5;
            // 
            // greeneryHatchCreate
            // 
            this.greeneryHatchCreate.Location = new System.Drawing.Point(183, 166);
            this.greeneryHatchCreate.Name = "greeneryHatchCreate";
            this.greeneryHatchCreate.Size = new System.Drawing.Size(120, 23);
            this.greeneryHatchCreate.TabIndex = 14;
            this.greeneryHatchCreate.Text = "Создать штриховку";
            this.greeneryHatchCreate.UseVisualStyleBackColor = true;
            this.greeneryHatchCreate.Click += new System.EventHandler(this.greeneryHatchCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Выберите тип озеленения";
            // 
            // greeneryListBox
            // 
            this.greeneryListBox.FormattingEnabled = true;
            this.greeneryListBox.Location = new System.Drawing.Point(183, 33);
            this.greeneryListBox.Name = "greeneryListBox";
            this.greeneryListBox.Size = new System.Drawing.Size(120, 121);
            this.greeneryListBox.TabIndex = 12;
            // 
            // greeneryTypeBox
            // 
            this.greeneryTypeBox.FormattingEnabled = true;
            this.greeneryTypeBox.Location = new System.Drawing.Point(11, 52);
            this.greeneryTypeBox.Name = "greeneryTypeBox";
            this.greeneryTypeBox.Size = new System.Drawing.Size(158, 21);
            this.greeneryTypeBox.TabIndex = 11;
            this.greeneryTypeBox.SelectedIndexChanged += new System.EventHandler(this.greeneryTypeBox_SelectedIndexChanged);
            // 
            // greeneryLayerCreate
            // 
            this.greeneryLayerCreate.Location = new System.Drawing.Point(6, 7);
            this.greeneryLayerCreate.Name = "greeneryLayerCreate";
            this.greeneryLayerCreate.Size = new System.Drawing.Size(166, 22);
            this.greeneryLayerCreate.TabIndex = 10;
            this.greeneryLayerCreate.Text = "Создать новый слой озелен.";
            this.greeneryLayerCreate.UseVisualStyleBackColor = true;
            this.greeneryLayerCreate.Click += new System.EventHandler(this.greeneryLayerCreate_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.tableTypeBox);
            this.tabPage3.Controls.Add(this.tableCreateButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(309, 196);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Таблицы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableTypeBox
            // 
            this.tableTypeBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Борта",
            "Покрытия",
            "Штучное озеленение",
            "Площадное озеленение",
            "Газоны и мульча",
            "МАФ"});
            this.tableTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableTypeBox.FormattingEnabled = true;
            this.tableTypeBox.Items.AddRange(new object[] {
            "Борта",
            "Покрытия",
            "Штучное озеленение",
            "Площадное озеленение",
            "Газоны и мульча",
            "МАФ"});
            this.tableTypeBox.Location = new System.Drawing.Point(17, 36);
            this.tableTypeBox.Name = "tableTypeBox";
            this.tableTypeBox.Size = new System.Drawing.Size(130, 21);
            this.tableTypeBox.TabIndex = 12;
            // 
            // tableCreateButton
            // 
            this.tableCreateButton.Location = new System.Drawing.Point(17, 63);
            this.tableCreateButton.Name = "tableCreateButton";
            this.tableCreateButton.Size = new System.Drawing.Size(130, 22);
            this.tableCreateButton.TabIndex = 9;
            this.tableCreateButton.Text = "Создать таблицу";
            this.tableCreateButton.UseVisualStyleBackColor = true;
            this.tableCreateButton.Click += new System.EventHandler(this.tableCreateButton_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(106, 236);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(140, 23);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Выберите тип таблицы:";
            // 
            // createCurbLayerButton
            // 
            this.createCurbLayerButton.Location = new System.Drawing.Point(12, 13);
            this.createCurbLayerButton.Name = "createCurbLayerButton";
            this.createCurbLayerButton.Size = new System.Drawing.Size(166, 22);
            this.createCurbLayerButton.TabIndex = 1;
            this.createCurbLayerButton.Text = "Создать новый тип борта";
            this.createCurbLayerButton.UseVisualStyleBackColor = true;
            this.createCurbLayerButton.Click += new System.EventHandler(this.createCurbLayerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 263);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.tabsControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основное окно";
            this.TopMost = true;
            this.tabsControl.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bCreatePaveType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cPaveHatch;
        private System.Windows.Forms.Button bClose;
        public System.Windows.Forms.ListBox pavementListBox;
        public System.Windows.Forms.ComboBox pavementTypeBox;
        private System.Windows.Forms.Button hatchStyleCreate;
        public System.Windows.Forms.ComboBox pavementHatchStyleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hatchStyleDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button greeneryHatchStyleDelete;
        private System.Windows.Forms.Button greneryHatchStyleCreate;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox greeneryHatchStyleBox;
        private System.Windows.Forms.Button greeneryHatchCreate;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox greeneryListBox;
        public System.Windows.Forms.ComboBox greeneryTypeBox;
        private System.Windows.Forms.Button greeneryLayerCreate;
        private System.Windows.Forms.Button tableCreateButton;
        public System.Windows.Forms.ComboBox tableTypeBox;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button createCurbLayerButton;
    }
}