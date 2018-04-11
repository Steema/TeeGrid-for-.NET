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

			this.BackColor = Color.White;
			TeeGrid.Themes.GridThemes.BlueFlat.ApplyTo(tTeeGrid1.Grid);

			//Customize Footers
			TextBand tmpFooter = tTeeGrid1.Footer.AddText("Footer 1");
			tmpFooter.Format.Font.Style = TeeGrid.Format.FontStyle.Bold;
			tmpFooter.Format.Font.Size = 14;
			tmpFooter.Format.Font.Color = ColorTranslator.FromHtml("#3C95D5");


			tTeeGrid1.Footer.AddText("Footer 2"+ Environment.NewLine + "SubFooter 2").Format.Font.Size = 14;
			tTeeGrid1.Footer[1].Format.Font.Color = ColorTranslator.FromHtml("#014677");

			tTeeGrid1.Footer.AddText("Footer 3").TextRender.TextAlign.Horizontal = HorizontalAlign.Center;
			tTeeGrid1.Footer[2].Format.Font.Size = 25;
		
			//Customize Headers
	
			TeeGrid.Format.Brush brush = tTeeGrid1.Headers.AddText("Header 1").Format.Brush;
			brush.Show();
			brush.Gradient.Show();
			tTeeGrid1.Headers[1].Format.Font.Size = 14;
			tTeeGrid1.Headers[1].Format.Font.Style = TeeGrid.Format.FontStyle.Bold;

		  tTeeGrid1.Headers.AddText("Header 2").TextRender.TextAlign.Horizontal = HorizontalAlign.Center;
			GridBand tmpBand = tTeeGrid1.Headers[2];
			tmpBand.Format.Font.Color = ColorTranslator.FromHtml("#3C95D5");
			tmpBand.Format.Font.Size = 20;
			tmpBand.Format.Font.Style = TeeGrid.Format.FontStyle.Bold;
	//		tmpBand.Horizontal = HorizontalAlign.Center;

			tTeeGrid1.Headers.AddText("Header 3").TextRender.TextAlign.Horizontal = HorizontalAlign.Right;
			tTeeGrid1.Headers[3].Format.Font.Color = ColorTranslator.FromHtml("#014677");
			tTeeGrid1.Headers[3].Format.Font.Size = 20;
			tTeeGrid1.Headers[3].Format.Stroke.Show();
			tTeeGrid1.Headers[3].Format.Stroke.Size = 2;
			tTeeGrid1.Headers[3].Format.Stroke.Color = ColorTranslator.FromHtml("#6BABD0");
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
