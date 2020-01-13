using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeGrid.Columns;
using Steema.TeeGrid.Data.Reflection;
using Steema.TeeGrid.Painter;
using Steema.TeeGrid.Renders;
using Steema.TeeGrid.Selection;
using Steema.TeeGrid.WinForm.Painter;

namespace ButtonColumn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var myData = new MyButtonData[10];
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    myData[i] = new MyButtonData() { DummyData = "Five", ValueData = rnd.NextDouble() };
                else
                    myData[i] = new MyButtonData() { DummyData = "", ValueData = rnd.NextDouble() };
            }

            tGrid1.Data = new VirtualArrayData<MyButtonData>(myData);

            tGrid1.Selected.Changed += Selected_Changed;

            ChangeRender(tGrid1.Columns[0]);
        }

        private void Selected_Changed(object sender, EventArgs e)
        {

            var selection = sender as GridSelection;

            if(selection.Column == tGrid1.Columns[0] && selection.Row != 5)
            {
                MessageBox.Show($"You've clicked a button on row {selection.Row}");
            }
        }

        private void ChangeRender(Column column)
        {
            column.Render = new ButtonRender(column.Changed);
        }
    }


    public class ButtonRender : TextRender
    {
        public ButtonRender(EventHandler<EventArgs> AChanged) : base(AChanged)
        {
        }

        public override void Paint(RenderData AData)
        {
            void DoPaint(GdiPlusPainter painter, RectangleF bounds)
            {
                ControlPaint.DrawButton(painter.Canvas, Rectangle.Round(bounds), ButtonState.Normal);
                painter.SetHorizontalAlign(HorizontalAlign.Center);
                painter.TextOut(bounds, "Button Text");

            }

            if (string.IsNullOrEmpty(AData.Data))
            {
                DoPaint((GdiPlusPainter)AData.Painter, AData.Bounds);
            }
            else
            {
                base.Paint(AData);
            }
        }

    }

    public class MyButtonData
    {
        public string DummyData { get; set; }

        public double ValueData { get; set; }
    }
}
