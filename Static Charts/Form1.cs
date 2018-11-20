using Steema.TeeChart;
using Steema.TeeChart.Export;
using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeGrid.Format;
using Steema.TeeGrid.Columns;
using Steema.TeeGrid.Data.Reflection;
using Steema.TeeGrid.WinForm.Editors;
using Steema.TeeGrid.Header;

namespace TeeGrid_Static_Charts
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.BackColor = Color.White;
			Steema.TeeGrid.Themes.GridThemes.SilverFlat.ApplyTo(tTeeGrid1.Grid);
			tTeeGrid1.Rows.RowLines.Visible = true;

			AddRandomData();

			tTeeGrid1.Data = new VirtualListData<TLocation>(Locations);

      SortableHeader header = tTeeGrid1.Header.SortRender as SortableHeader;
      header.SortBy += Header_SortBy;

      tTeeGrid1.Rows.Height.Automatic = false;
			tTeeGrid1.Rows.Height.Value = 200;
			tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
			tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			tChart1.Series.Add(typeof(Bar));
			tChart1[0].ColorEach = true;

			PrepareChartColumn();
		}

		private void Header_SortBy(object sender, SortableColumnEventArgs e)
		{
			Locations = e.SortedData as List<TLocation>;
		}

		private void PrepareChartColumn()
		{
			Column temp = tTeeGrid1.Columns["Temperatures"];

			temp.OnPaint += Temp_OnPaint;

			temp.Width.Automatic = false;
			temp.Width.Value = 300;
			temp.ReadOnly = true;
		}

		private void Temp_OnPaint(object sender, ColumnPaintEventArgs e)
		{
			e.DefaultPaint = false;

			using (Bitmap bitmap = CreateChart(e.AData.Row, Steema.TeeGrid.Utils.Round(e.AData.Bounds.Width), Steema.TeeGrid.Utils.Round(e.AData.Bounds.Height)))
			{
				using (Picture picture = Picture.NewPicture())
				{
					picture.SetGraphic(bitmap);
					tTeeGrid1.Painter.Draw(picture, e.AData.Bounds);
				}
			}
		}

		private TChart tChart1 = new TChart();

		private Bitmap CreateChart(int row, int width, int height)
		{
			void FillSeries(Series series, List<int> temperatures)
			{
				series.Clear();
				series.Add(temperatures.ToArray());
			}

			FillSeries(tChart1[0], Locations[row].Temperatures);

			tChart1.Header.Text = Locations[row].Name;

			//MemoryStream ms = new MemoryStream();
			//BitmapFormat export = tChart1.Export.Image.Bitmap;
			//export.Width = width;
			//export.Height = height;
			//export.Save(ms);

			//ms.Position = 0;
			//return (Bitmap)Image.FromStream(ms);

			tChart1.Width = width;
			tChart1.Height = height;
			return tChart1.Bitmap;
		}

		private List<TLocation> Locations;
		private void AddRandomData()
		{
			Locations = new List<TLocation>();

			Locations.Add(new TLocation() { Name = "New York" });
			Locations.Add(new TLocation() { Name = "Barcelona" });
			Locations.Add(new TLocation() { Name = "Tokyo" });
			Locations.Add(new TLocation() { Name = "Sao Paulo" });

			foreach (var item in Locations)
			{
				item.SetRandom();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tChart1.ShowEditor())
			{
				tTeeGrid1.Grid.Paint();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			TeeGridEditor.Edit(tTeeGrid1);
		}
	}

	public class Temperatures : List<int>, IComparable<List<int>>
	{
		public int CompareTo(List<int> other)
		{
			if (other == null) return 1;
			return this.Average().CompareTo(other.Average()); //compare the average
		}
	}


	public class TLocation 
	{
		private static Random rnd = new Random();
		public string Name { get; set; }
		public Temperatures Temperatures { get; set; }

		public void SetRandom()
		{
			Temperatures = new Temperatures();
			
			for (int t = 0; t < 5; t++)
			{
				Temperatures.Add(10 + rnd.Next(20));
			}
		}
	}
}
