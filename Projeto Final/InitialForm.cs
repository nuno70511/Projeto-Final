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
            this.FormBorderStyle = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = ActiveForm;
            this.Hide();

            RegisterForm rf = new RegisterForm();
            rf.Show();
        }

        private void ExitRegisterButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = UserTextBox.Text;
            string pw = PwTextBox.Text;

            Users login = new Users(user, pw);

            int sessao = login.Login();

            if (sessao >= 0)
            {
                variaveis.CurrentForm = Form.ActiveForm;
                this.Hide();

                login.Sessao(sessao);
            }
            else if (sessao == -1)
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
