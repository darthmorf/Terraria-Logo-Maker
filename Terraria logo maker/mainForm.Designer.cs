namespace Terraria_logo_maker
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.allowedCharLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputPathTxtBx = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to generate:";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(12, 25);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(260, 20);
            this.textTextBox.TabIndex = 2;
            this.textTextBox.TextChanged += new System.EventHandler(this.textTextBox_TextChanged);
            // 
            // allowedCharLabel
            // 
            this.allowedCharLabel.AutoSize = true;
            this.allowedCharLabel.Location = new System.Drawing.Point(12, 48);
            this.allowedCharLabel.Name = "allowedCharLabel";
            this.allowedCharLabel.Size = new System.Drawing.Size(0, 13);
            this.allowedCharLabel.TabIndex = 9;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(246, -1);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(38, 23);
            this.infoButton.TabIndex = 10;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output Path:";
            // 
            // outputPathTxtBx
            // 
            this.outputPathTxtBx.BackColor = System.Drawing.SystemColors.Window;
            this.outputPathTxtBx.Location = new System.Drawing.Point(12, 148);
            this.outputPathTxtBx.Name = "outputPathTxtBx";
            this.outputPathTxtBx.Size = new System.Drawing.Size(214, 20);
            this.outputPathTxtBx.TabIndex = 12;
            this.outputPathTxtBx.Text = ".\\Output";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(15, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Inlcude Tree";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(229, 146);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(43, 23);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // themeComboBox
            // 
            this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Location = new System.Drawing.Point(12, 77);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(121, 21);
            this.themeComboBox.Sorted = true;
            this.themeComboBox.TabIndex = 15;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Theme:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.outputPathTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.allowedCharLabel);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Terraria Logo Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label allowedCharLabel;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputPathTxtBx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.Label label3;
    }
}

