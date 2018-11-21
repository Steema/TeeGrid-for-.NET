namespace Grid_Paging
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      Steema.TeeGrid.Columns.Column column1 = new Steema.TeeGrid.Columns.Column();
      Steema.TeeGrid.Columns.Column column2 = new Steema.TeeGrid.Columns.Column();
      Steema.TeeGrid.Columns.Column column3 = new Steema.TeeGrid.Columns.Column();
      Steema.TeeGrid.Columns.Column column4 = new Steema.TeeGrid.Columns.Column();
      Steema.TeeGrid.Columns.Column column5 = new Steema.TeeGrid.Columns.Column();
      Steema.TeeGrid.Columns.Column column6 = new Steema.TeeGrid.Columns.Column();
      Steema.TeeGrid.Columns.Column column7 = new Steema.TeeGrid.Columns.Column();
      Steema.TeeGrid.Columns.Column column8 = new Steema.TeeGrid.Columns.Column();
      this.techProductsLtdDataSet = new Grid_Paging.TechProductsLtdDataSet();
      this.fact_Orders_QueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.fact_Orders_QueryTableAdapter = new Grid_Paging.TechProductsLtdDataSetTableAdapters.Fact_Orders_QueryTableAdapter();
      this.tableAdapterManager = new Grid_Paging.TechProductsLtdDataSetTableAdapters.TableAdapterManager();
      this.fact_Orders_QueryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.fact_Orders_QueryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.tGrid1 = new Steema.TeeGrid.WinForm.TGrid();
      ((System.ComponentModel.ISupportInitialize)(this.techProductsLtdDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fact_Orders_QueryBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fact_Orders_QueryBindingNavigator)).BeginInit();
      this.fact_Orders_QueryBindingNavigator.SuspendLayout();
      this.SuspendLayout();
      // 
      // techProductsLtdDataSet
      // 
      this.techProductsLtdDataSet.DataSetName = "TechProductsLtdDataSet";
      this.techProductsLtdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // fact_Orders_QueryBindingSource
      // 
      this.fact_Orders_QueryBindingSource.DataSource = this.techProductsLtdDataSet.Fact_Orders_Query;
      // 
      // fact_Orders_QueryTableAdapter
      // 
      this.fact_Orders_QueryTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.Connection = null;
      this.tableAdapterManager.UpdateOrder = Grid_Paging.TechProductsLtdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // fact_Orders_QueryBindingNavigator
      // 
      this.fact_Orders_QueryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.fact_Orders_QueryBindingNavigator.BindingSource = this.fact_Orders_QueryBindingSource;
      this.fact_Orders_QueryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.fact_Orders_QueryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.fact_Orders_QueryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.fact_Orders_QueryBindingNavigatorSaveItem});
      this.fact_Orders_QueryBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.fact_Orders_QueryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.fact_Orders_QueryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.fact_Orders_QueryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.fact_Orders_QueryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.fact_Orders_QueryBindingNavigator.Name = "fact_Orders_QueryBindingNavigator";
      this.fact_Orders_QueryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.fact_Orders_QueryBindingNavigator.Size = new System.Drawing.Size(817, 25);
      this.fact_Orders_QueryBindingNavigator.TabIndex = 0;
      this.fact_Orders_QueryBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // fact_Orders_QueryBindingNavigatorSaveItem
      // 
      this.fact_Orders_QueryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.fact_Orders_QueryBindingNavigatorSaveItem.Enabled = false;
      this.fact_Orders_QueryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fact_Orders_QueryBindingNavigatorSaveItem.Image")));
      this.fact_Orders_QueryBindingNavigatorSaveItem.Name = "fact_Orders_QueryBindingNavigatorSaveItem";
      this.fact_Orders_QueryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.fact_Orders_QueryBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // tGrid1
      // 
      column1.FLink = null;
      column1.IsMultiSelect = true;
      column1.Locked = Steema.TeeGrid.Columns.ColumnLocked.Left;
      column2.FLink = "ID";
      column2.Header.Text = "ID";
      column2.Header.TextAlign.Horizontal = Steema.TeeGrid.Painter.HorizontalAlign.Right;
      column3.FLink = "Cod_Customer";
      column3.Header.Text = "Cod_Customer";
      column3.Header.TextAlign.Horizontal = Steema.TeeGrid.Painter.HorizontalAlign.Right;
      column4.FLink = "Orderdate";
      column4.Header.Text = "Orderdate";
      column4.Header.TextAlign.Horizontal = Steema.TeeGrid.Painter.HorizontalAlign.Right;
      column5.FLink = "Invoice_year";
      column5.Header.Text = "Invoice_year";
      column5.Header.TextAlign.Horizontal = Steema.TeeGrid.Painter.HorizontalAlign.Right;
      column6.FLink = "Invoice_num";
      column6.Header.Text = "Invoice_num";
      column6.Header.TextAlign.Horizontal = Steema.TeeGrid.Painter.HorizontalAlign.Right;
      column7.FLink = "Product_code";
      column7.Header.Text = "Product_code";
      column7.Header.TextAlign.Horizontal = Steema.TeeGrid.Painter.HorizontalAlign.Right;
      column8.FLink = "Pack_code";
      column8.Header.Text = "Pack_code";
      column8.Header.TextAlign.Horizontal = Steema.TeeGrid.Painter.HorizontalAlign.Right;
      this.tGrid1.Columns.Add(column1);
      this.tGrid1.Columns.Add(column2);
      this.tGrid1.Columns.Add(column3);
      this.tGrid1.Columns.Add(column4);
      this.tGrid1.Columns.Add(column5);
      this.tGrid1.Columns.Add(column6);
      this.tGrid1.Columns.Add(column7);
      this.tGrid1.Columns.Add(column8);
      this.tGrid1.DataSource = this.fact_Orders_QueryBindingSource;
      this.tGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tGrid1.Location = new System.Drawing.Point(0, 25);
      this.tGrid1.Name = "tGrid1";
      this.tGrid1.Selected.ScrollToView = false;
      this.tGrid1.Size = new System.Drawing.Size(817, 498);
      this.tGrid1.TabIndex = 1;
      this.tGrid1.Text = "tGrid1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(817, 523);
      this.Controls.Add(this.tGrid1);
      this.Controls.Add(this.fact_Orders_QueryBindingNavigator);
      this.Name = "Form1";
      this.Text = "TGrid Paging";
      ((System.ComponentModel.ISupportInitialize)(this.techProductsLtdDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fact_Orders_QueryBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fact_Orders_QueryBindingNavigator)).EndInit();
      this.fact_Orders_QueryBindingNavigator.ResumeLayout(false);
      this.fact_Orders_QueryBindingNavigator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TechProductsLtdDataSet techProductsLtdDataSet;
    private System.Windows.Forms.BindingSource fact_Orders_QueryBindingSource;
    private TechProductsLtdDataSetTableAdapters.Fact_Orders_QueryTableAdapter fact_Orders_QueryTableAdapter;
    private TechProductsLtdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator fact_Orders_QueryBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton fact_Orders_QueryBindingNavigatorSaveItem;
    private Steema.TeeGrid.WinForm.TGrid tGrid1;
  }
}

