namespace TeeGrid_VirtuaMode
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
      this.teeGrid1 = new Steema.TeeGrid.WinForm.TGrid();
      this.SuspendLayout();
      // 
      // teeGrid1
      // 
      this.teeGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.teeGrid1.Location = new System.Drawing.Point(0, 0);
      this.teeGrid1.Name = "teeGrid1";
      this.teeGrid1.Selected.ScrollToView = false;
      this.teeGrid1.Size = new System.Drawing.Size(692, 484);
      this.teeGrid1.TabIndex = 0;
      this.teeGrid1.Text = "tGrid1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(692, 484);
      this.Controls.Add(this.teeGrid1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

		}

    #endregion

    private Steema.TeeGrid.WinForm.TGrid teeGrid1;
  }
}

