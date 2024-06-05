using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBarbearia
{
    public partial class planos : Form
    {
        public planos()
        {
            InitializeComponent();
        }

        private void planos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plano89 formplanos89 = new plano89();
            formplanos89.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plano109 formplanos109 = new plano109();
            formplanos109.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            planos129 formplanos129 = new planos129();
            formplanos129.ShowDialog();
        }
    }
}
