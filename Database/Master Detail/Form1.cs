using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeGrid.Data;
using Steema.TeeGrid.Data.DB;
using Steema.TeeGrid.Renders;
using Steema.TeeGrid.Totals;
using static TeeGrid_WinForm_Master_Detail.fddemoDataSet;

namespace TeeGrid_WinForm_Master_Detail
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.BackColor = Color.White;
			Steema.TeeGrid.Themes.GridThemes.Flat.ApplyTo(teeGrid1.Grid);


			// TODO: This line of code loads data into the 'fddemoDataSet.Customers' table. You can move, or remove it, as needed.
			this.customersTableAdapter.Fill(this.fddemoDataSet.Customers);
			// TODO: This line of code loads data into the 'fddemoDataSet.Orders' table. You can move, or remove it, as needed.
			this.ordersTableAdapter.Fill(this.fddemoDataSet.Orders);

			//add only 50 rows
			bindingCustomers.DataSource = this.fddemoDataSet.Customers.Take(50);

			teeGrid1.DataSource = bindingCustomers;

			CbEnable_CheckedChanged(this, EventArgs.Empty);

			teeGrid1.Grid.Current.NewDetail += DetailNewGroup;
		}

		private void DetailNewGroup(object sender, Steema.TeeGrid.RowGroup.NewDetailEventArgs e)
		{
			ColumnTotals tmpTot = new ColumnTotals(e.NewGroup.Footer);

			tmpTot.Calculation.Add(e.NewGroup.Columns[0], ColumnCalculation.Count);
			tmpTot.Calculation.Add("EmployeeID", ColumnCalculation.Sum);

			TotalsHeader.CreateTotals(e.NewGroup.Footer, tmpTot);
		}

		private ExpanderRender Expander;

		private void CbEnable_CheckedChanged(object sender, EventArgs e)
		{
			if(cbEnable.Checked)
			{
				Expander = teeGrid1.Grid.Current.NewExpander();
				Expander.GetData += GetOrders;
				Expander.AlwaysExpand = true;
				teeGrid1.Columns[0].Render = Expander;				
			}
			else
			{
				teeGrid1.Rows.Children.Clear();
				teeGrid1.Columns[0].Render = null;
			}
		}

		private void GetOrders(object sender, ExpanderGetDataEventArgs e)
		{
			DataRow row = this.fddemoDataSet.Customers.Rows[e.Row];
			string id = row["CustomerID"].ToString();

			VirtualDBData data = new VirtualDBData();
			e.Data = data.From(fddemoDataSet.Orders.Where(x => x.CustomerID == id));
		}
	}
}
