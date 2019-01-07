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
        //Nome do ficheiro que será criado
        public string file = "assuntos.txt";
        //Variavel lines que "irá representar" todo o conteúdo do ficheiro
        public string[] lines;
        StreamReader sr;

        public FormNotificaçoes()
        {
            InitializeComponent();

            //Aparecer a data de hoje na TextBox da Hora- DatatextBox
            DataTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Aparacer hora do dia de hoje na textBox6
            HoraTextBox.Text = DateTime.Now.ToString("HH:mm:ss");

            //Aparacer estado Pendente na textbox7
            EstadoTextBox.Text = "Pendente";

            if (File.Exists(file))
            {
                lines = File.ReadAllLines(file);
            }

            for (int i = 0; i < lines.Length; i++)
            {
                ComboBoxItems item = new ComboBoxItems();

                string[] split = lines[i].Split(';');
                item.Numero = split[0];
                item.Titulo = split[1];

                AssuntoComboBox.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file2 = "notificaçoes.txt";

            StreamWriter sw = File.AppendText(file2);

            if (!File.Exists(file2))
            {
                File.CreateText(file2);
            }

            sw.WriteLine(textBox1.Text + ";" + SalaTextBox.Text + ";" + AssuntoComboBox.Text + ";" + ComentarioTextBox.Text + ";" + DataTextBox.Text + ";" + HoraTextBox.Text + ";" + EstadoTextBox.Text);

            sw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
