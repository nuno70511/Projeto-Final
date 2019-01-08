﻿using System;
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
    public partial class FormGerirSoftware : Form
    {
        public string caminho = @"salas\";

        public FormGerirSoftware()
        {
            InitializeComponent();

            if (!Directory.Exists("salas"))
            {
                Directory.CreateDirectory("salas");
            }

            string[] salas = Directory.GetFiles("salas");
            for (int i = 0; i < salas.Length; i++)
            {
                SalaComboBox.Items.Clear();
                SalaComboBox.Items.Add(salas[i]);
            }
        }

        private void RegistarButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string ficheiro = caminho + SalaComboBox.Text + ".txt";

            StreamWriter sw;

            if (!File.Exists(ficheiro))
            {
                sw = File.CreateText(ficheiro);
            }
            else
            {
                sw = File.AppendText(ficheiro);
            }

            string software = textBox1.Text;
            string data = DataTimePicker.Value.ToString("dd-MM-yyyy");
            string hora = HoraTimePicker.Value.ToString("HH:mm");
            string licenca = LicençaComboBox.Text;

            string registo = software + ";" + data + ";" + hora + ";" + licenca;

            sw.WriteLine(registo);
            sw.Close();

            listBox1.Items.Add(registo);

            toolStripStatusLabel1.Text = "Registo concluido com sucesso";
        }

        private void SalaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Directory.Exists("salas"))
            {
                string[] salas = Directory.GetFiles("salas");
                for (int i = 0; i < salas.Length; i++)
                {
                    SalaComboBox.Items.Add(salas[i]);
                }
            }
        }
    }
}