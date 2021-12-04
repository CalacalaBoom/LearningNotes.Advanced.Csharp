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
    public partial class BarCForm : Form
    {
        public BarCForm()
        {
            InitializeComponent();
        }

        private void btnDrawBC_Click(object sender, EventArgs e)
        {
            string[] en = { txtEntity1.Text, txtEntity2.Text, txtEntity3.Text, txtEntity4.Text };
            int[] ti = { int.Parse(txtTicket1.Text), int.Parse(txtTicket2.Text),
                int.Parse(txtTicket3.Text),int.Parse(txtTicket4.Text)};
            DrawBCForm drawBCForm = new DrawBCForm(en,ti);
            drawBCForm.Show();
        }
    }
}
