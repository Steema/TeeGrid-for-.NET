using Grid_Paging.TechProductsLtdDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Grid_Paging
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      DataTable JoinCustomers(DataTable dtOrders, DataTable dtCustomers)
      {
        DataTable result = dtOrders.Clone();

        result.Columns[1].DataType = typeof(string);
        result.Columns[1].ColumnName = "Contact";

        var list = dtOrders.AsEnumerable().DefaultIfEmpty().Join(dtCustomers.AsEnumerable().DefaultIfEmpty(), orders => orders.Field<int>("Cod_Customer"), customers => customers.Field<int>("Cod_Customer"),
         (orders, customers) =>
           new object[]
           {
             orders.Field<int>("ID"),
             customers.Field<string>("Contact"),
             orders.Field<DateTime>("Orderdate"),
             orders.Field<int>("Invoice_year"),
             orders.Field<int>("Invoice_num"),
             orders.Field<int>("Product_code"),
             orders.Field<int>("Pack_code")
           });

        foreach (var item in list)
        {
          result.LoadDataRow(item, true);
        }

        return result;
      }

      DataTable JoinProducts(DataTable dtOrders, DataTable dtProducts)
      {
        DataTable result = dtOrders.Clone();

        result.Columns[5].DataType = typeof(string);
        result.Columns[5].ColumnName = "Product";

        var list = dtOrders.AsEnumerable().DefaultIfEmpty().Join(dtProducts.AsEnumerable().DefaultIfEmpty(), orders => orders.Field<int>("Product_code"), products => products.Field<int>("Product_code"),
         (orders, products) =>
           new object[]
           {
             orders.Field<int>("ID"),
             orders.Field<string>("Contact"),
             orders.Field<DateTime>("Orderdate"),
             orders.Field<int>("Invoice_year"),
             orders.Field<int>("Invoice_num"),
             products.Field<string>("Product_desc"),
             orders.Field<int>("Pack_code")
           });

        foreach (var item in list)
        {
          result.LoadDataRow(item, true);
        }

        return result;
      }

      DataTable JoinPack(DataTable dtOrders, DataTable dtPacks)
      {
        DataTable result = dtOrders.Clone();

        result.Columns[6].DataType = typeof(int);
        result.Columns[6].ColumnName = "Quantity";

        var list = dtOrders.AsEnumerable().DefaultIfEmpty().Join(dtPacks.AsEnumerable().DefaultIfEmpty(), orders => orders.Field<int>("Pack_code"), pack => pack.Field<int>("Pack_code"),
         (orders, pack) =>
           new object[]
           {
             orders.Field<int>("ID"),
             orders.Field<string>("Contact"),
             orders.Field<DateTime>("Orderdate"),
             orders.Field<int>("Invoice_year"),
             orders.Field<int>("Invoice_num"),
             orders.Field<string>("Product"),
             pack.Field<int>("Pack_Qty")
           });

        foreach (var item in list)
        {
          result.LoadDataRow(item, true);
        }

        return result;
      }

      InitializeComponent();

      tGrid1.DataSource = null;

      this.fact_Orders_QueryTableAdapter.Fill(this.techProductsLtdDataSet.Fact_Orders_Query);

      Lookup_CustomersTableAdapter lookup_CustomersTableAdapter = new Lookup_CustomersTableAdapter();
      lookup_CustomersTableAdapter.Fill(this.techProductsLtdDataSet.Lookup_Customers);

      Lookup_ProductsTableAdapter lookup_ProductsTableAdapter = new Lookup_ProductsTableAdapter();
      lookup_ProductsTableAdapter.Fill(this.techProductsLtdDataSet.Lookup_Products);

      Lookup_ProductPacksTableAdapter lookup_ProductPacksTableAdapter = new Lookup_ProductPacksTableAdapter();
      lookup_ProductPacksTableAdapter.Fill(this.techProductsLtdDataSet.Lookup_ProductPacks);

      //DataTable bigTable = this.techProductsLtdDataSet.Fact_Orders_Query;

      DataTable bigTable = JoinCustomers(this.techProductsLtdDataSet.Fact_Orders_Query, this.techProductsLtdDataSet.Lookup_Customers);
      bigTable = JoinProducts(bigTable, this.techProductsLtdDataSet.Lookup_Products);
      bigTable = JoinPack(bigTable, this.techProductsLtdDataSet.Lookup_ProductPacks);

      _dataTables = SliceDataTable(100, bigTable);

      BindNavigator();
    }

    private BindingList<DataTable> _dataTables;
    private BindingSource _bindingSource;

    private BindingList<DataTable> SliceDataTable(int numRows, DataTable orders)
    {
      BindingList<DataTable> result = new BindingList<DataTable>();

      int taken = 0;

      while(taken < orders.Rows.Count)
      {
       
        result.Add(orders.AsEnumerable().Skip(taken).Take(numRows).CopyToDataTable());
        taken += numRows;
      }

      return result;
    }

    private void BindNavigator()
    {
      _bindingSource = new BindingSource();

      fact_Orders_QueryBindingNavigator.BindingSource = _bindingSource;

      _bindingSource.DataSource = _dataTables;
      _bindingSource.PositionChanged += _bindingSource_PositionChanged;
      _bindingSource_PositionChanged(_bindingSource, EventArgs.Empty);
    }

    private void _bindingSource_PositionChanged(object sender, EventArgs e)
    {
      tGrid1.DataSource = null;
      tGrid1.DataSource = _dataTables[_bindingSource.Position];
    }
  }
}
