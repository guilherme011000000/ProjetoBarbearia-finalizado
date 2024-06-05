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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;          
namespace ProjetoBarbearia

{
    public partial class agendamentos : Form

    {
        
        ArrayList array_agendamentos = new ArrayList();
        public agendamentos()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  
        {
            // Botão adicionar (nome e hora a lista).

            string cortes = nomehorario.Text;
            array_agendamentos.Add(cortes);
            nomehorario.Text = "";

            string cortesII = comboBox1.Text;
            array_agendamentos.Add(cortesII);
            MessageBox.Show("Atendimento Agendado");
            comboBox1.Text = "";


            listaagenda.Items.Clear(); // Para os itens não ser duplicados.

            foreach (string item in array_agendamentos)
            {
                listaagenda.Items.Add(item);
            }

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
          // remover apenas o item selecionado.
        {
            if (listaagenda.SelectedIndex != -1)
            {
                string Removeritens = listaagenda.SelectedItem.ToString();
                listaagenda.Items.Remove(listaagenda.SelectedItem);
                array_agendamentos.Remove(Removeritens); // Remover da ArrayList. 
            }
            else
            {
                MessageBox.Show("Clique no nome que deseja remover!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        // botão remover aparecer somente junto com a listbox
        {
            remover.Visible = true; 
            listaagenda.Visible = true;
        }

        private void barbeiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void nomehorario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
