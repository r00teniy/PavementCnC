namespace PavementCnC.Forms
{
    partial class CreateHatchStyleForm
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
            this.patternSelect = new System.Windows.Forms.Button();
            this.styleNameBox = new System.Windows.Forms.TextBox();
            this.tileSize = new System.Windows.Forms.Label();
            this.rotationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scaleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createStyle = new System.Windows.Forms.Button();
            this.hasBackground = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patternSelect
            // 
            this.patternSelect.Location = new System.Drawing.Point(16, 117);
            this.patternSelect.Name = "patternSelect";
            this.patternSelect.Size = new System.Drawing.Size(142, 23);
            this.patternSelect.TabIndex = 44;
            this.patternSelect.Text = "Выбрать образец";
            this.patternSelect.UseVisualStyleBackColor = true;
            this.patternSelect.Click += new System.EventHandler(this.patternSelect_Click);
            // 
            // styleNameBox
            // 
            this.styleNameBox.Location = new System.Drawing.Point(75, 12);
            this.styleNameBox.Name = "styleNameBox";
            this.styleNameBox.Size = new System.Drawing.Size(79, 20);
            this.styleNameBox.TabIndex = 46;
            // 
            // tileSize
            // 
            this.tileSize.AutoSize = true;
            this.tileSize.Location = new System.Drawing.Point(13, 15);
            this.tileSize.Name = "tileSize";
            this.tileSize.Size = new System.Drawing.Size(60, 13);
            this.tileSize.TabIndex = 45;
            this.tileSize.Text = "Название:";
            // 
            // rotationBox
            // 
            this.rotationBox.Location = new System.Drawing.Point(75, 66);
            this.rotationBox.Name = "rotationBox";
            this.rotationBox.Size = new System.Drawing.Size(79, 20);
            this.rotationBox.TabIndex = 48;
            this.rotationBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Поворот:";
            // 
            // scaleBox
            // 
            this.scaleBox.Location = new System.Drawing.Point(75, 40);
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Size = new System.Drawing.Size(79, 20);
            this.scaleBox.TabIndex = 50;
            this.scaleBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Масштаб:";
            // 
            // createStyle
            // 
            this.createStyle.Location = new System.Drawing.Point(16, 146);
            this.createStyle.Name = "createStyle";
            this.createStyle.Size = new System.Drawing.Size(142, 23);
            this.createStyle.TabIndex = 52;
            this.createStyle.Text = "Создать стиль";
            this.createStyle.UseVisualStyleBackColor = true;
            this.createStyle.Click += new System.EventHandler(this.createStyle_Click);
            // 
            // hasBackground
            // 
            this.hasBackground.AutoSize = true;
            this.hasBackground.Location = new System.Drawing.Point(16, 94);
            this.hasBackground.Name = "hasBackground";
            this.hasBackground.Size = new System.Drawing.Size(132, 17);
            this.hasBackground.TabIndex = 54;
            this.hasBackground.Text = "штриховка с фоном?";
            this.hasBackground.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(16, 175);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(142, 23);
            this.closeButton.TabIndex = 55;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CreateHatchStyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 203);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.hasBackground);
            this.Controls.Add(this.createStyle);
            this.Controls.Add(this.scaleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rotationBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.styleNameBox);
            this.Controls.Add(this.tileSize);
            this.Controls.Add(this.patternSelect);
            this.Name = "CreateHatchStyleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стиль штриховки";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button patternSelect;
        private System.Windows.Forms.TextBox styleNameBox;
        private System.Windows.Forms.Label tileSize;
        private System.Windows.Forms.TextBox rotationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scaleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createStyle;
        private System.Windows.Forms.CheckBox hasBackground;
        private System.Windows.Forms.Button closeButton;
    }
}