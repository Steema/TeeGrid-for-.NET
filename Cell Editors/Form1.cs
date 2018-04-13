using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Steema.TeeGrid.Data.Reflection;
using VirtualData;
using Steema.TeeGrid.WinForm;

namespace TeeGrid_Cell_Editors
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.BackColor = System.Drawing.Color.White;
			Steema.TeeGrid.Themes.GridThemes.Flat.ApplyTo(tTeeGrid1.Grid);
			CreateSampleData();

			SetupCustomEditors();
		}

		private void SetupCustomEditors()
		{
			tTeeGrid1.Columns["BirthDate"].EditorClass = typeof(DateTimePicker);
			tTeeGrid1.Columns["Motor"].EditorClass = typeof(ComboBox);
			tTeeGrid1.Columns["Manufacturer"].EditorClass = typeof(ComboBox);
			tTeeGrid1.Columns["Children"].EditorClass = typeof(NumericUpDown);
		}

		private void CreateSampleData()
		{
			List<Person> carpersons = new List<Person>();
			MyData.FillMyData(carpersons, 10);

			tTeeGrid1.Data = new VirtualListData<Person>(carpersons);
			tTeeGrid1.Columns["BirthDate"].DataFormat.DateTime = "MM-dd-yyyy";
			tTeeGrid1.Columns["Height"].DataFormat.Float = "0.##";

			tTeeGrid1.CellEdited += TTeeGrid1_CellEdited;
			tTeeGrid1.CellEditing += TTeeGrid1_CellEditing;

			tTeeGrid1.Editing.Text.Selected = false;

			SetupCustomEditors();
		}

		private void TTeeGrid1_CellEditing(object sender, CellEditingEventArgs e)
		{
			string tmpValue = tTeeGrid1.Data.AsString(e.Column, e.Row);

			if (e.Editor is ComboBox)
			{
				ComboBox box = (ComboBox)e.Editor;
				box.DropDownStyle = ComboBoxStyle.DropDownList;
				box.Items.Clear();

				if(e.Column == tTeeGrid1.Columns["Motor"])
				{
					Utils.FillCombo(box, typeof(EnergySource), tmpValue);
				}
				else if(e.Column == tTeeGrid1.Columns["Manufacturer"])
				{
					Utils.FillCombo(box, typeof(Manufacturer), tmpValue);
				}
			}
			else if(e.Editor is NumericUpDown)
			{
				NumericUpDown upDown = (NumericUpDown)e.Editor;
				upDown.Value = Int32.Parse(tmpValue);
			}
		}

		private void TTeeGrid1_CellEdited(object sender, CellEditedEventArgs e)
		{
			if (e.Editor is ComboBox)
			{
				ComboBox box = (ComboBox)e.Editor;
				e.NewData = box.SelectedItem.ToString();
				// Set to False, do not change grid cell data
				e.ChangeData = false;
			}
			else if (e.Editor is NumericUpDown)
			{
				NumericUpDown upDown = (NumericUpDown)e.Editor;
				e.NewData = upDown.Value.ToString();
			}
		}

		private void CbAlwaysVisible_CheckedChanged(object sender, EventArgs e)
		{
			tTeeGrid1.Editing.AlwaysVisible = cbAlwaysVisible.Checked;
		}

		private void CbAutoEdit_CheckedChanged(object sender, EventArgs e)
		{
			tTeeGrid1.Editing.AutoEdit = cbAutoEdit.Checked;
		}

		private void CbCustomEditors_CheckedChanged(object sender, EventArgs e)
		{
			if (cbCustomEditors.Checked)
				SetupCustomEditors();
			else
				VirtualData.Utils.ResetCustomEditors(tTeeGrid1);
		}


		private void CbEnterKey_SelectedIndexChanged(object sender, EventArgs e)
		{
			tTeeGrid1.Editing.EnterKey = (Steema.TeeGrid.EditingEnter)cbEnterKey.SelectedIndex;
		}

		private void CbSelectedText_CheckedChanged(object sender, EventArgs e)
		{
			tTeeGrid1.Editing.Text.Selected = cbSelectedText.Checked;
		}
	}
}
