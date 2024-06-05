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


namespace ProjetoBarbearia
{
    public partial class LoginSenha : Form
    {
        Thread nova_thread;
        public LoginSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validação de login e senha.
            if (textBox1.Text == "adm" && textBox2.Text == "adm") 
            {
                this.Close();
                nova_thread = new Thread(novoForm);
                nova_thread.SetApartmentState(ApartmentState.STA); //selecionando uma thread apenas (sta)
                nova_thread.Start();
            }
            else
            {
                MessageBox.Show("Login ou Senha inválidos!");
            }

            

        }

        private void novoForm()
        {
            Application.Run(new telaprincipal()); // instanciando nova thread
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
