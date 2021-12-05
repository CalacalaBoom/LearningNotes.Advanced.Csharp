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
                
            }
        }
    }
}
