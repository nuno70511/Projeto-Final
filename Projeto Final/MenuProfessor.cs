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

        public MenuProfessor(string user)
        {
            InitializeComponent();

            this.FormBorderStyle = 0;

            this.user = user;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form CurrentForm = Form.ActiveForm;
            this.Hide();

            FormNotificaçoes fn = new FormNotificaçoes(user);
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
            Form CurrentForm = Form.ActiveForm;
            this.Hide();

            FormEstadoDoPedido edp = new FormEstadoDoPedido(user);
            edp.Show();
        }
    }
}
