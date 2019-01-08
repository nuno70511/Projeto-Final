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
        public string file = "assuntos.txt";

        public FormNotificaçoes()
        {
            InitializeComponent();

            this.FormBorderStyle = 0;

            //Aparecer a data de hoje na TextBox da Hora- DatatextBox
            DataTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Aparacer hora do dia de hoje na textBox6
            HoraTextBox.Text = DateTime.Now.ToString("HH:mm:ss");

            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);

                for (int i = 0; i < lines.Length; i++)
                {
                    ComboBoxItemsAssunto item = new ComboBoxItemsAssunto();

                    string[] split = lines[i].Split(';');
                    item.Numero = split[0];
                    item.Titulo = split[1];

                    AssuntoComboBox.Items.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file2 = "notificaçoes.txt";

            StreamWriter sw;

            if (!File.Exists(file2))
            {
                sw = File.CreateText(file2);
            }
            else
            {
                sw = File.AppendText(file2);
            }

            string estado = "pendente";

            sw.WriteLine(SalaTextBox.Text + ";" + AssuntoComboBox.Text + ";" + ComentarioTextBox.Text + ";" + DataTextBox.Text + ";" + HoraTextBox.Text + ";" + estado);

            sw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
