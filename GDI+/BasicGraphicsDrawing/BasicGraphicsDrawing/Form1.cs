using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGraphicsDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form lineForm = new Form();
            lineForm.Show();
            Pen pen = new Pen(Color.Black, 3);
            Graphics g = lineForm.CreateGraphics();
            g.DrawLine(pen, 10, 50, 100, 50);
            g.DrawLine(pen, 150, 30, 150, 120);
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form rectForm = new Form();
            rectForm.Show();
            Pen pen = new Pen(Color.Black, 3);
            Graphics g = rectForm.CreateGraphics();
            g.DrawRectangle(pen, 10, 10, 250, 200);
            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ellForm = new Form();
            ellForm.Show();
            Pen pen = new Pen(Color.Black, 3);
            Graphics g = ellForm.CreateGraphics();
            g.DrawEllipse(pen, 10, 10, 250, 200);
            g.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form arcForm = new Form();
            arcForm.Show();
            Pen pen = new Pen(Color.Black, 3);
            Graphics g = arcForm.CreateGraphics();
            Rectangle rect = new Rectangle(10, 10, 250, 200);
            g.DrawArc(pen, rect, 200, 210);
            g.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form pieForm = new Form();
            pieForm.Show();
            Pen pen = new Pen(Color.Black, 3);
            Graphics g = pieForm.CreateGraphics();
            g.DrawPie(pen,10,10,250,200,45,135);
            g.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form polForm = new Form();
            polForm.Show();
            Pen pen = new Pen(Color.Black, 3);
            Graphics g = polForm.CreateGraphics();
            Point[] points = { new Point(10,10), new Point(20, 30), new Point(30, 70),
                new Point(40, 30), new Point(50, 30), new Point(60, 90) };
            g.DrawPolygon(pen, points);
            g.Dispose();
        }
    }
}
