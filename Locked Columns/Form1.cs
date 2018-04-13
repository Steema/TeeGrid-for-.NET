using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeGrid.Columns;
using Steema.TeeGrid.Data.Strings;

namespace TeeGrid_Locked_Columns
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.BackColor = Color.White;
			Steema.TeeGrid.Themes.GridThemes.Flat.ApplyTo(tTeeGrid1.Grid);
			tTeeGrid1.Rows.RowLines.Visible = true;

			Data = new StringsData(30, 100);

			FillCells();

			tTeeGrid1.Data = Data;

			lbColumns.SelectedIndex = -1;

			FillBox();

			SetLocked(tTeeGrid1.Columns["A"], ColumnLocked.Left);
			SetLocked(tTeeGrid1.Columns["B"], ColumnLocked.Right);

			lbColumns.SelectedIndex = 0;

		}

		private void FillBox()
		{
			lbColumns.Items.Clear();

			for (int t = 0; t < Data.Columns; t++)
			{
				lbColumns.Items.Add(Data.ColumnList[t]);
			}
		}

		private void SetLocked(Column AColumn, ColumnLocked ALocked)
		{
			AColumn.Locked = ALocked;

			if(AColumn.Locked == ColumnLocked.None)
			{
				AColumn.ParentFormat = true;
			}
			else
			{
				AColumn.ParentFormat = false;
				AColumn.Format.Brush.Show();

				if(AColumn.Locked == ColumnLocked.Left)
				{
					AColumn.Format.Brush.Color = Color.NavajoWhite;
				}
				else
				{
					AColumn.Format.Brush.Color = Color.Salmon;
				}
			}
		}

		private void FillCells()
		{
			for (int t = 0; t < Data.Columns; t++)
			{
				Data.Headers[t] = Convert.ToChar(65 + t).ToString();
			}

			for (int t = 0; t < Data.Columns; t++)
			{
				for (int row = 0; row < Data.Rows; row++)
				{
					Data[t, row] = t.ToString() + " x " + row.ToString();
				}
			}
		}

		private StringsData Data;

		private void lbColumns_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = lbColumns.SelectedIndex;

			if(index > -1)
			{
				groupBox1.Enabled = true;

				ColumnLocked locked = tTeeGrid1.Columns[index].Locked;

				switch (locked)
				{
					case ColumnLocked.None:
						rbNone.Checked = true;
						break;
					case ColumnLocked.Left:
						rbLeft.Checked = true;
						break;
					case ColumnLocked.Right:
						rbRight.Checked = true;
						break;
					default:
						break;
				}
			}
		}

		private void rb_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rb = sender as RadioButton;

			Column column = tTeeGrid1.Columns[lbColumns.SelectedIndex];
			ColumnLocked locked = ColumnLocked.None;

			if(rb.Name.Contains("Left"))
			{
				locked = ColumnLocked.Left;
			}
			else if(rb.Name.Contains("Right"))
			{
				locked = ColumnLocked.Right;
			}

			SetLocked(column, locked);
		}
	}
}
