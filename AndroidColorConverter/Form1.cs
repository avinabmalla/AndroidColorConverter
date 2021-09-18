using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorConverter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			var pk = new ColorDialog();
			pk.Color = btnColor.BackColor;
			if (pk.ShowDialog() == DialogResult.OK)
			{
				btnColor.BackColor = pk.Color;
			}
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			var color = btnColor.BackColor;
			byte A = (byte)numericUpDown1.Value;
			byte R = color.R;
			byte G = color.G;
			byte B = color.B;

			var intColor = (A & 0xff) << 24 | (R & 0xff) << 16 | (G & 0xff) << 8 | (B & 0xff);
			var hexColor = A.ToString("X2") + R.ToString("X2") + G.ToString("X2") + B.ToString("X2");
			txtAndroidInt.Text = intColor.ToString();
			txtHex.Text = hexColor;
		}

		private void btnConvertInt_Click(object sender, EventArgs e)
		{
			try
			{
				var argb = Convert.ToInt32(txtIntInput.Text);
				byte A = (byte)((argb >> 24) & 0xFF);
				byte R = (byte)((argb >> 16) & 0xFF);
				byte G = (byte)((argb >> 8) & 0xFF);
				byte B = (byte)((argb >> 0) & 0xFF);

				var hexColor = A.ToString("X2") + R.ToString("X2") + G.ToString("X2") + B.ToString("X2");
				var clr = Color.FromArgb(A, R, G, B);
				txtHexOut.Text = hexColor;
				pnlColor.BackColor = clr;

			}
			catch
			{

			}
		}
	}
}
