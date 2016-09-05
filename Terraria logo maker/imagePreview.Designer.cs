namespace Terraria_logo_maker
{
    partial class imagePreview
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imagePreview));
			this.outputPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// outputPictureBox
			// 
			this.outputPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.outputPictureBox.Location = new System.Drawing.Point(0, 0);
			this.outputPictureBox.Name = "outputPictureBox";
			this.outputPictureBox.Size = new System.Drawing.Size(282, 262);
			this.outputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.outputPictureBox.TabIndex = 0;
			this.outputPictureBox.TabStop = false;
			// 
			// imagePreview
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.ControlBox = false;
			this.Controls.Add(this.outputPictureBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "imagePreview";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Your Logo";
			((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox outputPictureBox;
    }
}