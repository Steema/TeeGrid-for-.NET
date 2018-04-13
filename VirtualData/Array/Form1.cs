using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeGrid.Bands;
using Steema.TeeGrid.Columns;
using Steema.TeeGrid.Data;
using Steema.TeeGrid.Data.Reflection;
using Steema.TeeGrid.Format;
using Steema.TeeGrid.Renders;
using Steema.TeeGrid.Rows;
using Steema.TeeGrid.Totals;
using Steema.TeeGrid.WinForm.Editors;
using VirtualData;

namespace TeeGrid_Array_Data
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			BRecord_Click(this, EventArgs.Empty);
			this.BackColor = Color.White;
			Steema.TeeGrid.Themes.GridThemes.BlueFlat.ApplyTo(teeGrid1.Grid);
			teeGrid1.Rows.RowLines.Visible = true;
			teeGrid1.Rows.Height.Automatic = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TeeGridEditor.Edit(teeGrid1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			GridBandsEditor.Edit(teeGrid1.Headers);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			GridBandsEditor.Edit(teeGrid1.Footer);
		}

		private List<Person> MyListData = new List<Person>();
		private TextBand SampleHeader;

		private void BRecord_Click(object sender, EventArgs e)
		{
			MyData.FillMyData(MyListData, 10);

			teeGrid1.Data = new VirtualListData<Person>(MyListData);

			teeGrid1.Columns["BirthDate"].DataFormat.DateTime = "dd-MM-yyyy";

			SetExpander("Name", teeGrid1.Rows);

			teeGrid1.Footer.Clear();

			ColumnTotals tmp = Totals(teeGrid1.Footer);

			TotalsHeader.CreateTotals(teeGrid1.Footer, tmp);

			AddSampleFooter();

			SampleHeader?.Dispose();

		  SampleHeader = NewTitle(teeGrid1.Headers, "Header Sample" + Environment.NewLine + "Text");

			SampleHeader.Index = 0;

			SetupCellEditors();

			teeGrid1.CellEditing += GridCellEditing;

		}

		private void GridCellEditing(object sender, Steema.TeeGrid.WinForm.CellEditingEventArgs e)
		{
			if(e.Column == teeGrid1.Columns["Children"])
			{
				SetupCombo(e.Editor as ComboBox, teeGrid1.Data.AsString(e.Column, e.Row));
			}
		}

		private void SetupCombo(ComboBox comboBox, string text)
		{
			comboBox.Items.Clear();

			for (int t = 0; t < 15; t++)
			{
				comboBox.Items.Add(t.ToString());
			}

			comboBox.SelectedIndex = comboBox.Items.IndexOf(text);
		}

		private void SetupCellEditors()
		{
			teeGrid1.Columns["BirthDate"].EditorClass = typeof(DateTimePicker);
			teeGrid1.Columns["Children"].EditorClass = typeof(ComboBox);
		}

		private void AddSampleFooter()
		{
			TextBand tmp = NewTitle(teeGrid1.Footer, "Footer Sample" + Environment.NewLine + "Text");

			tmp.Format.Brush.Show();
			tmp.Format.Brush.InitColor(ColorTranslator.FromHtml("#6BABD0"));
			tmp.Format.Brush.Gradient.Show();
			tmp.Format.Brush.Gradient.Direction = GradientDirection.Horizontal;
		}

		private TextBand NewTitle(IObservableCollection collection, string text)
		{
			TextBand result = new TextBand(collection);
			result.Text = text;

			result.Format.Font.Size = 12;
			result.Format.Font.Style = Steema.TeeGrid.Format.FontStyle.Bold;
			result.Format.Font.Color = ColorTranslator.FromHtml("#034684");
			result.Format.Stroke.Visible = true;
			result.Format.Stroke.Size = 3;
			result.Format.Stroke.Color = ColorTranslator.FromHtml("#6BABD0");
			return result;
		}

		private ColumnTotals Totals(IObservableCollection collection)
		{
			ColumnTotals result = new ColumnTotals(collection);

			result.Calculation.Add("Name", ColumnCalculation.Count);
			result.Calculation.Add("Children", ColumnCalculation.Sum);
			result.Calculation.Add("Height", ColumnCalculation.Average);

			result.Calculation.Add(result.Columns["Address"].Items["Number"], ColumnCalculation.Max);
			result.Calculation.Add(result.Columns["Car"].Items["kW"], ColumnCalculation.Min);

			result.Format.Font.Style = Steema.TeeGrid.Format.FontStyle.Bold | Steema.TeeGrid.Format.FontStyle.Italic;

			return result;
		}

		private void SetExpander(string column, Rows rows)
		{
			Column tmp = teeGrid1.Columns[column];

			tmp.Render = new ExpanderRender(tmp.Changed);

			((ExpanderRender)tmp.Render).GetExpanded += rows.IsChildrenVisible;
		}

		private static Random rnd = new Random();
		private void bInteger_Click(object sender, EventArgs e)
		{
			int[] myIntegers = new int[100];

			for (int t = 0; t < 100; t++)
			{
				myIntegers[t] = rnd.Next(1000);
			}

			teeGrid1.Data = new VirtualArrayData<int>(myIntegers);
			teeGrid1.Footer.Clear();
		}

		private void bFloat_Click(object sender, EventArgs e)
		{
			double[] myFloats = new double[100];

			for (int t = 0; t < 100; t++)
			{
				myFloats[t] = rnd.NextDouble();
			}

			teeGrid1.Data = new VirtualArrayData<double>(myFloats);
			teeGrid1.Footer.Clear();
		}

		private void bString_Click(object sender, EventArgs e)
		{
			string RandomString()
			{
				string[] samples = new string[] { "Red", "Blue", "Yellow", "Green" };
				return samples[rnd.Next(samples.Length - 1)];
			}

			string[] myStrings = new string[100];

			for (int t = 0; t < 100; t++)
			{
				myStrings[t] = RandomString();
			}

			teeGrid1.Data = new VirtualArrayData<string>(myStrings);
			teeGrid1.Footer.Clear();
		}

		private void bObject_Click(object sender, EventArgs e)
		{
			Car[] myCars = new Car[100];

			MyData.FillMyData(myCars, 100);

			teeGrid1.Data = new VirtualArrayData<Car>(myCars);
			teeGrid1.Footer.Clear();
		}
	}
}
