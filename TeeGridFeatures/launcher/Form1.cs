using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcher
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string folder = Application.StartupPath +  @"\..\..\..\..\";

		private void button1_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\Cell Editors\bin\Debug\TeeGrid_Cell_Editors.exe");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\Sorting\Custom Sorting\bin\Debug\TeeGrid_Custom_Sorting.exe");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\Database\ClientDataSet\bin\Debug\ClientDataSet.exe");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\Database\Master Detail\bin\Debug\TeeGrid_WinForm_Master_Detail.exe");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\Header Footer\bin\Debug\TeeGrid_Header_Footer.exe");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\Locked Columns\bin\Debug\TeeGrid_Locked_Columns.exe");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\Row Heights\bin\Debug\TeeGrid_WinForm_Row_Heights.exe");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\Static Charts\bin\Debug\TeeGrid_Static_Charts.exe");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\Ticker\bin\Debug\TeeGrid_WinForm_Ticker.exe");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\VirtualData\Array\bin\Debug\TeeGrid_Array_Data.exe");
		}

		private void button11_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\VirtualData\Virtual Mode\bin\Debug\TeeGrid_VirtuaMode.exe");
		}

		private void label2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(folder + @"\Themes\bin\Debug\TeeGrid_Themes_WinForm.exe");
		}
	}
}
