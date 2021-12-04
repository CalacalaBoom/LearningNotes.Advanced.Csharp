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
    public partial class DrawLineChart : Form
    {
        string[] month = new string[12] { "一月", "二月", "三月", "四月", "五月", "六月",
            "七月", "八月", "九月", "十月", "十一月", "十二月", };
        string titleName;
        float[] pro;
        public DrawLineChart()
        {
            InitializeComponent();
        }

        public DrawLineChart(string title,float[] productions)
        {
            InitializeComponent();
            titleName = title;
            pro = productions;
        }

        private void DrawLineChart_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(494, 425);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            //定义字体
            Font font1 = new Font("黑体", 10, FontStyle.Bold);
            Font font2 = new Font("宋体", 8);
            //定义brush
            Brush b = new SolidBrush(Color.Black);
            //绘制标题
            g.DrawString(titleName, font1,b,80,20);
            //绘制三角形
            PointF cPt = new PointF(30, 300);//坐标轴原点
            PointF[] xPt = new PointF[3] { new PointF(cPt.Y,cPt.Y-8),
                                           new PointF(cPt.Y,cPt.Y+8),
                                           new PointF(cPt.Y+15,cPt.Y) };
            PointF[] yPt = new PointF[3] { new PointF(cPt.X-8,cPt.X),
                                           new PointF(cPt.X+8,cPt.X),
                                           new PointF(cPt.X,cPt.X-15) };
            g.DrawPolygon(Pens.Black, xPt);
            g.FillPolygon(b, xPt);
            g.DrawPolygon(Pens.Black, yPt);
            g.FillPolygon(b, yPt);
            //绘制y轴
            g.DrawString("单位(万)", font2, b, 0, 0);
            g.DrawLine(Pens.Black, 30, 30, 30, 300);
            //绘制x轴
            g.DrawString("月份", font2, b, 320,310);
            g.DrawLine(Pens.Black, 300, 300, 30, 300);
            //绘制折线图
            for (int i = 0; i < 12; i++)
            {
                //画刻度
                if (i < 10)
                {
                    g.DrawString(((i + 1) * 10).ToString(), font2, b, cPt.X - 25,
                        cPt.Y - (i + 1) * 24 - 4);
                    g.DrawLine(Pens.Black, new PointF(cPt.X - 4, cPt.Y - (i + 1) * 24),
                        new PointF(cPt.X, cPt.Y - (i + 1) * 24));
                }
                //画月份
                g.DrawString(month[i].Substring(0, 1), font2, b, cPt.X + (i + 1) * 20 - 4, cPt.Y + 5);
                g.DrawString(month[i].Substring(1, 1), font2, b, cPt.X + (i + 1) * 20 - 4, cPt.Y + 18);
                if (month[i].Length > 2)
                {
                    g.DrawString(month[i].Substring(2, 1), font2, b, cPt.X + (i + 1) * 20 - 4, cPt.Y + 31);
                }
                //画点
                g.DrawEllipse(Pens.Black, cPt.X + (i + 1) * 20 - 1.5F, cPt.Y - (pro[i] / 10F) * 24F - 1.5F, 3, 3);
                g.FillEllipse(b, cPt.X + (i + 1) * 20 - 1.5F, cPt.Y - (pro[i] / 10F) * 24F - 1.5F, 3, 3);
                //画数值
                g.DrawString(pro[i].ToString(), font2, b, new PointF(cPt.X + (i + 1) * 20, cPt.Y - (pro[i] / 10F) * 24F));
                //画折线
                if (i > 0)
                {
                    g.DrawLine(Pens.Black, new PointF(cPt.X + i * 20, cPt.Y - (pro[i - 1] / 10F) * 24F), 
                        new PointF(cPt.X + (i + 1) * 20, cPt.Y - (pro[i] / 10F) * 24F));
                }
                
            }

            pictureBox1.Image = bitmap;
        }
    }
}
