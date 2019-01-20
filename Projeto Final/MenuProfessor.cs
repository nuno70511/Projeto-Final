using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class MenuProfessor : Form
    {
        string user;
        int perfil;

        public MenuProfessor(string user, int perfil)
        {
            InitializeComponent();

            this.FormBorderStyle = 0;

            this.user = user;
            this.perfil = perfil;

            textBox1.Text = user;

            /* Mensagem de boas-vindas */
            string mensagem = metodos.GerarBoasVindas(user);
            toolStripStatusLabel1.Text = mensagem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = ActiveForm;
            this.Hide();

            FormNotificaçoes fn = new FormNotificaçoes(user, perfil);
            fn.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            InitialForm ini = new InitialForm();
            ini.Show();
        }

        private void ExitRegisterButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = ActiveForm;
            this.Hide();

            FormEstadoDoPedido edp = new FormEstadoDoPedido(user, perfil);
            edp.Show();
        }
    }
}
