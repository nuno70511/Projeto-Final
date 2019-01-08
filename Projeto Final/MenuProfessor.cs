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
        public MenuProfessor()
        {
            InitializeComponent();

            this.FormBorderStyle = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Irá esconder o MenuProfessor quando pressinar o button "Notificações"
            this.Hide();
            //Quando pressionar "Notificações" irá abrir o Form das notificações- FormNotificaçoes
            FormNotificaçoes formNotificaçoes = new FormNotificaçoes();
            formNotificaçoes.ShowDialog();
            //Irá voltar a mostrar o MenuProfessor quando o FormNotificaçoes for fechado
            this.Show();
        }
    }
}
