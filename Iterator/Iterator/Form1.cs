using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Family : IEnumerable
        {
            string[] myFamily = new string[] { "大哥", "二哥", "三姐", "俺", "小妹", "老爹", "老娘", "大爷", "小姑", "爷", "奶" };
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < myFamily.Length; i++)
                {
                    yield return myFamily[i];
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Family family = new Family();
            foreach (string str in family)
            {
                richTextBox1.Text += str + "\n";
            }
        }
    }
}
