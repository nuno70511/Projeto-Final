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
    public partial class ServiçosDeInformatica : Form
    {
        string user;
        int perfil;

        public ServiçosDeInformatica(string user, int perfil)
        {
            InitializeComponent();

            this.FormBorderStyle = 0;

            this.user = user;
            this.perfil = perfil;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = ActiveForm;
            this.Hide();

            FormGerirSoftware gs = new FormGerirSoftware(user, perfil);
            gs.Show();
        }

        private void GestaoDeSalasButton_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = ActiveForm;
            this.Hide();

            FormGestaoDeSalas gds = new FormGestaoDeSalas(user, perfil);
            gds.Show();
        }

        private void TopicosDeAssuntoButton_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = ActiveForm;
            this.Hide();

            FormTopicosDeAssunto tda = new FormTopicosDeAssunto(user, perfil);
            tda.Show();
        }

        private void ConsultasButton_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = ActiveForm;
            this.Hide();

            FormConsultas c = new FormConsultas(user, perfil);
            c.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();

            InitialForm ini = new InitialForm();
            ini.Show();
        }
    }
}
