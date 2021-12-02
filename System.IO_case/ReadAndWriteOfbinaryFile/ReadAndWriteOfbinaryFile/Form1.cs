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

namespace ReadAndWriteOfbinaryFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "二进制文件(*.dat)|*.dat";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = string.Empty;
                FileStream filestream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader myRead = new BinaryReader(filestream);
                if (myRead.PeekChar() != -1)
                {
                    textBox1.Text = Convert.ToString(myRead.ReadInt32());
                }
                myRead.Close();
                filestream.Close();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("要写入的内容不能为空");
            }
            else
            {
                saveFileDialog1.Filter = "二进制文件(*.dat)|*.dat";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream filestream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryWriter binarywriter = new BinaryWriter(filestream);
                    binarywriter.Write(textBox1.Text);
                    binarywriter.Close();
                    filestream.Close();
                    textBox1.Text = string.Empty;
                }
            }
        }
    }
}
