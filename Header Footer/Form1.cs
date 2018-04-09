using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeeGrid.Format;
using TeeGrid.Bands;
using TeeGrid.Data.Reflection;
using TeeGrid.Painter;
using TeeGrid.WinForm.Editors;

namespace TeeGrid_Header_Footer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			TextBand tmpFooter = tTeeGrid1.Footer.AddText("Footer 1");
			tmpFooter.Format.Font.Color = Color.Red;

			tTeeGrid1.Footer.AddText("Footer 2"+ Environment.NewLine + "SubFooter 2");

			tTeeGrid1.Footer.AddText("Footer 3").TextRender.TextAlign.Horizontal = HorizontalAlign.Center;

			TeeGrid.Format.Brush brush = tTeeGrid1.Headers.AddText("Header 1").Format.Brush;
			brush.Show();
			brush.Gradient.Show();

			GridBand tmpBand = tTeeGrid1.Headers.AddText("Header 2");

			tTeeGrid1.Headers.AddText("Header 3").Format.Stroke.Show();

			List <THouse> houses = new List<THouse>();
			Random rnd = new Random();

			for (int t = 0; t < 100; t++)
			{
				houses.Add(new THouse() { Address = t.ToString() + rnd.Next(1, 100).ToString() + " St", Floors = rnd.Next(1, 10) });
			}

			tTeeGrid1.Data = new VirtualListData<THouse>(houses);

			tmpBand.Index = 0;

			tmpFooter.TextRender.TextAlign.Horizontal = HorizontalAlign.Center;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			GridBandsEditor.Edit(tTeeGrid1.Headers);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			GridBandsEditor.Edit(tTeeGrid1.Footer);
		}
	}


	public struct THouse
	{
		public string Address { get; set; }
		public int Floors { get; set; }
	}
}
