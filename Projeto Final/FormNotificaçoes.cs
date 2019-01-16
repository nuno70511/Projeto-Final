using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class FormNotificaçoes : Form
    {
        string user;

        public FormNotificaçoes(string user)
        {
            InitializeComponent();

            this.FormBorderStyle = 0;
            
            this.user = user;

            /* Carregar comboBoxs */
            string fichSalas = "salas.txt";
            if (File.Exists(fichSalas))
            {
                StreamReader sr = File.OpenText(fichSalas);
                string ln = "";
                while ((ln = sr.ReadLine()) != null)
                {
                    SalaComboBox.Items.Add(ln);
                }
                sr.Close();
            }

            string fichAssuntos = "assuntos.txt";
            if (File.Exists(fichAssuntos))
            {
                StreamReader sr = File.OpenText(fichAssuntos);
                string ln = "";
                while ((ln = sr.ReadLine()) != null)
                {
                    string[] split = ln.Split(';');
                    AssuntoComboBox.Items.Add(split[1]);
                }
                sr.Close();
            }


            /* Mensagem de boas-vindas */
            string data = DateTime.Now.ToString("dd-MM-yyyy");
            string hora = DateTime.Now.ToString("HH:mm");

            string boasVindas;
            int h = DateTime.Now.Hour;
            if (h < 5 || h > 19)
            {
                boasVindas = "Boa noite";
            }
            else if (h < 11)
            {
                boasVindas = "Bom dia";
            }
            else
            {
                boasVindas = "Boa tarde";
            }

            string mensagem = boasVindas + ", " + user + "! " + data + " as " + hora;
            StatusLabel.Text = mensagem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fichNotif = "notificaçoes.txt";

            /* Verificar se os campos de entrada estao preenchidos */
            if (SalaComboBox.Text == "")
            {
                StatusLabel.Text = "Nao foi indicada uma sala.";
            }
            else if (AssuntoComboBox.Text == "")
            {
                StatusLabel.Text = "Nao foi indicado nenhum assunto.";
            }
            else if (ComentarioTextBox.Text == "")
            {
                StatusLabel.Text = "Por favor, especifique o seu problema.";
            }


            StreamWriter sw;

            if (!File.Exists(fichNotif))
            {
                sw = File.CreateText(fichNotif);
            }
            else
            {
                sw = File.AppendText(fichNotif);
            }


            /* Dados a armazenar no ficheiro (excepto variavel global user) */
            string sala = SalaComboBox.Text;
            string comentario = ComentarioTextBox.Text;
            int indiceAssunto = Convert.ToInt16(AssuntoComboBox.SelectedIndex) + 1; /* Associar o assunto escolhido a um indice */
            string assunto = indiceAssunto.ToString("00");
            string data = DateTime.Now.ToString("yyyy/MM/dd");
            string hora = DateTime.Now.ToString("HH:mm");
            string estado = "Pendente";

            sw.WriteLine(user + ';' + sala + ';' + assunto + ';' + comentario + ';' + data + ';' + hora + ';' + estado);

            sw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            variaveis.CurrentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            InitialForm ini = new InitialForm();
            ini.Show();
        }
    }
}
