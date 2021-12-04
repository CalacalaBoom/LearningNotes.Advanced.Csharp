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

namespace EmployOfGDI_
{
    public partial class DrawBCForm : Form
    {
        private string[] en;
        private int[] ti;
        public DrawBCForm()
        {
            InitializeComponent();
        }

        public DrawBCForm(string[] name, int[] tickets)
        {
            InitializeComponent();
            this.en = name;
            this.ti = tickets;
        }

        private void DrawBCForm_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(775, 425);
            Graphics g = Graphics.FromImage(bitmap);
            //计算票数所占的百分比
            int sum = 0;
            foreach (int n in ti)
            {
                sum += n;
            }
            float tp1 = Convert.ToSingle((Convert.ToSingle(ti[0]) / Convert.ToSingle(sum)) * 500);
            float tp2 = Convert.ToSingle((Convert.ToSingle(ti[1]) / Convert.ToSingle(sum)) * 500);
            float tp3 = Convert.ToSingle((Convert.ToSingle(ti[2]) / Convert.ToSingle(sum)) * 500);
            float tp4 = Convert.ToSingle((Convert.ToSingle(ti[3]) / Convert.ToSingle(sum)) * 500);
            //创建Brush对象，用于填充颜色
            Brush b1 = new SolidBrush(Color.White);
            Brush b2 = new SolidBrush(Color.Black);
            Brush b3 = new SolidBrush(Color.Blue);
            Brush b4 = new SolidBrush(Color.Yellow);
            Brush b5 = new SolidBrush(Color.Red);
            Brush b6 = new SolidBrush(Color.Green);
            //创建两个字体
            Font font1 = new Font("隶书", 30, FontStyle.Bold);
            Font font2 = new Font("楷体", 10);
            //绘制背景
            g.FillRectangle(b1, 0, 0, 775, 425);
            //绘制标题
            g.DrawString("投票结果", font1, b2, new Point(200, 20));
            Point p1 = new Point(180, 60);
            Point p2 = new Point(400, 60);
            g.DrawLine(new Pen(Color.Black), p1, p2);
            //候选实体字符串处理
            for (int i = 0; i < en.Length; i++)
            {
                if (en[i].Length < 10)
                {
                    string temp = en[i];
                    if (en[i].Length < 10)
                    {
                        en[i] = "";
                        for (int j = 0; j < 10 - temp.Length; j++)
                        {
                            en[i] += " ";
                        }
                        en[i] += temp;
                    }
                }
            }
            //绘制投票结果
            g.DrawString(en[0] + ":", font2, b2, 150, 80);
            g.FillRectangle(b3, 275, 80, tp1, 20);
            g.DrawString(en[1] + ":", font2, b2, 150, 120);
            g.FillRectangle(b4, 275, 120, tp2, 20);
            g.DrawString(en[2] + ":", font2, b2, 150, 160);
            g.FillRectangle(b5, 275, 160, tp3, 20);
            g.DrawString(en[3] + ":", font2, b2, 150, 200);
            g.FillRectangle(b6, 275, 200, tp4, 20);
            //绘制所有票数显示
            g.DrawRectangle(new Pen(Color.Black), 100, 240, 390, 90);
            g.DrawString(en[0] + "：" + ti[0], font2, b2, new PointF(120, 250));
            g.DrawString(en[1] + "：" + ti[1], font2, b2, new PointF(300, 250));
            g.DrawString(en[2] + "：" + ti[2], font2, b2, new PointF(120, 300));
            g.DrawString(en[3] + "：" + ti[3], font2, b2, new PointF(300, 300));
            pictureBox1.Image = bitmap;
        }
    }
}
