using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Final
{
    public partial class FormEstadoDoPedido : Form
    {
        string user;

        public FormEstadoDoPedido(string user)
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
                    SalasComboBox.Items.Add(ln);
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
                    string[] dados = ln.Split(';');
                    AssuntoComboBox.Items.Add(dados[1]);
                }
                sr.Close();
            }
        }

        private void PesquisaBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string fichNotif = "notificaçoes.txt";

            if (File.Exists(fichNotif))
            {
                StreamReader sr = File.OpenText(fichNotif);
                string ln = "";
                while ((ln = sr.ReadLine()) != null)
                {
                    string[] dados = ln.Split(';');

                    /*
                     * Indices:
                     * 0. user              4. data
                     * 1. sala              5. hora
                     * 2. assunto           6. estado
                     * 3. comentario        7. resposta
                     * 
                     */

                    if (dados[0] == user)
                    {
                        if ((checkBox1.Checked == true && checkBox2.Checked == false && dados[6] == "Pendente") 
                            || (checkBox1.Checked == false && checkBox2.Checked == true && dados[6] == "Concluido")
                            || (checkBox1.Checked == true && checkBox2.Checked == true))
                        {
                                /* Ambas as comboBox NAO aplicarem filtros */
                            if ((SalasComboBox.Text == SalasComboBox.Items[0].ToString() && AssuntoComboBox.Text == AssuntoComboBox.Items[0].ToString())
                                /* Aplicar apenas filtro de salas */
                                || (SalasComboBox.Text != SalasComboBox.Items[0].ToString() && dados[1] == SalasComboBox.Text) && (AssuntoComboBox.Text == AssuntoComboBox.Items[0].ToString())
                                /* Aplicar apenas filtro de assuntos */
                                || (AssuntoComboBox.Text != AssuntoComboBox.Items[0].ToString() && dados[2] == AssuntoComboBox.Text) && (SalasComboBox.Text == SalasComboBox.Items[0].ToString())
                                /* Ambas as comboBox aplicarem filtros */
                                || (SalasComboBox.Text != SalasComboBox.Items[0].ToString() && dados[1] == SalasComboBox.Text) && (AssuntoComboBox.Text != AssuntoComboBox.Items[0].ToString() && dados[2] == AssuntoComboBox.Text))
                            {
                                dataGridView1.Rows.Insert(0, dados[6], dados[3], dados[7], dados[2], dados[1], dados[4], dados[5]);
                            }
                        }
                    }
                }

                sr.Close();
            }
        }

        private void ExitRegisterButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
