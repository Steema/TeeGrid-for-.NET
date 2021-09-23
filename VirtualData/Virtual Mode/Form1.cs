using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Steema.TeeGrid.Data.Strings;

namespace TeeGrid_VirtuaMode
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.BackColor = Color.White;
			Steema.TeeGrid.Themes.GridThemes.DarkFlat.ApplyTo(teeGrid1.Grid);
	

			// Important:
			// Passing an optional default column width (60) means the grid will not need
			// to calculate it, which is much faster.

			// Create data, with 10 columns, lots of rows, (optionally: a default column width = 60)
			data = new VirtualModeData(10, 20000, 60);

			for (int i = 0; i < data.Columns; i++)
			{
				data.Headers[i] = i.ToString();
			}

			data.OnGetValue += GetCell;
			data.OnSetValue += SetCell;

			teeGrid1.Data = data;

            teeGrid1.Columns[4].OnPaint += Column_OnPaint;

           // teeGrid1.Columns[7].OnPaint += Column_OnPaint;


        }

        private static EventHandler<EventArgs> eventType;

        Steema.TeeGrid.Format.Format customFormat = new Steema.TeeGrid.Format.Format(eventType);
        Steema.TeeGrid.Format.TextFormat custTextFormat = new Steema.TeeGrid.Format.TextFormat(eventType);

        private void Column_OnPaint(object sender, Steema.TeeGrid.Columns.ColumnPaintEventArgs e)
        {
            if (e.AData.Row == 3)
            {
                customFormat.Brush.Color = Color.Beige;
                e.AData.Painter.Paint(customFormat, e.AData.Bounds);

                //no text
            }
            else if (e.AData.Row == 7)
            {
                Steema.TeeGrid.Format.Font oldFont = ((Steema.TeeGrid.Columns.Column)(sender)).Format.Font;

                customFormat.Stroke.Color = Color.Red;
                e.AData.Painter.Paint(customFormat, e.AData.Bounds); //brush already set

                Steema.TeeGrid.Format.Font customFont = new Steema.TeeGrid.Format.Font(eventType);

                customFont.Color = Color.Blue;
                customFont.Size = 15;

                custTextFormat.Font = customFont;

                e.AData.Painter.SetFont(customFont);

                ((Steema.TeeGrid.Renders.Render)((Steema.TeeGrid.Columns.Column)(sender)).Render).Paint(e.AData);

                e.AData.Painter.SetFont(oldFont);
            }
            else
                ((Steema.TeeGrid.Renders.Render)((Steema.TeeGrid.Columns.Column)(sender)).Render).Paint(e.AData);
        }

        private void SetCell(object sender, VirtualDataEventArgs e)
		{
			// Called when the cell has been manually edited, or when a Data cell is changed.
			// Store the new e.Value in your real data
		}

		private void GetCell(object sender, VirtualDataEventArgs e)
		{
			e.Value = data.IndexOf(e.Column) + " x " + e.Row; 
		}

		private VirtualModeData data;
	}
}
