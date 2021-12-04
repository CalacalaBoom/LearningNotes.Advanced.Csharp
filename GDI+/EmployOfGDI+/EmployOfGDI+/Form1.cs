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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBarC_Click(object sender, EventArgs e)
        {
            BarCForm barCForm = new BarCForm();
            barCForm.Show();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            ProductionData produForm = new ProductionData();
            produForm.Show();
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            PieData pieDForm = new PieData();
            pieDForm.Show();
        }
    }
}
