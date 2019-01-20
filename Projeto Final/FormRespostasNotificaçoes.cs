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
    public partial class FormRespostasNotificaçoes : Form
    {
        string user;
        int perfil;

        string docente;
        string sala;
        string assunto;
        string comentario;
        string data;
        string hora;
        string estado;
        string resposta;
        int indice;

        public FormRespostasNotificaçoes(string user, int perfil, string docente, string sala, string assunto, string comentario, string data, string hora, string estado, string resposta, string indice)
        {
            InitializeComponent();

            this.FormBorderStyle = 0;

            this.user = user;
            this.perfil = perfil;

            this.docente = docente;
            this.sala = sala;
            this.assunto = assunto;
            this.comentario = comentario;
            this.data = data;
            this.hora = hora;
            this.estado = estado;
            this.resposta = resposta;
            this.indice = Convert.ToInt16(indice);

            /* Carregar interface */
            nomeDocente.Text = docente;
            textoSala.Text = sala;
            textoAssunto.Text = assunto;
            valorData.Text = data;
            valorHora.Text = hora;
            valorEstado.Text = estado;

            if (perfil == 2)
            {
                label4.Text = "Resposta:";
                label1.Text = "Comentario:";
                button1.Text = "Enviar novo comentario";
                textBox2.Text = resposta;
            }
            else
            {
                textBox2.Text = comentario;
            }
        }

        private void RetrocederButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string envio = RespostaTextBox.Text;

            string ln;
            if (perfil == 2)
            {
                ln = docente + ';' + sala + ';' + assunto + ';' + envio + ';' + data + ';' + hora + ';' + estado + ';' + resposta;
            }
            else
            {
                ln = docente + ';' + sala + ';' + assunto + ';' + comentario + ';' + data + ';' + hora + ';' + estado + ';' + envio;
            }

            string fileNotif = "notificaçoes.txt";
            string[] lerNotif = File.ReadAllLines(fileNotif);

            StreamWriter sw = File.CreateText("temp2.txt");
            for (int i = 0; i < lerNotif.Length; i++)
            {
                if (lerNotif[i] == lerNotif[indice])
                {
                    sw.WriteLine(ln);
                }
                else
                {
                    sw.WriteLine(lerNotif[i]);
                }
            }
            sw.Close();

            File.Delete(fileNotif);
            File.Move("temp2.txt", fileNotif);

            this.Close();
        }
    }
}
