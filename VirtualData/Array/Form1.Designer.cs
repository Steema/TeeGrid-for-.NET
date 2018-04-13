namespace TeeGrid_Array_Data
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
			this.bObject = new System.Windows.Forms.Button();
			this.bString = new System.Windows.Forms.Button();
			this.bFloat = new System.Windows.Forms.Button();
			this.bInteger = new System.Windows.Forms.Button();
			this.bRecord = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.teeGrid1 = new Steema.TeeGrid.WinForm.TGrid();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
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
			this.splitContainer1.Panel1.Controls.Add(this.bObject);
			this.splitContainer1.Panel1.Controls.Add(this.bString);
			this.splitContainer1.Panel1.Controls.Add(this.bFloat);
			this.splitContainer1.Panel1.Controls.Add(this.bInteger);
			this.splitContainer1.Panel1.Controls.Add(this.bRecord);
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(805, 541);
			this.splitContainer1.SplitterDistance = 59;
			this.splitContainer1.TabIndex = 0;
			// 
			// bObject
			// 
			this.bObject.BackColor = System.Drawing.Color.Transparent;
			this.bObject.Location = new System.Drawing.Point(506, 12);
			this.bObject.Name = "bObject";
			this.bObject.Size = new System.Drawing.Size(75, 23);
			this.bObject.TabIndex = 5;
			this.bObject.Text = "Object";
			this.bObject.UseVisualStyleBackColor = false;
			this.bObject.Click += new System.EventHandler(this.bObject_Click);
			// 
			// bString
			// 
			this.bString.BackColor = System.Drawing.Color.Transparent;
			this.bString.Location = new System.Drawing.Point(425, 12);
			this.bString.Name = "bString";
			this.bString.Size = new System.Drawing.Size(75, 23);
			this.bString.TabIndex = 4;
			this.bString.Text = "String ID";
			this.bString.UseVisualStyleBackColor = false;
			this.bString.Click += new System.EventHandler(this.bString_Click);
			// 
			// bFloat
			// 
			this.bFloat.BackColor = System.Drawing.Color.Transparent;
			this.bFloat.Location = new System.Drawing.Point(344, 12);
			this.bFloat.Name = "bFloat";
			this.bFloat.Size = new System.Drawing.Size(75, 23);
			this.bFloat.TabIndex = 3;
			this.bFloat.Text = "Float ID";
			this.bFloat.UseVisualStyleBackColor = false;
			this.bFloat.Click += new System.EventHandler(this.bFloat_Click);
			// 
			// bInteger
			// 
			this.bInteger.BackColor = System.Drawing.Color.Transparent;
			this.bInteger.Location = new System.Drawing.Point(263, 12);
			this.bInteger.Name = "bInteger";
			this.bInteger.Size = new System.Drawing.Size(75, 23);
			this.bInteger.TabIndex = 2;
			this.bInteger.Text = "Integer ID";
			this.bInteger.UseVisualStyleBackColor = false;
			this.bInteger.Click += new System.EventHandler(this.bInteger_Click);
			// 
			// bRecord
			// 
			this.bRecord.BackColor = System.Drawing.Color.Transparent;
			this.bRecord.Location = new System.Drawing.Point(182, 12);
			this.bRecord.Name = "bRecord";
			this.bRecord.Size = new System.Drawing.Size(75, 23);
			this.bRecord.TabIndex = 1;
			this.bRecord.Text = "Record";
			this.bRecord.UseVisualStyleBackColor = false;
			this.bRecord.Click += new System.EventHandler(this.BRecord_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Edit...";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.splitContainer2.Panel1.Controls.Add(this.teeGrid1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
			this.splitContainer2.Panel2.Controls.Add(this.button3);
			this.splitContainer2.Panel2.Controls.Add(this.button2);
			this.splitContainer2.Size = new System.Drawing.Size(805, 478);
			this.splitContainer2.SplitterDistance = 412;
			this.splitContainer2.TabIndex = 0;
			// 
			// teeGrid1
			// 
			this.teeGrid1.BackColor = System.Drawing.Color.White;
			this.teeGrid1.Data = null;
			this.teeGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.teeGrid1.Location = new System.Drawing.Point(0, 0);
			this.teeGrid1.Name = "teeGrid1";
			this.teeGrid1.Painter = gdiPlusPainter1;
			gridScrolling1.Horizontal = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			gridScrolling1.Mode = Steema.TeeGrid.RowGroup.ScrollingMode.Touch;
			gridScrolling1.Vertical = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			this.teeGrid1.Scrolling = gridScrolling1;
			this.teeGrid1.Size = new System.Drawing.Size(805, 412);
			this.teeGrid1.TabIndex = 0;
			this.teeGrid1.Text = "teeGrid1";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.Location = new System.Drawing.Point(117, 27);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Footer...";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.Location = new System.Drawing.Point(12, 27);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "Header...";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 541);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "TeeGrid using Array as Data";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private Steema.TeeGrid.WinForm.TGrid teeGrid1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button bRecord;
		private System.Windows.Forms.Button bInteger;
		private System.Windows.Forms.Button bFloat;
		private System.Windows.Forms.Button bString;
		private System.Windows.Forms.Button bObject;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}

