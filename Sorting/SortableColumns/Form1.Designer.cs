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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.rbPerson = new System.Windows.Forms.RadioButton();
      this.rbAddress = new System.Windows.Forms.RadioButton();
      this.gbDataSource = new System.Windows.Forms.GroupBox();
      this.rbGridSource = new System.Windows.Forms.RadioButton();
      this.rbBindingSource = new System.Windows.Forms.RadioButton();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.tGrid1 = new Steema.TeeGrid.WinForm.TGrid();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.gbDataSource.SuspendLayout();
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
      this.splitContainer1.Panel1.Controls.Add(this.gbDataSource);
      this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tGrid1);
      this.splitContainer1.Size = new System.Drawing.Size(1249, 469);
      this.splitContainer1.SplitterDistance = 182;
      this.splitContainer1.TabIndex = 0;
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.rbPerson);
      this.groupBox4.Controls.Add(this.rbAddress);
      this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox4.Location = new System.Drawing.Point(0, 392);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(182, 77);
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
      // rbAddress
      // 
      this.rbAddress.AutoSize = true;
      this.rbAddress.Checked = true;
      this.rbAddress.Location = new System.Drawing.Point(7, 19);
      this.rbAddress.Name = "rbAddress";
      this.rbAddress.Size = new System.Drawing.Size(83, 17);
      this.rbAddress.TabIndex = 0;
      this.rbAddress.TabStop = true;
      this.rbAddress.Text = "T is Address";
      this.rbAddress.UseVisualStyleBackColor = true;
      this.rbAddress.CheckedChanged += new System.EventHandler(this.typeOfData_CheckedChanged);
      // 
      // gbDataSource
      // 
      this.gbDataSource.Controls.Add(this.rbGridSource);
      this.gbDataSource.Controls.Add(this.rbBindingSource);
      this.gbDataSource.Dock = System.Windows.Forms.DockStyle.Top;
      this.gbDataSource.Location = new System.Drawing.Point(0, 17);
      this.gbDataSource.Name = "gbDataSource";
      this.gbDataSource.Size = new System.Drawing.Size(182, 75);
      this.gbDataSource.TabIndex = 1;
      this.gbDataSource.TabStop = false;
      this.gbDataSource.Text = "Source of Data";
      // 
      // rbGridSource
      // 
      this.rbGridSource.AutoSize = true;
      this.rbGridSource.Location = new System.Drawing.Point(12, 42);
      this.rbGridSource.Name = "rbGridSource";
      this.rbGridSource.Size = new System.Drawing.Size(88, 17);
      this.rbGridSource.TabIndex = 1;
      this.rbGridSource.Text = "TGrid Source";
      this.rbGridSource.UseVisualStyleBackColor = true;
      this.rbGridSource.CheckedChanged += new System.EventHandler(this.sourceOfData_CheckedChanged);
      // 
      // rbBindingSource
      // 
      this.rbBindingSource.AutoSize = true;
      this.rbBindingSource.Checked = true;
      this.rbBindingSource.Location = new System.Drawing.Point(12, 19);
      this.rbBindingSource.Name = "rbBindingSource";
      this.rbBindingSource.Size = new System.Drawing.Size(94, 17);
      this.rbBindingSource.TabIndex = 0;
      this.rbBindingSource.TabStop = true;
      this.rbBindingSource.Text = "BindingSource";
      this.rbBindingSource.UseVisualStyleBackColor = true;
      this.rbBindingSource.CheckedChanged += new System.EventHandler(this.sourceOfData_CheckedChanged);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.checkBox1.Location = new System.Drawing.Point(0, 0);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(182, 17);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "SortableColumns";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // tGrid1
      // 
      this.tGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tGrid1.Location = new System.Drawing.Point(0, 0);
      this.tGrid1.Name = "tGrid1";
      this.tGrid1.Size = new System.Drawing.Size(1063, 469);
      this.tGrid1.TabIndex = 0;
      this.tGrid1.Text = "tGrid1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1249, 469);
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
      this.gbDataSource.ResumeLayout(false);
      this.gbDataSource.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private Steema.TeeGrid.WinForm.TGrid tGrid1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox gbDataSource;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rbPerson;
		private System.Windows.Forms.RadioButton rbAddress;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.RadioButton rbBindingSource;
		private System.Windows.Forms.RadioButton rbGridSource;
	}
}

