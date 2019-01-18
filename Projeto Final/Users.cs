﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Final
{
    class Users
    {
        static string fichUsers = "users.txt";

        private string user;
        private string email;
        private string pw;
        private int perfil;
        private string estado = "1";

        /* Credenciais de admin */
        private string adminUser = "admin";
        private string adminPw = "trabalho";

        public Users()
        {

        }

        public Users(string user, string email, string pw)
        {
            this.user = user;
            this.email = email;
            this.pw = pw;
        }

        public Users(string user, string pw)
        {
            this.user = user;
            this.pw = pw;
        }
        
        public int Login()
        {
            /*
             * Retorna:
             * 0 -> Conta admin
             * perfil = 1 -> Conta Servicos de Inf.
             * perfil = 2 -> Conta Professor
             * -1 -> Password incorreta
             * -2 -> Conta bloqueada
             * -3 -> Conta nao existe
             */

            if (user == adminUser && pw == adminPw)
            {
                return 0;
            }
            else
            {
                StreamReader sr = File.OpenText(fichUsers);
                string ln = "";
                while ((ln = sr.ReadLine()) != null)
                {
                    string[] dados = ln.Split(';');
                    /* Permitir uso de username ou email para identificacao da conta */
                    if (dados[0] == user || dados[1] == user)
                    {
                        if (dados[2] == pw)
                        {
                            if (dados[4] == estado)
                            {
                                sr.Close();

                                perfil = Convert.ToInt16(dados[3]);
                                return perfil;
                            }
                            else
                            {
                                sr.Close();
                                return -2;
                            }
                        }
                        else
                        {
                            sr.Close();
                            return -1;
                        }
                    }
                }

                sr.Close();
                return -3;
            }
        }

        public void Sessao(int perfil)
        {
            if (perfil == 0)
            {
                Admin adm = new Admin();
                adm.Show();
            }
            else if (perfil == 1)
            {
                ServiçosDeInformatica sdf = new ServiçosDeInformatica(user);
                sdf.Show();
            }
            else
            {
                MenuProfessor prof = new MenuProfessor(user);
                prof.Show();
            }
        }

        public int UsernameElegivel()
        {
            StreamReader sr = File.OpenText(fichUsers);
            string ln = "";
            while ((ln = sr.ReadLine()) != null)
            {
                string[] dados = ln.Split(';');
                if (dados[0] == user || dados[1] == email)
                {
                    sr.Close();
                    return 0;
                }
            }

            sr.Close();

            /* Modificar o nivel de acesso cabera ao admin */
            perfil = 2;

            StreamWriter sw = File.AppendText(fichUsers);
            sw.WriteLine(user + ';' + email + ';' + pw + ';' + perfil + ';' + estado);
            sw.Close();

            return 1;
        }
    }
}
