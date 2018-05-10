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
using System.IO;

namespace ClientDataSet
{
	public partial class Form1 : Form
	{

		private BindingSource ClientDataSet1 = new BindingSource();
		private BindingSource ClientDataSet2 = new BindingSource();
		private BindingSource ClientDataSet3 = new BindingSource();

		public Form1()
		{
			DataTable StronglyTyped(ClientDataSet2NET dataSet)
			{
				Bitmap StringToBitmap(string s)
				{
					byte[] bytes = Convert.FromBase64String(s);

					Bitmap bmp;

					using (MemoryStream stream = new MemoryStream(bytes))
					{
						stream.Position = 0;
						bmp = (Bitmap)Image.FromStream(stream);
					}

					return bmp;
				}

				DataTable table = dataSet.ROW;
				DataTable result = new DataTable(table.TableName);

				result.Columns.Add(table.Columns[0].ColumnName, typeof(string));
				result.Columns.Add(table.Columns[1].ColumnName, typeof(int));
				result.Columns.Add(table.Columns[2].ColumnName, typeof(int));
				result.Columns.Add(table.Columns[3].ColumnName, typeof(string));
				result.Columns.Add(table.Columns[4].ColumnName, typeof(Bitmap));

				foreach (DataRow row in table.Rows)
				{
					DataRow newRow = result.NewRow();

					for (int i = 0; i < table.Columns.Count; i++)
					{
						if (i == table.Columns.Count - 1)
							newRow[i] = StringToBitmap(row[i].ToString());
						else
							newRow[i] = row[i];
					}

					result.Rows.Add(newRow);
				}
				return result;
			}

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

			//dataSet2 is not strongly typed - convert it so Bitmap recognized
			ClientDataSet2.DataSource = StronglyTyped(dataSet2);

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
				case 2:  //fruit
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

			bindingNavigator1.Refresh();
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
			tTeeGrid1.Grid.Export.JSGrid.SavePath = @"C:\tmp";
			tTeeGrid1.Grid.Export.JSGrid.UsePublicResources = true;
			tTeeGrid1.Grid.Export.JSGrid.Save();
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
