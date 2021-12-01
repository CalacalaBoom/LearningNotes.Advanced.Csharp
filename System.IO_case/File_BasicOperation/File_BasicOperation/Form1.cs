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

namespace File_BasicOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void btnIsExists_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox2.Text))
            {
                MessageBox.Show("该文件已经存在");
            }
            else
            {
                MessageBox.Show("该文件不存在");
            }
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(textBox3.Text))
            {
                MessageBox.Show("该文件已经存在");
            }
            else
            {
                File.Create(textBox3.Text);
                MessageBox.Show(textBox3.Text + "已创建");
            }
        }

        private void btnCopyTo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请先选择要复制的文件");
            }
            else
            {
                if (File.Exists(textBox1.Text))
                {
                    File.Copy(textBox1.Text, textBox4.Text);
                    MessageBox.Show("拷贝成功");
                }
                else
                {
                    MessageBox.Show("该文件不存在");
                }
            }
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请先选择要移动的文件");
            }
            else
            {
                if (File.Exists(textBox1.Text))
                {
                    File.Move(textBox1.Text, textBox5.Text);
                    MessageBox.Show("移动成功");
                }
                else
                {
                    MessageBox.Show("该文件不存在");
                }
            }
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            FileInfo finfo = new FileInfo(textBox1.Text);
            string strCTime = finfo.CreationTime.ToString();
            string strLATime = finfo.LastAccessTime.ToString();
            string strLWTime = finfo.LastWriteTime.ToString();
            string strName = finfo.Name;
            string strFName = finfo.FullName;
            string strDName = finfo.DirectoryName;
            string strISRead = finfo.IsReadOnly.ToString();
            long strLength = finfo.Length;
            MessageBox.Show("----------文件信息----------" +
                "\n创建时间：" + strCTime +
                "\n上次访问该文件时间：" + strLATime +
                "\n上次写入该文件时间：" + strLWTime +
                "\n文件名：" + strName +
                "\n文件的完整目录：" + strFName +
                "\n文件的完整路径：" + strDName +
                "\n文件是否只读：" + strISRead +
                "\n文件的长度：" + strLength);
        }
    }
}
