using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Irá esconder o InitialForm quando pressinar o button "Registar"
            this.Hide();
            //Quando pressionar "Registar" irá abrir o Form de registo- RegisterForm
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            //Irá voltar a mostrar o InitialForm quando o RegisterForm for fechado
            this.Show();
        }

        private void ExitRegisterButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = UserTextBox.Text;
            string pw = PwTextBox.Text;

            Users login = new Users(user, pw);

            if (login.Login() == 1)
            {
                MessageBox.Show("Sessao iniciada com sucesso.");
            }
            else if (login.Login() == 0)
            {
                MessageBox.Show("A password esta errada.");
            }
            else
            {
                MessageBox.Show("A conta nao existe.");
            }
        }
    }
}
