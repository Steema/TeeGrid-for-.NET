using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Steema.TeeGrid.Data.Strings;

namespace TeeGrid_VirtuaMode
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.BackColor = Color.White;
			Steema.TeeGrid.Themes.GridThemes.DarkFlat.ApplyTo(teeGrid1.Grid);
	

			// Important:
			// Passing an optional default column width (60) means the grid will not need
			// to calculate it, which is much faster.

			// Create data, with 10 columns, lots of rows, (optionally: a default column width = 60)
			data = new VirtualModeData(10, 20000, 60);

			for (int i = 0; i < data.Columns; i++)
			{
				data.Headers[i] = i.ToString();
			}

			data.OnGetValue += GetCell;
			data.OnSetValue += SetCell;

			teeGrid1.Data = data;

		}

		private void SetCell(object sender, VirtualDataEventArgs e)
		{
			// Called when the cell has been manually edited, or when a Data cell is changed.
			// Store the new e.Value in your real data
		}

		private void GetCell(object sender, VirtualDataEventArgs e)
		{
			e.Value = data.IndexOf(e.Column) + " x " + e.Row; 
		}

		private VirtualModeData data;
	}
}
