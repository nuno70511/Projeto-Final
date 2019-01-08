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
        string caminho = "assuntos.txt";
        int contAssunto = 0;

        public FormTopicosDeAssunto()
        {
            InitializeComponent();

            this.FormBorderStyle = 0;

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
    }
}
