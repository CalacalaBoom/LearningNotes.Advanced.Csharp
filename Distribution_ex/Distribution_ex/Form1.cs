using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribution_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                account ac = new account();
                int M = int.Parse(textBox1.Text);
                int N = int.Parse(textBox2.Text);
                string str = comboBox1.Text;
                switch (str)
                {
                    case "加": textBox3.Text = ac.add(M, N).ToString(); break;
                    case "减": textBox3.Text = ac.sub(M, N).ToString(); break;
                    case "乘": textBox3.Text = ac.mul(M, N).ToString(); break;
                    case "除": textBox3.Text = ac.div(M, N).ToString(); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    partial class account
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
    partial class account
    {
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    partial class account
    {
        public int mul(int a, int b)
        {
            return a * b;
        }
    }
    partial class account
    {
        public int div(int a, int b)
        {
            return a / b;
        }
    }
}
