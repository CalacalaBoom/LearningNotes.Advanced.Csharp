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

namespace IPAdress_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入域名");
            }
            else
            {
                IPAddress[] ips = Dns.GetHostAddresses(textBox1.Text);
                foreach (IPAddress i in ips)
                {
                    label2.Text = "网际协议地址：" + i.Address + "\nIP地址的地址族：" 
                        + i.AddressFamily.ToString() + "\n是否是IPv6链路本地地址：" + i.IsIPv6LinkLocal;
                }
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
        }
    }
}
