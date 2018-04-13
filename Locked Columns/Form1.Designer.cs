namespace TeeGrid_Locked_Columns
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
			Steema.TeeGrid.WinForm.Painter.GdiPlusPainter gdiPlusPainter1 = new Steema.TeeGrid.WinForm.Painter.GdiPlusPainter();
			Steema.TeeGrid.RowGroup.GridScrolling gridScrolling1 = new Steema.TeeGrid.RowGroup.GridScrolling();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbRight = new System.Windows.Forms.RadioButton();
			this.rbLeft = new System.Windows.Forms.RadioButton();
			this.rbNone = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.lbColumns = new System.Windows.Forms.ListBox();
			this.tTeeGrid1 = new Steema.TeeGrid.WinForm.TGrid();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.lbColumns);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tTeeGrid1);
			this.splitContainer1.Size = new System.Drawing.Size(822, 569);
			this.splitContainer1.SplitterDistance = 142;
			this.splitContainer1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbRight);
			this.groupBox1.Controls.Add(this.rbLeft);
			this.groupBox1.Controls.Add(this.rbNone);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(12, 334);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(120, 114);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Locked";
			// 
			// rbRight
			// 
			this.rbRight.AutoSize = true;
			this.rbRight.Location = new System.Drawing.Point(7, 77);
			this.rbRight.Name = "rbRight";
			this.rbRight.Size = new System.Drawing.Size(50, 17);
			this.rbRight.TabIndex = 2;
			this.rbRight.TabStop = true;
			this.rbRight.Text = "Right";
			this.rbRight.UseVisualStyleBackColor = true;
			this.rbRight.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rbLeft
			// 
			this.rbLeft.AutoSize = true;
			this.rbLeft.Location = new System.Drawing.Point(7, 54);
			this.rbLeft.Name = "rbLeft";
			this.rbLeft.Size = new System.Drawing.Size(43, 17);
			this.rbLeft.TabIndex = 1;
			this.rbLeft.TabStop = true;
			this.rbLeft.Text = "Left";
			this.rbLeft.UseVisualStyleBackColor = true;
			this.rbLeft.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rbNone
			// 
			this.rbNone.AutoSize = true;
			this.rbNone.Location = new System.Drawing.Point(7, 31);
			this.rbNone.Name = "rbNone";
			this.rbNone.Size = new System.Drawing.Size(51, 17);
			this.rbNone.TabIndex = 0;
			this.rbNone.TabStop = true;
			this.rbNone.Text = "None";
			this.rbNone.UseVisualStyleBackColor = true;
			this.rbNone.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Columns:";
			// 
			// lbColumns
			// 
			this.lbColumns.FormattingEnabled = true;
			this.lbColumns.Location = new System.Drawing.Point(12, 45);
			this.lbColumns.Name = "lbColumns";
			this.lbColumns.Size = new System.Drawing.Size(120, 264);
			this.lbColumns.TabIndex = 0;
			this.lbColumns.SelectedIndexChanged += new System.EventHandler(this.lbColumns_SelectedIndexChanged);
			// 
			// tTeeGrid1
			// 
			this.tTeeGrid1.BackColor = System.Drawing.Color.White;
			this.tTeeGrid1.Data = null;
			this.tTeeGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tTeeGrid1.Location = new System.Drawing.Point(0, 0);
			this.tTeeGrid1.Name = "tTeeGrid1";
			this.tTeeGrid1.Painter = gdiPlusPainter1;
			gridScrolling1.Horizontal = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			gridScrolling1.Mode = Steema.TeeGrid.RowGroup.ScrollingMode.Touch;
			gridScrolling1.Vertical = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			this.tTeeGrid1.Scrolling = gridScrolling1;
			this.tTeeGrid1.Size = new System.Drawing.Size(676, 569);
			this.tTeeGrid1.TabIndex = 0;
			this.tTeeGrid1.Text = "tTeeGrid1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 569);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "TeeGrid - Locked Columns Example";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private Steema.TeeGrid.WinForm.TGrid tTeeGrid1;
		private System.Windows.Forms.ListBox lbColumns;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbRight;
		private System.Windows.Forms.RadioButton rbLeft;
		private System.Windows.Forms.RadioButton rbNone;
	}
}

