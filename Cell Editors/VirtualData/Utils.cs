using System;
using System.Windows.Forms;
using Steema.TeeGrid.Columns;
using Steema.TeeGrid.WinForm;

namespace VirtualData
{
	public static class Utils
	{
		public static void ResetCustomEditors(Steema.TeeGrid.WinForm.TGrid grid)
		{
			void ResetColumns(Columns columns)
			{
				foreach (var col in columns)
				{
					col.EditorClass = null;
					ResetColumns(col.Items);
				}
			}

			ResetColumns(grid.Columns);
		}

		public static void FillCombo(ComboBox box, Type type, string tmpValue)
		{
			Array values = Enum.GetValues(type);

			foreach (var val in values)
			{
				box.Items.Add(val);
			}

			box.SelectedItem = Enum.Parse(type, tmpValue);
		}
	}
}
