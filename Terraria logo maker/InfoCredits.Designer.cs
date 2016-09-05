namespace Terraria_logo_maker
{
	partial class InfoCredits
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoCredits));
			this.textBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox.Location = new System.Drawing.Point(7, 12);
			this.textBox.Name = "textBox";
			this.textBox.ReadOnly = true;
			this.textBox.Size = new System.Drawing.Size(274, 248);
			this.textBox.TabIndex = 0;
			this.textBox.Text = "";
			this.textBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// InfoCredits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.textBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "InfoCredits";
			this.Text = "Info and Credits";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox textBox;
	}
}