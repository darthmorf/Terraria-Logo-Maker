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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
			this.textTextBox = new System.Windows.Forms.TextBox();
			this.allowedCharLabel = new System.Windows.Forms.Label();
			this.outputPathTxtBx = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.themeComboBox = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.infoBtnImgLst = new System.Windows.Forms.ImageList(this.components);
			this.saveButton = new System.Windows.Forms.PictureBox();
			this.infoButton = new System.Windows.Forms.PictureBox();
			this.saveBtnImgLst = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.infoButton)).BeginInit();
			this.SuspendLayout();
			// 
			// textTextBox
			// 
			this.textTextBox.Location = new System.Drawing.Point(9, 32);
			this.textTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.textTextBox.Name = "textTextBox";
			this.textTextBox.Size = new System.Drawing.Size(260, 20);
			this.textTextBox.TabIndex = 2;
			this.textTextBox.TextChanged += new System.EventHandler(this.textTextBox_TextChanged);
			// 
			// allowedCharLabel
			// 
			this.allowedCharLabel.AutoSize = true;
			this.allowedCharLabel.Location = new System.Drawing.Point(12, 48);
			this.allowedCharLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.allowedCharLabel.Name = "allowedCharLabel";
			this.allowedCharLabel.Size = new System.Drawing.Size(0, 13);
			this.allowedCharLabel.TabIndex = 9;
			// 
			// outputPathTxtBx
			// 
			this.outputPathTxtBx.BackColor = System.Drawing.SystemColors.Window;
			this.outputPathTxtBx.Location = new System.Drawing.Point(9, 152);
			this.outputPathTxtBx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.outputPathTxtBx.Name = "outputPathTxtBx";
			this.outputPathTxtBx.Size = new System.Drawing.Size(214, 20);
			this.outputPathTxtBx.TabIndex = 12;
			this.outputPathTxtBx.Text = ".\\Output";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(12, 106);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(15, 14);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// themeComboBox
			// 
			this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.themeComboBox.FormattingEnabled = true;
			this.themeComboBox.Location = new System.Drawing.Point(9, 78);
			this.themeComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.themeComboBox.Name = "themeComboBox";
			this.themeComboBox.Size = new System.Drawing.Size(120, 21);
			this.themeComboBox.Sorted = true;
			this.themeComboBox.TabIndex = 15;
			this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(125, 23);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.WaitOnLoad = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(5, 51);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(67, 21);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 18;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(12, 126);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(88, 26);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 19;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(29, 100);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 23);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox4.TabIndex = 20;
			this.pictureBox4.TabStop = false;
			// 
			// infoBtnImgLst
			// 
			this.infoBtnImgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("infoBtnImgLst.ImageStream")));
			this.infoBtnImgLst.TransparentColor = System.Drawing.Color.Transparent;
			this.infoBtnImgLst.Images.SetKeyName(0, "infoButton1.png");
			this.infoBtnImgLst.Images.SetKeyName(1, "infoButton2.png");
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.Transparent;
			this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.saveButton.Location = new System.Drawing.Point(225, 150);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(58, 26);
			this.saveButton.TabIndex = 22;
			this.saveButton.TabStop = false;
			this.saveButton.Click += new System.EventHandler(this.pictureBox5_Click_1);
			// 
			// infoButton
			// 
			this.infoButton.BackColor = System.Drawing.Color.Transparent;
			this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.infoButton.Location = new System.Drawing.Point(246, -2);
			this.infoButton.Name = "infoButton";
			this.infoButton.Size = new System.Drawing.Size(30, 39);
			this.infoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.infoButton.TabIndex = 21;
			this.infoButton.TabStop = false;
			this.infoButton.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// saveBtnImgLst
			// 
			this.saveBtnImgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("saveBtnImgLst.ImageStream")));
			this.saveBtnImgLst.TransparentColor = System.Drawing.Color.Transparent;
			this.saveBtnImgLst.Images.SetKeyName(0, "saveButton1.png");
			this.saveBtnImgLst.Images.SetKeyName(1, "saveButton2.png");
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(277, 185);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.textTextBox);
			this.Controls.Add(this.infoButton);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.themeComboBox);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.outputPathTxtBx);
			this.Controls.Add(this.allowedCharLabel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximizeBox = false;
			this.Name = "mainForm";
			this.Text = "Terraria Logo Maker";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.Load += new System.EventHandler(this.mainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.infoButton)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label allowedCharLabel;
        private System.Windows.Forms.TextBox outputPathTxtBx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox themeComboBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.ImageList infoBtnImgLst;
		private System.Windows.Forms.PictureBox saveButton;
		private System.Windows.Forms.PictureBox infoButton;
		private System.Windows.Forms.ImageList saveBtnImgLst;
	}
}

