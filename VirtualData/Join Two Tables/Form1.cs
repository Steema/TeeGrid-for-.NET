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
using Steema.TeeGrid.Data.Reflection;
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

			List<OrderByCustomer> list = fddemoDataSet.Orders.Join(fddemoDataSet.Customers, x => x.CustomerID, y => y.CustomerID,
				(x, y) => new OrderByCustomer
				{
					Order = new Order { OrderNo = x.OrderID, SaleDate = x.OrderDate },
					Customer = new Customer { CustNo = y.CustomerID, City = y.City, Company = y.CompanyName }
				}).Take(50).ToList();


			teeGrid1.Data = new VirtualListData<OrderByCustomer>(list);

			teeGrid1.Columns.ToList().ForEach(x =>
			{
				x.Header.Format.Brush.Show();
				x.Header.Format.Brush.Color = Color.Gray;
				x.Header.TextAlignment = Steema.TeeGrid.Columns.ColumnTextAlign.Custom;
				x.Header.TextAlign.Horizontal = Steema.TeeGrid.Painter.HorizontalAlign.Center;
			});
		}

	}

	public struct Order
	{
		public int OrderNo { get; set; }
		public DateTime SaleDate { get; set; }
	}

	public struct Customer
	{
		public string CustNo { get; set; }
		public string City { get; set; }
		public string Company { get; set; }
	}

	public struct OrderByCustomer
	{
		public Order Order { get; set; }
		public Customer Customer { get; set; }
	}

}
