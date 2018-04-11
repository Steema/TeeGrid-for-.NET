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
			TeeGrid.WinForm.Painter.GdiPlusPainter gdiPlusPainter1 = new TeeGrid.WinForm.Painter.GdiPlusPainter();
			TeeGrid.RowGroup.GridScrolling gridScrolling1 = new TeeGrid.RowGroup.GridScrolling();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.lbThemes = new System.Windows.Forms.ListBox();
			this.tTeeGrid1 = new TeeGrid.WinForm.Grid.TeeGrid();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
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
			this.tTeeGrid1.Painter = gdiPlusPainter1;
			gridScrolling1.Horizontal = TeeGrid.RowGroup.ScrollDirection.Normal;
			gridScrolling1.Mode = TeeGrid.RowGroup.ScrollingMode.Touch;
			gridScrolling1.Vertical = TeeGrid.RowGroup.ScrollDirection.Normal;
			this.tTeeGrid1.Scrolling = gridScrolling1;
			this.tTeeGrid1.Size = new System.Drawing.Size(790, 649);
			this.tTeeGrid1.TabIndex = 0;
			this.tTeeGrid1.Text = "tTeeGrid1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 649);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbThemes;
		private TeeGrid.WinForm.Grid.TeeGrid tTeeGrid1;
	}
}

