using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Final
{
    class Users
    {
        static string path = "users.txt";

        private string user;
        private string email;
        private string pw;
        private int perfil;

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
            StreamReader sr = File.OpenText(path);
            string ln = "";
            while ((ln = sr.ReadLine()) != null)
            {
                string[] dados = ln.Split(';');
                if (dados[0] == user || dados[1] == user)
                {
                    if (dados[2] == pw)
                    {
                        sr.Close();

                        perfil = Convert.ToInt16(dados[3]);
                        return perfil;
                    }
                    else
                    {
                        sr.Close();
                        return -1;
                    }
                }
            }

            sr.Close();
            return -2;
        }

        public void Sessao(int perfil)
        {
            if (perfil == 0)
            {
                /* Abrir interface de administrador */
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
            StreamReader sr = File.OpenText(path);
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

            perfil = 2;

            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(user + ';' + email + ';' + pw + ';' + perfil);
            sw.Close();

            return 1;
        }
    }
}
