namespace TeeGrid_WinForm_Master_Detail
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Steema.TeeGrid.WinForm.Painter.GdiPlusPainter gdiPlusPainter1 = new Steema.TeeGrid.WinForm.Painter.GdiPlusPainter();
			Steema.TeeGrid.RowGroup.GridScrolling gridScrolling1 = new Steema.TeeGrid.RowGroup.GridScrolling();
			this.bindingCustomers = new System.Windows.Forms.BindingSource(this.components);
			this.fddemoDataSet = new TeeGrid_WinForm_Master_Detail.fddemoDataSet();
			this.bindingOrders = new System.Windows.Forms.BindingSource(this.components);
			this.ordersTableAdapter = new TeeGrid_WinForm_Master_Detail.fddemoDataSetTableAdapters.OrdersTableAdapter();
			this.customersTableAdapter = new TeeGrid_WinForm_Master_Detail.fddemoDataSetTableAdapters.CustomersTableAdapter();
			this.teeGrid1 = new Steema.TeeGrid.WinForm.TGrid();
			((System.ComponentModel.ISupportInitialize)(this.bindingCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fddemoDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// bindingCustomers
			// 
			this.bindingCustomers.DataMember = "Customers";
			this.bindingCustomers.DataSource = this.fddemoDataSet;
			// 
			// fddemoDataSet
			// 
			this.fddemoDataSet.DataSetName = "fddemoDataSet";
			this.fddemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bindingOrders
			// 
			this.bindingOrders.DataMember = "Orders";
			this.bindingOrders.DataSource = this.fddemoDataSet;
			// 
			// ordersTableAdapter
			// 
			this.ordersTableAdapter.ClearBeforeFill = true;
			// 
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
			// 
			// teeGrid1
			// 
			this.teeGrid1.Data = null;
			this.teeGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.teeGrid1.Location = new System.Drawing.Point(0, 0);
			this.teeGrid1.Name = "teeGrid1";
			this.teeGrid1.Painter = gdiPlusPainter1;
			gridScrolling1.Horizontal = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			gridScrolling1.Mode = Steema.TeeGrid.RowGroup.ScrollingMode.Touch;
			gridScrolling1.Vertical = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			this.teeGrid1.Scrolling = gridScrolling1;
			this.teeGrid1.Size = new System.Drawing.Size(845, 502);
			this.teeGrid1.TabIndex = 0;
			this.teeGrid1.Text = "tGrid1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 502);
			this.Controls.Add(this.teeGrid1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.bindingCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fddemoDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource bindingOrders;
		private fddemoDataSet fddemoDataSet;
		private fddemoDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
		private System.Windows.Forms.BindingSource bindingCustomers;
		private fddemoDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private Steema.TeeGrid.WinForm.TGrid teeGrid1;
	}
}

