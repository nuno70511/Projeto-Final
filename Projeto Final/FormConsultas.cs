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
    public partial class FormConsultas : Form
    {
        public static string file = "salas.txt";
        public string caminho = @"salas\";

        public FormConsultas()
        {
            InitializeComponent();

            string[] importar = File.ReadAllLines(file);

            for (int i = 0; i < importar.Length; i++)
            {
                listBox1.Items.Add(importar[i]);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string ficheiro = caminho + listBox1.SelectedItem + ".txt";

            if (File.Exists(ficheiro))
            {
                string[] read = File.ReadAllLines(ficheiro);

                dataGridView1.Rows.Clear();

                for (int i = 0; i < read.Length; i++)
                {
                    string[] split = read[i].Split(';');

                    string software = split[0];
                    string data = split[1];
                    string hora = split[2];
                    string tipoLicença = split[3];

                    dataGridView1.Rows.Add(software, data, hora, tipoLicença);
                }
            }
            else
            {
                MessageBox.Show("Não existem dados a apresentar.");
            }
        }
    }
}
