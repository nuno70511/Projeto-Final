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
    public partial class FormPerfis : Form
    {
        public FormPerfis()
        {
            InitializeComponent();
        }

        private void GestaoDeSalasButton_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = ActiveForm;
            this.Hide();

            RegisterForm rf = new RegisterForm();
            rf.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();

            InitialForm ini = new InitialForm();
            ini.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = ActiveForm;
            this.Hide();

            FormGerirPerfis fgp = new FormGerirPerfis();
            fgp.Show();
        }
    }
}
