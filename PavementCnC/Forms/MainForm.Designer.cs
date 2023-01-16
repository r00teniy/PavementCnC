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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cPaveHatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pavementListBox = new System.Windows.Forms.ListBox();
            this.pavementTypeBox = new System.Windows.Forms.ComboBox();
            this.bCreatePaveType = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bClose = new System.Windows.Forms.Button();
            this.hatchStyleBox = new System.Windows.Forms.ComboBox();
            this.hatchStyleCreate = new System.Windows.Forms.Button();
            this.tabsControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabPage1);
            this.tabsControl.Controls.Add(this.tabPage2);
            this.tabsControl.Controls.Add(this.tabPage3);
            this.tabsControl.Location = new System.Drawing.Point(13, 13);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(309, 192);
            this.tabsControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hatchStyleCreate);
            this.tabPage1.Controls.Add(this.hatchStyleBox);
            this.tabPage1.Controls.Add(this.cPaveHatch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pavementListBox);
            this.tabPage1.Controls.Add(this.pavementTypeBox);
            this.tabPage1.Controls.Add(this.bCreatePaveType);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(301, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Покрытия";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cPaveHatch
            // 
            this.cPaveHatch.Location = new System.Drawing.Point(11, 137);
            this.cPaveHatch.Name = "cPaveHatch";
            this.cPaveHatch.Size = new System.Drawing.Size(140, 23);
            this.cPaveHatch.TabIndex = 4;
            this.cPaveHatch.Text = "Создать штриховку";
            this.cPaveHatch.UseVisualStyleBackColor = true;
            this.cPaveHatch.Click += new System.EventHandler(this.cPaveHatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите тип покрытия";
            // 
            // pavementListBox
            // 
            this.pavementListBox.FormattingEnabled = true;
            this.pavementListBox.Location = new System.Drawing.Point(175, 6);
            this.pavementListBox.Name = "pavementListBox";
            this.pavementListBox.Size = new System.Drawing.Size(120, 134);
            this.pavementListBox.TabIndex = 2;
            // 
            // pavementTypeBox
            // 
            this.pavementTypeBox.FormattingEnabled = true;
            this.pavementTypeBox.Location = new System.Drawing.Point(11, 25);
            this.pavementTypeBox.Name = "pavementTypeBox";
            this.pavementTypeBox.Size = new System.Drawing.Size(158, 21);
            this.pavementTypeBox.TabIndex = 1;
            this.pavementTypeBox.SelectedIndexChanged += new System.EventHandler(this.pavementTypeBox_SelectedIndexChanged);
            // 
            // bCreatePaveType
            // 
            this.bCreatePaveType.Location = new System.Drawing.Point(3, 52);
            this.bCreatePaveType.Name = "bCreatePaveType";
            this.bCreatePaveType.Size = new System.Drawing.Size(166, 22);
            this.bCreatePaveType.TabIndex = 0;
            this.bCreatePaveType.Text = "Создать новый тип покрытия";
            this.bCreatePaveType.UseVisualStyleBackColor = true;
            this.bCreatePaveType.Click += new System.EventHandler(this.bCreatePaveType_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(287, 148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Озеленение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(287, 148);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Таблицы?";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(103, 211);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(140, 23);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // hatchStyleBox
            // 
            this.hatchStyleBox.FormattingEnabled = true;
            this.hatchStyleBox.Location = new System.Drawing.Point(11, 80);
            this.hatchStyleBox.Name = "hatchStyleBox";
            this.hatchStyleBox.Size = new System.Drawing.Size(158, 21);
            this.hatchStyleBox.TabIndex = 5;
            // 
            // hatchStyleCreate
            // 
            this.hatchStyleCreate.Location = new System.Drawing.Point(6, 109);
            this.hatchStyleCreate.Name = "hatchStyleCreate";
            this.hatchStyleCreate.Size = new System.Drawing.Size(166, 22);
            this.hatchStyleCreate.TabIndex = 6;
            this.hatchStyleCreate.Text = "Создать новый стиль штрих.";
            this.hatchStyleCreate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 237);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.tabsControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основное окно";
            this.TopMost = true;
            this.tabsControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        public System.Windows.Forms.ComboBox hatchStyleBox;
    }
}