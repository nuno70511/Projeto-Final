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
        public ServiçosDeInformatica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Irá esconder o InitialForm quando pressinar o button "Registar"
            this.Hide();
            //Quando pressionar "Registar" irá abrir o Form de registo- RegisterForm
            FormGerirSoftware formGerirSoftware = new FormGerirSoftware();
            formGerirSoftware.ShowDialog();
            //Irá voltar a mostrar o InitialForm quando o RegisterForm for fechado
            this.Show();
        }

        private void GestaoDeSalasButton_Click(object sender, EventArgs e)
        {
            //Irá esconder o InitialForm quando pressinar o button "Registar"
            this.Hide();
            //Quando pressionar "Registar" irá abrir o Form de registo- RegisterForm
            FormGestaoDeSalas formGestaoDeSalas = new FormGestaoDeSalas();
            formGestaoDeSalas.ShowDialog();
            //Irá voltar a mostrar o InitialForm quando o RegisterForm for fechado
            this.Show();
        }

        private void TopicosDeAssuntoButton_Click(object sender, EventArgs e)
        {
            //Irá esconder o InitialForm quando pressinar o button "Registar"
            this.Hide();
            //Quando pressionar "Registar" irá abrir o Form de registo- RegisterForm
            FormTopicosDeAssunto formTopicosDeAssunto = new FormTopicosDeAssunto();
            formTopicosDeAssunto.ShowDialog();
            //Irá voltar a mostrar o InitialForm quando o RegisterForm for fechado
            this.Show();
        }
    }
}
