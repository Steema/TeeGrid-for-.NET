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
			bindingSource1.DataSource = null;
			tGrid1.DataSource = null;
			tGrid1.Data = null;
		}

		private void sourceOfData_CheckedChanged(object sender, EventArgs e)
		{
			if (rbBindingSource.Checked)
			{
				ResetDataSources();
				if (rbAddress.Checked)
				{
					List<Address> addresses = new List<Address>();
					MyData.FillMyData(addresses, count);
					bindingSource1.DataSource = typeof(Address);
					addresses.ForEach(x => bindingSource1.Add(x));
				}
				else
				{
					List<Person> people = new List<Person>();
					MyData.FillMyData(people, count);
					bindingSource1.DataSource = typeof(Person);
					people.ForEach(x => bindingSource1.Add(x));
				}
				tGrid1.DataSource = bindingSource1;
			}
			else
			{
				ResetDataSources();
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

		private void typeOfData_CheckedChanged(object sender, EventArgs e)
		{
			sourceOfData_CheckedChanged(this, EventArgs.Empty);
		}
	}
}
