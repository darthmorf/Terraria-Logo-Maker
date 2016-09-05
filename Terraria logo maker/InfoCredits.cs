using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terraria_logo_maker
{
	public partial class InfoCredits : Form
	{
		public InfoCredits()
		{
			InitializeComponent();

			textBox.Text += "If the unsupported character image appears, it means that the theme you are using does not support that character, or the folder structure is incorrect.";

			textBox.Text += "\n\nCredits:";
			textBox.Text += "\nWritten by darthmorf AKA Sam Poirier";
			textBox.Text += "\nTemplate sprites by Devilbro and darthmorf";
			textBox.Text += "\nOverworld theme by darthmorf, MinieK and Eli10293";
			textBox.Text += "\nThanks to Devilbro's logo tutorial for teaching us how to make logos! - he was the first. (http://goo.gl/Iwj4Wd)";

			textBox.Text += "\n\nGot any feedback? Found a bug? Want more themes? Visit the official Terraia Forums Thread: \n http://forums.terraria.org/index.php?threads/program-darthmorfs-terraria-logo-maker.48889/";
		}	

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
