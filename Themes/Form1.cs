using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeGrid.Themes;
using Steema.TeeGrid.Data.Reflection;
using VirtualData;
using Steema.TeeGrid.Painter;
using Steema.TeeGrid.WinForm.Editors;

namespace TeeGrid_Themes_WinForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.BackColor = System.Drawing.Color.White;
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
				case 4:
					GridThemes.BlueFlat.ApplyTo(tTeeGrid1.Grid);
					break;
				case 5:
					GridThemes.SilverFlat.ApplyTo(tTeeGrid1.Grid);
					break;
				case 6:
					GridThemes.DarkFlat.ApplyTo(tTeeGrid1.Grid);
					break;
				case 7:
					GridThemes.Flat.ApplyTo(tTeeGrid1.Grid);
					break;
			}
		}

		private void bEdit_Click(object sender, EventArgs e)
		{
			TeeGridEditor editor = TeeGridEditor.Embed(this, tTeeGrid1.Editing);
			editor.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string tmpPath = System.IO.Path.GetTempPath();
			string path;

			if (rbNative.Checked)
			{
				path = tmpPath + "TeeGrid-native";

				if (!System.IO.Directory.Exists(path))
					System.IO.Directory.CreateDirectory(path);

				tTeeGrid1.Export.Html.Save(path + @"\index.html");
			}
			else
			{
				path = tmpPath + "TeeGrid-jsGrid";

				if (!System.IO.Directory.Exists(path))
					System.IO.Directory.CreateDirectory(path);

				tTeeGrid1.Grid.Export.JSGrid.SavePath = path;
				tTeeGrid1.Grid.Export.JSGrid.UsePublicResources = true;
				tTeeGrid1.Grid.Export.JSGrid.Save();
			}

			System.Diagnostics.Process.Start(path + @"\index.html");
		}

		private void button1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
