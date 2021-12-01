using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Direction_BasicOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIsExsis_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                MessageBox.Show("该文件夹已经存在");
            }
            else
            {
                MessageBox.Show("不存在该文件夹");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox2.Text))
            {
                MessageBox.Show("该文件夹已经存在");
            }
            else
            {
                if (textBox2.Text == string.Empty)
                {
                    MessageBox.Show("路径不能为空");
                }
                else
                {
                    Directory.CreateDirectory(textBox2.Text);
                    MessageBox.Show(textBox2.Text + "已创建");
                }
            }
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != string.Empty && textBox4.Text != string.Empty)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(textBox3.Text);
                directoryInfo.MoveTo(textBox4.Text);
                MessageBox.Show("移动成功");
            }
            else
            {
                MessageBox.Show("路径不可为空");
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox5.Text))
            {
                Directory.Delete(textBox5.Text);
                MessageBox.Show(textBox5.Text + "已删除");
            }
            else
            {
                MessageBox.Show("不存在该文件夹");
            }
        }
    }
}
