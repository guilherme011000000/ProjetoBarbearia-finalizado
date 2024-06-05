using System;
using System.Collections;
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
    public partial class telaprincipal : Form
    {
        ArrayList agendamentos = new ArrayList();
        public telaprincipal()
        { 
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void telaprincipal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            agendamentos form_agendamentos = new agendamentos();
            form_agendamentos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            planos form_planos = new planos();  
            form_planos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
