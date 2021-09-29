using Steema.TeeGrid.Data.Strings;
using Steema.TeeGrid.WinForm.Editors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeeGrid_VirtuaMode
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      BackColor = Color.White;
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

      teeGrid1.Columns[2].ParentFormat = false;
      teeGrid1.Columns[2].Format.Brush.Color = Color.LightSeaGreen;
      teeGrid1.Columns[2].Format.Brush.Show();


      var row = teeGrid1.Rows.Items.AddRow(4);
      row.Format.Brush.Color = Color.CornflowerBlue;
      row.Format.Brush.Show();

      //or
      teeGrid1.Rows.Items[2].Format.Brush.Show();
      teeGrid1.Rows.Items[2].Format.Brush.Color = Color.LightGoldenrodYellow;
      teeGrid1.Rows.Items[2].Format.Stroke.Color = Color.Fuchsia;
      teeGrid1.Rows.Items[2].Format.Stroke.Show();
      teeGrid1.Rows.Items[2].Format.Font.Color = Color.Red;
      teeGrid1.Rows.Items[2].Format.Font.Style = Steema.TeeGrid.Format.FontStyle.Strikeout;

      teeGrid1.Rows.Items[3000].Format.Brush.Color = Color.CornflowerBlue;
      teeGrid1.Rows.Items[3000].Format.Brush.Show();


      var cell = teeGrid1.CellFormat.AddCell(10, teeGrid1.Columns["6"].Index);
      cell.Format.Font.Style = Steema.TeeGrid.Format.FontStyle.Bold;
      cell.Format.Brush.Color = Color.HotPink;
      cell.Format.Brush.Show();

      //or
      teeGrid1.CellFormat[10, 8].Format.Brush.Color = Color.PaleGoldenrod;
      teeGrid1.CellFormat[10, 8].Format.Brush.Show();

      teeGrid1.Rows.Items[10].Format.Brush.Show();
      teeGrid1.Rows.Items[10].Format.Brush.Color = Color.CornflowerBlue;
      teeGrid1.Rows.Items[10].Format.Font.Color = Color.Red;
      teeGrid1.Rows.Items[10].Format.Font.Style = Steema.TeeGrid.Format.FontStyle.Strikeout;

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

    private readonly VirtualModeData data;
  }
}
