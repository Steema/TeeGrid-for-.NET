namespace TeeGrid_Header_Footer
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tTeeGrid1 = new Steema.TeeGrid.WinForm.TGrid();
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
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
			this.splitContainer1.Panel1.Controls.Add(this.button2);
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tTeeGrid1);
			this.splitContainer1.Size = new System.Drawing.Size(814, 522);
			this.splitContainer1.SplitterDistance = 66;
			this.splitContainer1.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(500, 23);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Footers ...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(419, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Headers ...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.tTeeGrid1.Size = new System.Drawing.Size(814, 452);
			this.tTeeGrid1.TabIndex = 0;
			this.tTeeGrid1.Text = "tTeeGrid1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 522);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "TeeGrid Header and Footer";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private Steema.TeeGrid.WinForm.TGrid tTeeGrid1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}

