using System;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeGrid.Columns;
using Steema.TeeGrid.Ticker;
using Steema.TeeGrid.Data.Strings;
using Steema.TeeGrid.WinForm.Editors;

namespace TeeGrid_WinForm_Ticker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.BackColor = Color.White;
			Steema.TeeGrid.Themes.GridThemes.Flat.ApplyTo(tTeeGrid1.Grid);

			Data = new StringsData(5, 8);

			tTeeGrid1.Data = Data;

			FillNames();
			FillRandomValues();

			ColumnTextAlign();
			CustomFormat();

			RefreshSpeed();

			Ticker = new GridTicker(tTeeGrid1.Grid.Current);

			//GridTickerEditor tEditor = new GridTickerEditor();
			GridTickerEditor.Embed(splitContainer2.Panel2, Ticker);
			//TickerEditor

			timer1.Enabled = true;
		}

		private void CustomFormat()
		{
			Column col = tTeeGrid1.Columns[0];
			col.ParentFormat = false;
			col.Format.Font.Style = Steema.TeeGrid.Format.FontStyle.Bold;
			col.Format.Font.Color = Color.Navy;
		}

		private void ColumnTextAlign()
		{
			for (int col = 1; col < tTeeGrid1.Columns.Count; col++)
			{
				Column tmp = tTeeGrid1.Columns[col];

				tmp.ParentFormat = false;
				tmp.TextAlignment = Steema.TeeGrid.Columns.ColumnTextAlign.Custom;
				tmp.TextAlign.Horizontal = Steema.TeeGrid.Painter.HorizontalAlign.Right;
			}
		}

		private void FillRandomValues()
		{
			for (int col = 1; col < tTeeGrid1.Columns.Count; col++)
			{
				for (int row = 0; row < Data.Count(); row++)
				{
					Data[col, row] = rnd.Next(col * 2000).ToString();
				}
			}
		}

		private void FillNames()
		{
			Data.Headers[0] = Product;
			Data.Headers[1] = "Sales";
			Data.Headers[2] = "Stock";
			Data.Headers[3] = "Orders";
			Data.Headers[4] = "Returns";

			// First column cells
			Data[0, 0] = "Cars";
			Data[0, 1] = "Chairs";
			Data[0, 2] = "Keyboards";
			Data[0, 3] = "Lamps";
			Data[0, 4] = "Monitors";
			Data[0, 5] = "Tables";
			Data[0, 6] = "Umbrellas";
			Data[0, 7] = "Windows";
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			RandomCell(out int col, out int row);

			Column tmp = tTeeGrid1.Columns[col];

			int oldValue = int.Parse(Data.AsString(tmp, row));

			Data.SetValue(tmp, row, (oldValue + rnd.Next(100) - 50).ToString());

			Ticker.ChangeTicker(col, row, oldValue);
		}

		private GridTicker Ticker;
		private StringsData Data;
		private const string Product = "Product";
		private Random rnd = new Random();

		private void RandomCell(out int col, out int row)
		{
			do
			{
				col = rnd.Next(tTeeGrid1.Columns.Count);

			} while (tTeeGrid1.Columns[col].Header.Text == Product);

			row = rnd.Next(tTeeGrid1.Data.Count());
		}

		private void TBSpeed_Scroll(object sender, EventArgs e)
		{
			timer1.Interval = tBSpeed.Value;
			RefreshSpeed();
		}

		private void RefreshSpeed()
		{
			LSpeed.Text = timer1.Interval.ToString() + "msec";
		}
	}
}
