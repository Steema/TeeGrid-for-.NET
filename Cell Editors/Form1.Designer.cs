namespace TeeGrid_Cell_Editors
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbCustomEditors = new System.Windows.Forms.CheckBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tTeeGrid1 = new Steema.TeeGrid.WinForm.TGrid();
			this.label6 = new System.Windows.Forms.Label();
			this.cbEnterKey = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbSelectedText = new System.Windows.Forms.CheckBox();
			this.cbAlwaysVisible = new System.Windows.Forms.CheckBox();
			this.cbAutoEdit = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.cbCustomEditors);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(834, 429);
			this.splitContainer1.SplitterDistance = 33;
			this.splitContainer1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(270, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Double-Click a cell or press F2 to edit it";
			// 
			// cbCustomEditors
			// 
			this.cbCustomEditors.AutoSize = true;
			this.cbCustomEditors.Checked = true;
			this.cbCustomEditors.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCustomEditors.Location = new System.Drawing.Point(33, 13);
			this.cbCustomEditors.Name = "cbCustomEditors";
			this.cbCustomEditors.Size = new System.Drawing.Size(182, 17);
			this.cbCustomEditors.TabIndex = 0;
			this.cbCustomEditors.Text = "Use different controls to edit cells";
			this.cbCustomEditors.UseVisualStyleBackColor = true;
			this.cbCustomEditors.CheckedChanged += new System.EventHandler(this.CbCustomEditors_CheckedChanged);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.tTeeGrid1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
			this.splitContainer2.Panel2.Controls.Add(this.label6);
			this.splitContainer2.Panel2.Controls.Add(this.cbEnterKey);
			this.splitContainer2.Panel2.Controls.Add(this.label5);
			this.splitContainer2.Panel2.Controls.Add(this.label4);
			this.splitContainer2.Panel2.Controls.Add(this.label3);
			this.splitContainer2.Panel2.Controls.Add(this.cbSelectedText);
			this.splitContainer2.Panel2.Controls.Add(this.cbAlwaysVisible);
			this.splitContainer2.Panel2.Controls.Add(this.cbAutoEdit);
			this.splitContainer2.Panel2.Controls.Add(this.label2);
			this.splitContainer2.Size = new System.Drawing.Size(834, 392);
			this.splitContainer2.SplitterDistance = 237;
			this.splitContainer2.TabIndex = 0;
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
			this.tTeeGrid1.Size = new System.Drawing.Size(834, 237);
			this.tTeeGrid1.TabIndex = 0;
			this.tTeeGrid1.Text = "tTeeGrid1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(77, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Enter key:";
			// 
			// cbEnterKey
			// 
			this.cbEnterKey.FormattingEnabled = true;
			this.cbEnterKey.Items.AddRange(new object[] {
            "Move to next cell (at right)",
            "Move to cell below",
            "Keep on same cell"});
			this.cbEnterKey.Location = new System.Drawing.Point(138, 122);
			this.cbEnterKey.Name = "cbEnterKey";
			this.cbEnterKey.Size = new System.Drawing.Size(192, 21);
			this.cbEnterKey.TabIndex = 7;
			this.cbEnterKey.Text = "Move to next cell (at right)";
			this.cbEnterKey.SelectedIndexChanged += new System.EventHandler(this.CbEnterKey_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(135, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(303, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "True = Cell editor using TEdit will select all text when showing it";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(135, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(383, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "True = Cell editing is always active when changing from one cell to another cells" +
    "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(135, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(375, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "True = Type any key to start cell editing.   False = Double-click cell or press F" +
    "2";
			// 
			// cbSelectedText
			// 
			this.cbSelectedText.AutoSize = true;
			this.cbSelectedText.Location = new System.Drawing.Point(16, 99);
			this.cbSelectedText.Name = "cbSelectedText";
			this.cbSelectedText.Size = new System.Drawing.Size(92, 17);
			this.cbSelectedText.TabIndex = 3;
			this.cbSelectedText.Text = "Selected Text";
			this.cbSelectedText.UseVisualStyleBackColor = true;
			this.cbSelectedText.CheckedChanged += new System.EventHandler(this.CbSelectedText_CheckedChanged);
			// 
			// cbAlwaysVisible
			// 
			this.cbAlwaysVisible.AutoSize = true;
			this.cbAlwaysVisible.Location = new System.Drawing.Point(16, 76);
			this.cbAlwaysVisible.Name = "cbAlwaysVisible";
			this.cbAlwaysVisible.Size = new System.Drawing.Size(92, 17);
			this.cbAlwaysVisible.TabIndex = 2;
			this.cbAlwaysVisible.Text = "Always Visible";
			this.cbAlwaysVisible.UseVisualStyleBackColor = true;
			this.cbAlwaysVisible.CheckedChanged += new System.EventHandler(this.CbAlwaysVisible_CheckedChanged);
			// 
			// cbAutoEdit
			// 
			this.cbAutoEdit.AutoSize = true;
			this.cbAutoEdit.Location = new System.Drawing.Point(16, 53);
			this.cbAutoEdit.Name = "cbAutoEdit";
			this.cbAutoEdit.Size = new System.Drawing.Size(69, 17);
			this.cbAutoEdit.TabIndex = 1;
			this.cbAutoEdit.Text = "Auto Edit";
			this.cbAutoEdit.UseVisualStyleBackColor = true;
			this.cbAutoEdit.CheckedChanged += new System.EventHandler(this.CbAutoEdit_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Editing options:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 429);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "TeeGrid - Cell Editors Example";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.CheckBox cbCustomEditors;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.CheckBox cbSelectedText;
		private System.Windows.Forms.CheckBox cbAlwaysVisible;
		private System.Windows.Forms.CheckBox cbAutoEdit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbEnterKey;
		private Steema.TeeGrid.WinForm.TGrid tTeeGrid1;
	}
}

