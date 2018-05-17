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

		private int count = 100;

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			tGrid1.SortableColumns = !tGrid1.SortableColumns;
		}

		private void ResetDataSources()
		{
			if(!string.IsNullOrEmpty(bindingSource1.Sort)) bindingSource1.Sort = string.Empty;
			bindingSource1.DataSource = null;
			tGrid1.DataSource = null;
			tGrid1.Data = null;
		}

		private void sourceOfData_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAsDataTable.Checked)
			{
				ResetDataSources();
				cbAsList.Checked = false;
				DataTable tableSource = null;
				if (rbAddress.Checked)
					tableSource = MyData.FillMyData<Address>(count);
				else
					tableSource = MyData.FillMyData<Person>(count);
				bindingSource1.DataSource = tableSource;
				tGrid1.DataSource = bindingSource1;
			}
			else if(rbAsSortableBindingList.Checked)
			{
				ResetDataSources();
				cbAsList.Checked = false;
				if (rbAddress.Checked)
				{
					SortableBindingList<Address> sortableList = new SortableBindingList<Address>();
					MyData.FillMyData(sortableList, count);
					bindingSource1.DataSource = sortableList;
				}
				else
				{
					SortableBindingList<Person> sortableList = new SortableBindingList<Person>();
					MyData.FillMyData(sortableList, count);
					bindingSource1.DataSource = sortableList;
				}
				tGrid1.DataSource = bindingSource1;
			}
		}

		private void typeOfData_CheckedChanged(object sender, EventArgs e)
		{
			sourceOfData_CheckedChanged(this, EventArgs.Empty);
			cbAsList_CheckedChanged(this, EventArgs.Empty);
		}

		private void cbAsList_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAsList.Checked)
			{
				ResetDataSources();
				rbAsSortableBindingList.Checked = false;
				rbAsDataTable.Checked = false;
				if (rbAddress.Checked)
				{
					List<Address> addresses = new List<Address>();
					MyData.FillMyData(addresses, count);
					tGrid1.Data = new VirtualListData<Address>(addresses);
				}
				else
				{
					List<Person> people = new List<Person>();
					MyData.FillMyData(people, count);
					tGrid1.Data = new VirtualListData<Person>(people);
				}
			}
		}
	}
}
