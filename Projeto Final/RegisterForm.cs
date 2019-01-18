﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Projeto_Final
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.FormBorderStyle = 0;
        }

        private void ExitRegisterButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string user = UserTextBox.Text;
            string email = EmailTextBox.Text;
            string pw = PwTextBox.Text;


            /* Verificar campos de entrada */
            string titRegFailed = "Oops! Registo falhado.";
            if (user.Length < 5)
            {
                MessageBox.Show("O username tem de ter no minimo 5 caracteres.", titRegFailed);
            }
            else if (CharEspeciais(user))
            {
                MessageBox.Show("O username contem caracteres especiais.", titRegFailed);
            }
            else if (!FormatoEmail(email))
            {
                MessageBox.Show("O email nao esta no formato correto.", titRegFailed);
            }
            else if (pw.Length < 8)
            {
                MessageBox.Show("A password tem de ter no minimo 8 caracteres.", titRegFailed);
            }
            else if (VerifyPwTextBox.Text != pw)
            {
                MessageBox.Show("As passwords nao sao iguais.", titRegFailed);
            }
            else
            {
                Users registo = new Users(user, email, pw);

                if (registo.UsernameElegivel() == 1)
                {
                    MessageBox.Show("Conta criada com sucesso.", "Secesso!");

                    this.Hide();
                    variaveis.CurrentForm.Show();
                }
                else
                {
                    MessageBox.Show("O username ja esta a ser utilizado.", titRegFailed);
                }
            }
        }

        private bool CharEspeciais(string user)
        {
            foreach (char caracter in user)
            {
                if (!char.IsLetterOrDigit(caracter))
                {
                    return true;
                }
            }

            return false;
        }

        private bool FormatoEmail(string email)
        {
            try
            {
                MailAddress a1 = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();

            variaveis.CurrentForm.Show();
        }
    }
}
