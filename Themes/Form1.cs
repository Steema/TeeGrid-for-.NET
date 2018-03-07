using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeeGrid.Themes;
using TeeGrid.Data.Reflection;
using VirtualData;
using TeeGrid.Painter;

namespace TeeGrid_Themes_WinForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			CreateSampleData();

			lbThemes.SelectedIndex = 0;

			tTeeGrid1.Columns["Children"].InitAlign(HorizontalAlign.Center);
			tTeeGrid1.Columns["BirthDate"].DataFormat.DateTime = "dd/MM/yyyy";
		}

		private void CreateSampleData()
		{
			List<Person> persons = new List<Person>();
			MyData.FillMyData(persons, 100);

			tTeeGrid1.Data = new VirtualListData<Person>(persons);
		}

		private void LbThemes_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (lbThemes.SelectedIndex)
			{
				case 0:
					GridThemes.Default.ApplyTo(tTeeGrid1.Grid);
					break;
				case 1:
					GridThemes.iOS.ApplyTo(tTeeGrid1.Grid);
					break;
				case 2:
					GridThemes.Android.ApplyTo(tTeeGrid1.Grid);
					break;
				case 3:
					GridThemes.Black.ApplyTo(tTeeGrid1.Grid);
					break;
			}
		}
	}
}
