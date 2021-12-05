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

namespace DNS_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入域名");
            }
            else
            {
                txtIP.Text = string.Empty;
                IPAddress[] ips = Dns.GetHostAddresses(textBox1.Text);
                foreach (IPAddress ip in ips)
                {
                    txtIP.Text = ip.ToString();
                }
                txtThisName.Text = Dns.GetHostName();
                txtDNSName.Text = Dns.GetHostByName(Dns.GetHostName()).HostName;
            }
        }
    }
}
