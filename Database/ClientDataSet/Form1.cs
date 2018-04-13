using ClientDataSet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Steema.TeeGrid.Renders;
using Steema.TeeGrid.Columns;
using ClientDataSet.Resources;
using Steema.TeeGrid.jsGrid;
using Steema.TeeGrid.WinForm.Editors;

namespace ClientDataSet
{
	public partial class Form1 : Form
	{

		private BindingSource ClientDataSet1 = new BindingSource();
		private BindingSource ClientDataSet2 = new BindingSource();
		private BindingSource ClientDataSet3 = new BindingSource();

		public Form1()
		{
			InitializeComponent();

			ComboSource.SelectedIndex = -1;


			ClientDataSet1NET dataSet1 = new ClientDataSet1NET();
			XElement rowData = XElement.Parse(Properties.Resources.ClientDataSet1NET);
			dataSet1.ROW.ReadXml(rowData.CreateReader());
			ClientDataSet1.DataSource = dataSet1;
			ClientDataSet1.DataMember = dataSet1.ROW.TableName;

			ClientDataSet2NET dataSet2 = new ClientDataSet2NET();
			rowData = XElement.Parse(Properties.Resources.ClientDataSet2NET);
			dataSet2.ROW.ReadXml(rowData.CreateReader());
			ClientDataSet2.DataSource = dataSet2;
			ClientDataSet2.DataMember = dataSet2.ROW.TableName;

			this.BackColor = Color.White;
			Steema.TeeGrid.Themes.GridThemes.Flat.ApplyTo(tTeeGrid1.Grid);
			tTeeGrid1.Grid.CopyDataFormat = Steema.TeeGrid.ExportFormat.JSON;

			ComboSource.SelectedIndex = 1;
		}

		private void ComboSource_SelectedIndexChanged(object sender, EventArgs e)
		{
			tTeeGrid1.Rows.Height.Automatic = false;
			tTeeGrid1.Rows.Height.Value = 0;

			switch (ComboSource.SelectedIndex)
			{
				case 0:
					tTeeGrid1.DataSource = null;
					bindingNavigator1.BindingSource = null;
					break;
				case 1:
					tTeeGrid1.DataSource = ClientDataSet1;
					bindingNavigator1.BindingSource = ClientDataSet1;
					break;
				case 2:
					tTeeGrid1.DataSource = ClientDataSet2;
					tTeeGrid1.Rows.Height.Value = 100;
					bindingNavigator1.BindingSource = ClientDataSet2;
					break;
				case 3:
					CheckBigDataset();
					tTeeGrid1.DataSource = ClientDataSet3;
					bindingNavigator1.BindingSource = ClientDataSet3;

					// Use a render for password column:
					ChangeRender(tTeeGrid1.Columns["Password"]);

					// Alternative way:
					//tTeeGrid1.Columns["Password"].OnPaint += Form1_OnPaint;
					break;
			}

			tTeeGrid1.Focus();
		}

		private void Form1_OnPaint(object sender, ColumnPaintEventArgs e)
		{
			RenderData data = e.AData;
			data.Data = "######";
			e.AData = data;
			e.DefaultPaint = true;
		}

		private void ChangeRender(Column AColumn)
		{
			AColumn.Render = new PasswordRender(AColumn.Changed);
		}

		private void CheckBigDataset()
		{
			Random rnd = new Random();

			string RandomPassword()
			{
				string[] RandomPasswords = new string[] { "1234", "abracadabra", "qwerty", "dragon" };
				return RandomPasswords[rnd.Next(0, RandomPasswords.Length - 1)];
			}

			void AddSampleRecords()
			{
				ClientDataSet3.DataSource = typeof(SampleRecords);
				for (int i = 1; i <= 10000; i++)
				{
					ClientDataSet3.Add(new SampleRecords() { Name = "Abc", Height = 3.45, Address = "Some St.", Children = i, Password = RandomPassword() });
				}
			}

			if (ClientDataSet3.Count == 0)
			{
				AddSampleRecords();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			tTeeGrid1.Grid.Copy();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			TeeGridEditor.Edit(tTeeGrid1);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			tTeeGrid1.Grid.Active = checkBox1.Checked;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			tTeeGrid1.ExportToDisk(Steema.TeeGrid.ExportFormat.jsGrid, @"C:\tmp");
		}
	}

	public class SampleRecords
	{
		public string Name { get; set; }
		public double Height { get; set; }
		public string Address { get; set; }
		public int Children { get; set; }
		public string Password { get; set; }
	}
}
