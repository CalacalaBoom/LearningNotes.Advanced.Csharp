using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BrushCase
{
    public partial class Form1 : Form
    {
        static bool isExsis=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Graphics ghs = this.CreateGraphics();
            if (isExsis)
            {
                ghs.Clear(Color.White);
            }
            Brush mybs = new SolidBrush(Color.Red);
            Rectangle rt = new Rectangle(210, 100, 100, 100);
            ghs.FillRectangle(mybs, rt);
            isExsis = true;
            ghs.Dispose();
        }

        private void btnPointBrush_Click(object sender, EventArgs e)
        {
            Graphics ghs = this.CreateGraphics();
            if (isExsis)
            {
                ghs.Clear(Color.White);
            }
            for (int i = 1; i < 6; i++)
            {
                HatchStyle hs = (HatchStyle)(5 + i);
                HatchBrush hb = new HatchBrush(hs, Color.White);
                Rectangle rtl = new Rectangle(10, 50 * i, 50 * i, 50);
                ghs.FillRectangle(hb, rtl);
            }
            isExsis = true;
            ghs.Dispose();
        }

        private void btnLG_Click(object sender, EventArgs e)
        {
            Graphics ghs = this.CreateGraphics();
            if (isExsis)
            {
                ghs.Clear(Color.White);
            }
            Point p1 = new Point(100, 100);
            Point p2 = new Point(150, 150);
            LinearGradientBrush LGB = new LinearGradientBrush(p1, p2, Color.Yellow, Color.Orange);
            LGB.WrapMode = WrapMode.Tile;
            Rectangle rectangle = new Rectangle(210, 100, 100, 100);
            ghs.FillRectangle(LGB, rectangle);
            isExsis = true;
            ghs.Dispose();
        }
    }
}
