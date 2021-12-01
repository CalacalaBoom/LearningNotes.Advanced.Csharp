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

namespace TraverseFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                DirectoryInfo directoryInfo = new DirectoryInfo(textBox1.Text);
                FileSystemInfo[] fsinfos = directoryInfo.GetFileSystemInfos();
                foreach (FileSystemInfo f in fsinfos)
                {
                    if (f is DirectoryInfo)
                    {
                        DirectoryInfo df = new DirectoryInfo(f.FullName);
                        listView1.Items.Add(df.Name);
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(df.FullName);
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add("null");
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(df.CreationTime.ToShortDateString());
                    }
                    else
                    {
                        FileInfo ff = new FileInfo(f.FullName);
                        listView1.Items.Add(ff.Name);
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(ff.FullName);
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add((ff.Length/8/1024).ToString()+"KB");
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(ff.CreationTime.ToShortDateString());
                    }
                }
            }
        }
    }
}
