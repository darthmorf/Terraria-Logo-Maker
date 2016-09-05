using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Terraria_logo_maker
{
    public partial class mainForm : Form
    {
        imagePreview imgPreview;
		InfoCredits IC;
        string theme = "";

        public mainForm()
        {
            InitializeComponent();
			infoButton.MouseEnter += new System.EventHandler(infoButton_MouseEnter);
			infoButton.MouseLeave += new System.EventHandler(infoButton_MouseLeave);
			infoButton.Image = infoBtnImgLst.Images[0];

			saveButton.MouseEnter += new System.EventHandler(saveButton_MouseEnter);
			saveButton.MouseLeave += new System.EventHandler(saveButton_MouseLeave);
			saveButton.Image = saveBtnImgLst.Images[0];

			//creates the logo preview form
			imgPreview = new imagePreview();

            //Looks for themes and adds all found to combobox
            DirectoryInfo directory = new DirectoryInfo(".\\Textures");
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (DirectoryInfo folder in directories)
            {
                themeComboBox.Items.Add(folder);
            }


            try
            {
                themeComboBox.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Error - no themes found.");
            }
            

            textTextBox.Text = "Terraria";
            
            
        }

        private void generateLogo()
        {
			int charSize = 13;
            //Creates the error image
            theme = themeComboBox.Text;
            string text = textTextBox.Text;
            //first, create a dummy bitmap just to get a graphics object
            Image errorImg = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(errorImg);
            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString("unsupported", new Font("Andy", charSize));
            //free up the dummy image and old graphics object
            errorImg.Dispose();
            drawing.Dispose();
            //create a new image of the right size
            errorImg = new Bitmap((int)textSize.Width, 2*(int)textSize.Height);
            drawing = Graphics.FromImage(errorImg);
            //paint the background
            drawing.Clear(Color.Transparent);
            //create a brush for the text
            Brush textBrush = new SolidBrush(Color.Red);
            drawing.DrawString("Error,", new Font("Andy", charSize), textBrush, 0, 0);
            drawing.DrawString("unsupported", new Font("Andy", charSize), textBrush, 0, 12);
			drawing.DrawString("character", new Font("Andy", charSize), textBrush, 0, 24);
			drawing.Save();
            textBrush.Dispose();
            drawing.Dispose();

            Bitmap errorImage = (Bitmap)errorImg;


			//Adds all needed images to list of images
			List<Bitmap> images = new List<Bitmap>();

            if (checkBox1.Checked == true)
            {//If tree is selected, adds a tree
                try
                {
                    Bitmap tree = new Bitmap(Image.FromFile(".\\Textures\\" + theme + "\\" + "tree.png"));
                    images.Add(tree);
                }
                catch
                {
                    images.Add(errorImage);
                }
            }

			//Adds the starter and ender images, along with all the characters
			try
            {
                Bitmap starter = new Bitmap(Image.FromFile(".\\Textures\\" + theme + "\\" + "starter.png"));
                images.Add(starter);
            }
            catch
            {
                images.Add(errorImage);
            }

            Image outputImage;
            try
            {
                outputImage = Image.FromFile(".\\Textures\\" + theme + "\\" + "starter.png");
            }
            catch
            {
                outputImage = errorImage;
            }

            foreach (char c in text)
            {
                try
                {
                    Bitmap bitmap = new Bitmap(Image.FromFile(".\\Textures\\" + theme + "\\" + (int)c + ".png"));
					images.Add(bitmap);
                }
                catch
                {
                    images.Add(errorImage);
                }
                
            }

            try
            {
                
                Bitmap ender = new Bitmap(Image.FromFile(".\\Textures\\" + theme + "\\" + "ender.png"));
				images.Add(ender);
            }
            catch
            {
                images.Add(errorImage);
            }

            //Builds the image from the list
            outputImage = MergeImages(images);

            //updates the logo preview window
            imgPreview.outputPictureBox.Image = outputImage;
            imgPreview.Show();


        }

        

        private Bitmap MergeImages(IEnumerable<Bitmap> images)
        {//Constructs the image from list, and returns it.
            var enumerable = images as IList<Bitmap> ?? images.ToList();

            var width = 0;
            var height = 0;

            foreach (var image in enumerable)
            {
                width += image.Width;
                height = image.Height > height
                    ? image.Height
                    : height;
            }

            var bitmap = new Bitmap(width, height);
            using (var g = Graphics.FromImage(bitmap))
            {
                var localWidth = 0;
                foreach (var image in enumerable)
                {
                    g.DrawImage(image, localWidth, 0);
                    localWidth += image.Width;
                }
            }
            return bitmap;
        }

        private void textTextBox_TextChanged(object sender, EventArgs e)
        {
            generateLogo();
        }

       
        private void infoButton_Click(object sender, EventArgs e)
        {
		}

        private void saveBtn_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            generateLogo();
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateLogo();
        }

		private void mainForm_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			//Credits/info form

			IC = new InfoCredits();
			IC.ShowDialog();
		}

		private void infoButton_MouseEnter(object sender, EventArgs e)
		{
			infoButton.Image = infoBtnImgLst.Images[1];
		}

		private void infoButton_MouseLeave(object sender, EventArgs e)
		{

			infoButton.Image = infoBtnImgLst.Images[0];
		}

		private void pictureBox5_Click_1(object sender, EventArgs e)
		{
			//Saves the image
			string dateTime = DateTime.Now.ToString("MM\\_dd\\_yyyy h\\_mm\\_ss");
			imgPreview.outputPictureBox.Image.Save(outputPathTxtBx.Text + "\\" + theme + " Logo " + dateTime + ".png");
		}

		private void saveButton_MouseEnter(object sender, EventArgs e)
		{
			saveButton.Image = saveBtnImgLst.Images[1];
		}

		private void saveButton_MouseLeave(object sender, EventArgs e)
		{

			saveButton.Image = saveBtnImgLst.Images[0];
		}
	}
}
