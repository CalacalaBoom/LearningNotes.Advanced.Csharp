using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IPEndPoint_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入IP地址");
            }
            else
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), 80);
                label2.Text = "IP地址：" + ipep.Address.ToString() + "\n端口号：" + ipep.Port;
            }
            

        }
    }
}
