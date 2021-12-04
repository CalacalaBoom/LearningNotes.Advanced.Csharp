using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployOfGDI_
{
    public partial class ProductionData : Form
    {
        public ProductionData()
        {
            InitializeComponent();
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text + "厂" + textBox2.Text + "产品月生产量图表";
            float[] productions = new float[12] { Convert.ToSingle(txt1.Text),
                                                Convert.ToSingle(txt2.Text),
                                                Convert.ToSingle(txt3.Text),
                                                Convert.ToSingle(txt4.Text),
                                                Convert.ToSingle(txt5.Text),
                                                Convert.ToSingle(txt6.Text),
                                                Convert.ToSingle(txt7.Text),
                                                Convert.ToSingle(txt8.Text),
                                                Convert.ToSingle(txt9.Text),
                                                Convert.ToSingle(txt10.Text),
                                                Convert.ToSingle(txt11.Text),
                                                Convert.ToSingle(txt12.Text)};
            DrawLineChart drawLCFrom = new DrawLineChart(title, productions);
            drawLCFrom.Show();
        }
    }
}
