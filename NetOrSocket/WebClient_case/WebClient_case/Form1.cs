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
using System.IO;

namespace WebClient_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "http://";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "http://")
            {
                MessageBox.Show("请输入网址");
            }
            else
            {
                richTextBox1.Text = string.Empty;
                WebClient webc = new WebClient();
                webc.BaseAddress = textBox1.Text;
                webc.Encoding = Encoding.UTF8;
                webc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                Stream stream = webc.OpenRead(textBox1.Text);
                StreamReader sread = new StreamReader(stream);
                string str = string.Empty;
                while ((str=sread.ReadLine())!=null)
                {
                    richTextBox1.Text += str + "\n";
                }
            }
        }
    }
}
