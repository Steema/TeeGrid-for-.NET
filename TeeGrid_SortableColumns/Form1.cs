using Steema.TeeGrid.Data.Reflection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualData;

namespace TeeGrid_SortableColumns
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			sourceOfData_CheckedChanged(this, EventArgs.Empty);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			tGrid1.SortableColumns = !tGrid1.SortableColumns;
		}

		private void ResetDataSources()
		{
			bindingSource1.DataSource = null;
			tGrid1.DataSource = null;
			tGrid1.Data = null;
		}

		private void sourceOfData_CheckedChanged(object sender, EventArgs e)
		{
			ResetDataSources();

			if (rbAsDataTable.Checked)
			{
				cbAsList.Checked = false;
				DataTable tableSource = null;
				if (rbCars.Checked)
					tableSource = MyData.FillMyData<Car>(10);
				else
					tableSource = MyData.FillMyData<Person>(10);
				bindingSource1.DataSource = tableSource;
				tGrid1.DataSource = bindingSource1;
			}
			else if(rbAsSortableBindingList.Checked)
			{
				cbAsList.Checked = false;
			}
		}

		private void typeOfData_CheckedChanged(object sender, EventArgs e)
		{
			sourceOfData_CheckedChanged(this, EventArgs.Empty);
		}

		private void cbAsList_CheckedChanged(object sender, EventArgs e)
		{
			ResetDataSources();

			if (cbAsList.Checked)
			{
				rbAsSortableBindingList.Checked = false;
				rbAsDataTable.Checked = false;
				if (rbCars.Checked)
				{
					List<Car> cars = new List<Car>();
					MyData.FillMyData(cars, 10);
					tGrid1.Data = new VirtualListData<Car>(cars);
				}
				else
				{
					List<Person> people = new List<Person>();
					MyData.FillMyData(people, 10);
					tGrid1.Data = new VirtualListData<Person>(people);
				}
			}
		}
	}
}
