namespace TeeGrid_Custom_Sorting
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
			TeeGrid.WinForm.Painter.GdiPlusPainter gdiPlusPainter2 = new TeeGrid.WinForm.Painter.GdiPlusPainter();
			this.teeGrid1 = new TeeGrid.WinForm.Grid.TeeGrid();
			this.SuspendLayout();
			// 
			// teeGrid1
			// 
			this.teeGrid1.Data = null;
			this.teeGrid1.DataSource = null;
			this.teeGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.teeGrid1.Location = new System.Drawing.Point(0, 0);
			this.teeGrid1.Name = "teeGrid1";
			this.teeGrid1.Painter = gdiPlusPainter2;
			this.teeGrid1.Size = new System.Drawing.Size(670, 517);
			this.teeGrid1.TabIndex = 0;
			this.teeGrid1.Text = "teeGrid1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 517);
			this.Controls.Add(this.teeGrid1);
			this.Name = "Form1";
			this.Text = "TeeGrid - Custom Sorting by Code";
			this.ResumeLayout(false);

		}

		#endregion

		private TeeGrid.WinForm.Grid.TeeGrid teeGrid1;
	}
}

