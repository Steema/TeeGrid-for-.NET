namespace TeeGrid_SortableColumns
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
			Steema.TeeGrid.WinForm.Painter.GdiPlusPainter gdiPlusPainter2 = new Steema.TeeGrid.WinForm.Painter.GdiPlusPainter();
			Steema.TeeGrid.RowGroup.GridScrolling gridScrolling2 = new Steema.TeeGrid.RowGroup.GridScrolling();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rbPerson = new System.Windows.Forms.RadioButton();
			this.rbCars = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbAsSortableBindingList = new System.Windows.Forms.RadioButton();
			this.rbAsDataTable = new System.Windows.Forms.RadioButton();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.tGrid1 = new Steema.TeeGrid.WinForm.TGrid();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.cbAsList = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tGrid1);
			this.splitContainer1.Size = new System.Drawing.Size(794, 469);
			this.splitContainer1.SplitterDistance = 220;
			this.splitContainer1.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.rbPerson);
			this.groupBox4.Controls.Add(this.rbCars);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox4.Location = new System.Drawing.Point(0, 392);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(220, 77);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Type of Data";
			// 
			// rbPerson
			// 
			this.rbPerson.AutoSize = true;
			this.rbPerson.Location = new System.Drawing.Point(7, 42);
			this.rbPerson.Name = "rbPerson";
			this.rbPerson.Size = new System.Drawing.Size(78, 17);
			this.rbPerson.TabIndex = 1;
			this.rbPerson.Text = "T is Person";
			this.rbPerson.UseVisualStyleBackColor = true;
			// 
			// rbCars
			// 
			this.rbCars.AutoSize = true;
			this.rbCars.Checked = true;
			this.rbCars.Location = new System.Drawing.Point(7, 19);
			this.rbCars.Name = "rbCars";
			this.rbCars.Size = new System.Drawing.Size(66, 17);
			this.rbCars.TabIndex = 0;
			this.rbCars.TabStop = true;
			this.rbCars.Text = "T is Cars";
			this.rbCars.UseVisualStyleBackColor = true;
			this.rbCars.CheckedChanged += new System.EventHandler(this.typeOfData_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(220, 151);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source of Data";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbAsList);
			this.groupBox3.Location = new System.Drawing.Point(7, 96);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(167, 45);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "TGrid Source";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbAsSortableBindingList);
			this.groupBox2.Controls.Add(this.rbAsDataTable);
			this.groupBox2.Location = new System.Drawing.Point(7, 20);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(167, 70);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "BindingSource";
			// 
			// rbAsSortableBindingList
			// 
			this.rbAsSortableBindingList.AutoSize = true;
			this.rbAsSortableBindingList.Location = new System.Drawing.Point(6, 42);
			this.rbAsSortableBindingList.Name = "rbAsSortableBindingList";
			this.rbAsSortableBindingList.Size = new System.Drawing.Size(149, 17);
			this.rbAsSortableBindingList.TabIndex = 1;
			this.rbAsSortableBindingList.TabStop = true;
			this.rbAsSortableBindingList.Text = "As SortableBindingList<T>";
			this.rbAsSortableBindingList.UseVisualStyleBackColor = true;
			this.rbAsSortableBindingList.CheckedChanged += new System.EventHandler(this.sourceOfData_CheckedChanged);
			// 
			// rbAsDataTable
			// 
			this.rbAsDataTable.AutoSize = true;
			this.rbAsDataTable.Checked = true;
			this.rbAsDataTable.Location = new System.Drawing.Point(6, 19);
			this.rbAsDataTable.Name = "rbAsDataTable";
			this.rbAsDataTable.Size = new System.Drawing.Size(90, 17);
			this.rbAsDataTable.TabIndex = 0;
			this.rbAsDataTable.TabStop = true;
			this.rbAsDataTable.Text = "As DataTable";
			this.rbAsDataTable.UseVisualStyleBackColor = true;
			this.rbAsDataTable.CheckedChanged += new System.EventHandler(this.sourceOfData_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.checkBox1.Location = new System.Drawing.Point(0, 0);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(220, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "SortableColumns";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// tGrid1
			// 
			this.tGrid1.Data = null;
			this.tGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tGrid1.Location = new System.Drawing.Point(0, 0);
			this.tGrid1.Name = "tGrid1";
			this.tGrid1.Painter = gdiPlusPainter2;
			gridScrolling2.Horizontal = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			gridScrolling2.Mode = Steema.TeeGrid.RowGroup.ScrollingMode.Touch;
			gridScrolling2.Vertical = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			this.tGrid1.Scrolling = gridScrolling2;
			this.tGrid1.Size = new System.Drawing.Size(570, 469);
			this.tGrid1.SortableColumns = true;
			this.tGrid1.TabIndex = 0;
			this.tGrid1.Text = "tGrid1";
			// 
			// cbAsList
			// 
			this.cbAsList.AutoSize = true;
			this.cbAsList.Location = new System.Drawing.Point(6, 19);
			this.cbAsList.Name = "cbAsList";
			this.cbAsList.Size = new System.Drawing.Size(76, 17);
			this.cbAsList.TabIndex = 0;
			this.cbAsList.Text = "As List<T>";
			this.cbAsList.UseVisualStyleBackColor = true;
			this.cbAsList.CheckedChanged += new System.EventHandler(this.cbAsList_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 469);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "SortableColumns";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private Steema.TeeGrid.WinForm.TGrid tGrid1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbAsSortableBindingList;
		private System.Windows.Forms.RadioButton rbAsDataTable;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rbPerson;
		private System.Windows.Forms.RadioButton rbCars;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.CheckBox cbAsList;
	}
}

