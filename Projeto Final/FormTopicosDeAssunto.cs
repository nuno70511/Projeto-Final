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
    public partial class FormTopicosDeAssunto : Form
    {
        string user;
        int perfil;

        string caminho = "assuntos.txt";
        int contAssunto = 0;

        public FormTopicosDeAssunto(string user, int perfil)
        {
            InitializeComponent();

            this.FormBorderStyle = 0;

            this.user = user;
            this.perfil = perfil;

            if (File.Exists(caminho))
            {
                string[] lerAssuntos = File.ReadAllLines(caminho);
                for (int i = 0; i < lerAssuntos.Length; i++)
                {
                    listBox1.Items.Add(lerAssuntos[i]);
                    contAssunto++;
                }
            }
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            string lerTxt = AssuntoTextBox.Text;

            StreamWriter sw;
            if (!File.Exists(caminho))
            {
                sw = File.CreateText(caminho);
            }
            else
            {
                sw = File.AppendText(caminho);
            }

            contAssunto++;
            string numAssunto = contAssunto.ToString("00");

            string novoAssunto = numAssunto + ";" + lerTxt;

            sw.WriteLine(novoAssunto);
            sw.Close();

            listBox1.Items.Add(novoAssunto);
        }

        private void RetrocederButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            variaveis.CurrentForm.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();

            InitialForm ini = new InitialForm();
            ini.Show();
        }

        private void RetrocederButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            variaveis.CurrentForm.Show();
        }

        private void LogOutButton_Click_1(object sender, EventArgs e)
        {
            this.Close();

            InitialForm ini = new InitialForm();
            ini.Show();
        }
    }
}
