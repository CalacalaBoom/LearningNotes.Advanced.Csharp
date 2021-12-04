using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployOfGDI_
{
    public partial class PieData : Form
    {
        public PieData()
        {
            InitializeComponent();
        }

        private void btnDrawPie_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSum.Text) < Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text) + Convert.ToInt32(txt3.Text))
            {
                MessageBox.Show("输入错误");
            }
            else
            {
                DrawPie pieForm = new DrawPie(Convert.ToInt32(txtSum.Text), Convert.ToInt32(txt1.Text), Convert.ToInt32(txt2.Text), Convert.ToInt32(txt3.Text));
                pieForm.Show();
            }
        }
    }
}
