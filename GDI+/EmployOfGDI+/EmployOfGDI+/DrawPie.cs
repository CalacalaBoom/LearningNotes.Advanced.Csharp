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
    public partial class DrawPie : Form
    {
        private int NofS;
        private int Nof20;
        private int Nof26;
        private int Nof31;
        private int other;
        public DrawPie()
        {
            InitializeComponent();
        }

        public DrawPie(int sum,int n1,int n2,int n3)
        {
            NofS = sum;
            Nof20 = n1;
            Nof26 = n2;
            Nof31 = n3;
            other = NofS - Nof20 - Nof26 - n3;
            InitializeComponent();
        }

        private void DrawPie_Load(object sender, EventArgs e)
        {
            other = NofS - Nof20 - Nof26 - Nof31;
            Bitmap bitmap = new Bitmap(464,425);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            //设置字体
            Font font1 = new Font("黑体", 15, FontStyle.Bold);
            Font font2 = new Font("宋体", 5);
            //设置Brush
            Brush b1 = new SolidBrush(Color.Black);
            Brush b2 = new SolidBrush(Color.Blue);
            Brush b3 = new SolidBrush(Color.Orange);
            Brush b4 = new SolidBrush(Color.Wheat);
            Brush b5 = new SolidBrush(Color.WhiteSmoke);
            //绘制标题
            g.DrawString("公司员工年龄比例饼状图", font1, b1, 50, 10);
            //分配角度
            float ang1 = Convert.ToSingle((360 / Convert.ToSingle(NofS)) * Convert.ToSingle(Nof20));
            float ang2 = Convert.ToSingle((360 / Convert.ToSingle(NofS)) * Convert.ToSingle(Nof26));
            float ang3 = Convert.ToSingle((360 / Convert.ToSingle(NofS)) * Convert.ToSingle(Nof31));
            float ang4 = Convert.ToSingle((360 / Convert.ToSingle(NofS)) * Convert.ToSingle(other));
            //绘制饼状图
            g.FillPie(b2, 90, 40, 150, 150, 0, ang1);
            g.FillPie(b3, 90, 40, 150, 150, ang1, ang2);
            g.FillPie(b4, 90, 40, 150, 150, ang1+ang2, ang3);
            g.FillPie(b5, 90, 40, 150, 150, ang1 + ang2 + ang3, ang4);
            //绘制标识
            g.DrawRectangle(Pens.Black, 50, 200, 230, 130);
            g.FillRectangle(b2, 60, 210, 50, 20);
            g.DrawString("20~25岁员工占公司总人数比例：" +
                Convert.ToSingle(Nof20) * 100 / Convert.ToSingle(NofS) + "%", font2, b1, 120, 215);
            g.FillRectangle(b3, 60, 240, 50, 20);
            g.DrawString("26~30岁员工占公司总人数比例：" +
                Convert.ToSingle(Nof26) * 100 / Convert.ToSingle(NofS) + "%", font2, b1, 120, 245);
            g.FillRectangle(b4, 60, 270, 50, 20);
            g.DrawString("31~40岁员工占公司总人数比例：" +
                Convert.ToSingle(Nof31) * 100 / Convert.ToSingle(NofS) + "%", font2, b1, 120, 275);
            g.FillRectangle(b5, 60, 300, 50, 20);
            g.DrawString("其他年龄员工占公司总人数比例：" +
                Convert.ToSingle(other) * 100 / Convert.ToSingle(NofS) + "%", font2, b1, 120, 305);
            pictureBox1.Image = bitmap;
        }
    }
}
