﻿using System;
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
        string user;
        int perfil;

        public static string file = "salas.txt";

        public FormGestaoDeSalas(string user, int perfil)
        {
            InitializeComponent();

            this.FormBorderStyle = 0;

            this.user = user;
            this.perfil = perfil;

            string[] importar = File.ReadAllLines(file);

            for (int i = 0; i < importar.Length; i++)
            {
                listBox1.Items.Add(importar[i]);
            }

            /* Mensagem de boas-vindas */
            string mensagem = metodos.GerarBoasVindas(user);
            StatusLabel.Text = mensagem;
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            string[] importar = File.ReadAllLines(file);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (SalaTextBox.Text == importar[i])
                {
                    MessageBox.Show("A sala já está em uso.");
                    listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                    break;
                }
            }
            listBox1.Items.Add(SalaTextBox.Text);
            SalaTextBox.Text = "";
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
    }
}
