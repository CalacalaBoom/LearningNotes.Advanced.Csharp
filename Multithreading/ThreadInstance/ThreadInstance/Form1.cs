using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadInstance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strInfo = String.Empty;
            Thread mythread = new Thread(new ThreadStart(threadOut));
            mythread.Start();
            //获取线程相关信息
            strInfo = "线程唯一标识符：" + mythread.ManagedThreadId;
            strInfo += "\n线程名称:" + mythread.Name;
            strInfo += "\n线程状态：" + mythread.ThreadState.ToString();
            //strInfo += "\n线程优先级：" + mythread.Priority.ToString();
            strInfo += "\n是否为后台进程：" + mythread.IsBackground.ToString();
            Thread.Sleep(1000);
            mythread.Abort("退出");
            mythread.Join();
            MessageBox.Show("线程运行结束");
            richTextBox1.Text = strInfo;
        }
        public void threadOut()
        {
            MessageBox.Show("主线程已经开始");
        }
    }
}
