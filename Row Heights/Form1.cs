using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeGrid.Columns;
using Steema.TeeGrid.Data.Strings;
using Steema.TeeGrid.Painter;
using Steema.TeeGrid.WinForm.Editors;

namespace TeeGrid_WinForm_Row_Heights
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.BackColor = Color.White;
			Steema.TeeGrid.Themes.GridThemes.DarkFlat.ApplyTo(tTeeGrid1.Grid);


			StringsData tmp = new StringsData(2, 11);

			tTeeGrid1.Data = tmp;

			tTeeGrid1.Columns[0].Header.Text = "ABC" + Environment.NewLine + "Extra Content";
			tTeeGrid1.Columns[1].Header.Text = "DEF" + Environment.NewLine + "Subtext";

			tmp[0, 3] = "Sample";
			tmp[0, 5] = "Hello" + Environment.NewLine + "World";
			tmp[0, 10] = "This is a long line" + Environment.NewLine + "of text with multiple" + Environment.NewLine + "lines";

			tmp[1, 1] = "Several lines" + Environment.NewLine + "of text";
			tmp[1, 6] = "More sample" + Environment.NewLine + "text";
			tmp[1, 10] = "Another long line" + Environment.NewLine + "of text with multiple" + Environment.NewLine + "lines";


			tTeeGrid1.Columns[1].ParentFormat = false;
			tTeeGrid1.Columns[1].Format.Font.Size = 16;

			tTeeGrid1.Columns[1].TextAlignment = ColumnTextAlign.Custom;
			tTeeGrid1.Columns[1].TextAlign.Horizontal = HorizontalAlign.Right;

			CbMultiLine_CheckedChanged(cbMultiLine, EventArgs.Empty);

			//tTeeGrid1.Editing.Text.Selected = false;
		}

		private void CbMultiLine_CheckedChanged(object sender, EventArgs e)
		{
			tTeeGrid1.Rows.Height.Automatic = cbMultiLine.Checked;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
      TeeGridEditor editor = TeeGridEditor.Embed(this, tTeeGrid1.Editing);
      editor.Show();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Stopwatch watch = Stopwatch.StartNew();

			for (int t = 0; t < 1000; t++)
			{
				tTeeGrid1.Grid.Paint();
			}

			watch.Stop();
			this.Text = "1000 Paint Benchmark: " + watch.ElapsedMilliseconds.ToString() + " msec";
		}
  }
}
