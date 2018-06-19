namespace TeeGrid_Themes_WinForm
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
			Steema.TeeGrid.WinForm.Painter.GdiPlusPainter gdiPlusPainter2 = new Steema.TeeGrid.WinForm.Painter.GdiPlusPainter();
			Steema.TeeGrid.RowGroup.GridScrolling gridScrolling2 = new Steema.TeeGrid.RowGroup.GridScrolling();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.bExport = new System.Windows.Forms.Button();
			this.bEdit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbThemes = new System.Windows.Forms.ListBox();
			this.tTeeGrid1 = new Steema.TeeGrid.WinForm.TGrid();
			this.gbFormat = new System.Windows.Forms.GroupBox();
			this.rbNative = new System.Windows.Forms.RadioButton();
			this.rbJsGrid = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.gbFormat.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.gbFormat);
			this.splitContainer1.Panel1.Controls.Add(this.bExport);
			this.splitContainer1.Panel1.Controls.Add(this.bEdit);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.lbThemes);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tTeeGrid1);
			this.splitContainer1.Size = new System.Drawing.Size(968, 649);
			this.splitContainer1.SplitterDistance = 174;
			this.splitContainer1.TabIndex = 0;
			// 
			// bExport
			// 
			this.bExport.Location = new System.Drawing.Point(12, 251);
			this.bExport.Name = "bExport";
			this.bExport.Size = new System.Drawing.Size(75, 47);
			this.bExport.TabIndex = 3;
			this.bExport.Text = "Export to browser";
			this.bExport.UseVisualStyleBackColor = true;
			this.bExport.Click += new System.EventHandler(this.button1_Click);
			// 
			// bEdit
			// 
			this.bEdit.Location = new System.Drawing.Point(12, 206);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(75, 23);
			this.bEdit.TabIndex = 2;
			this.bEdit.Text = "&Editor";
			this.bEdit.UseVisualStyleBackColor = true;
			this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "TeeGrid Themes:";
			// 
			// lbThemes
			// 
			this.lbThemes.FormattingEnabled = true;
			this.lbThemes.Items.AddRange(new object[] {
            "Default",
            "iOS",
            "Android",
            "Black",
            "BlueFlat",
            "SilverFlat",
            "DarkFlat",
            "Flat"});
			this.lbThemes.Location = new System.Drawing.Point(12, 77);
			this.lbThemes.Name = "lbThemes";
			this.lbThemes.Size = new System.Drawing.Size(115, 82);
			this.lbThemes.TabIndex = 0;
			this.lbThemes.SelectedIndexChanged += new System.EventHandler(this.LbThemes_SelectedIndexChanged);
			// 
			// tTeeGrid1
			// 
			this.tTeeGrid1.Data = null;
			this.tTeeGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tTeeGrid1.Location = new System.Drawing.Point(0, 0);
			this.tTeeGrid1.Name = "tTeeGrid1";
			this.tTeeGrid1.Painter = gdiPlusPainter2;
			gridScrolling2.Horizontal = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			gridScrolling2.Mode = Steema.TeeGrid.RowGroup.ScrollingMode.Touch;
			gridScrolling2.Vertical = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			this.tTeeGrid1.Scrolling = gridScrolling2;
			this.tTeeGrid1.Size = new System.Drawing.Size(790, 649);
			this.tTeeGrid1.SortableColumns = true;
			this.tTeeGrid1.TabIndex = 0;
			this.tTeeGrid1.Text = "tTeeGrid1";
			// 
			// gbFormat
			// 
			this.gbFormat.Controls.Add(this.rbJsGrid);
			this.gbFormat.Controls.Add(this.rbNative);
			this.gbFormat.Location = new System.Drawing.Point(12, 313);
			this.gbFormat.Name = "gbFormat";
			this.gbFormat.Size = new System.Drawing.Size(128, 79);
			this.gbFormat.TabIndex = 5;
			this.gbFormat.TabStop = false;
			this.gbFormat.Text = "HTML Export Format";
			// 
			// rbNative
			// 
			this.rbNative.AutoSize = true;
			this.rbNative.Checked = true;
			this.rbNative.Location = new System.Drawing.Point(17, 29);
			this.rbNative.Name = "rbNative";
			this.rbNative.Size = new System.Drawing.Size(54, 17);
			this.rbNative.TabIndex = 0;
			this.rbNative.TabStop = true;
			this.rbNative.Text = "&native";
			this.rbNative.UseVisualStyleBackColor = true;
			// 
			// rbJsGrid
			// 
			this.rbJsGrid.AutoSize = true;
			this.rbJsGrid.Location = new System.Drawing.Point(17, 52);
			this.rbJsGrid.Name = "rbJsGrid";
			this.rbJsGrid.Size = new System.Drawing.Size(51, 17);
			this.rbJsGrid.TabIndex = 1;
			this.rbJsGrid.Text = "&jsGrid";
			this.rbJsGrid.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 649);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "TeeGrid Themes example";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.gbFormat.ResumeLayout(false);
			this.gbFormat.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbThemes;
		private Steema.TeeGrid.WinForm.TGrid tTeeGrid1;
		private System.Windows.Forms.Button bEdit;
		private System.Windows.Forms.Button bExport;
		private System.Windows.Forms.GroupBox gbFormat;
		private System.Windows.Forms.RadioButton rbJsGrid;
		private System.Windows.Forms.RadioButton rbNative;
	}
}

