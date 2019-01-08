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
    public partial class FormGestaoDeSalas : Form
    {

        public static string file = "salas.txt";
        public FormGestaoDeSalas()
        {
            InitializeComponent();

            this.FormBorderStyle = 0;

            string[] importar = File.ReadAllLines(file);

            for (int i = 0; i < importar.Length; i++)
            {
                listBox1.Items.Add(importar[i]);
            }
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            string[] importar = File.ReadAllLines(file);

            for (int i = 0; i < importar.Length; i++)
            {
                if (importar[i] == textBox1.Text)
                {
                    MessageBox.Show("Sala já em uso.");
                    break;
                }
                else
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                }
            }
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            textBox1.Text = "";

            //Se nao existir um ficheiro...
            if (!File.Exists(file))
            {
                //Cria um novo ficheiro- file
                File.CreateText(file);
            }

            StreamWriter sw = File.CreateText(file);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                //Vai ser permitida a escrita na listbox1 e inserida no ficheiro- file
                sw.WriteLine(listBox1.Items[i]);
            }

            //fechar permição de leitura- após ciclo acabar
            sw.Close();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(file); ;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sw.WriteLine(listBox1.Items[i]);
            }
            sw.Close();
        }
    }
}
