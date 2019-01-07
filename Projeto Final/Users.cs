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
                        return 1;
                    }
                    else
                    {
                        sr.Close();
                        return 0;
                    }
                }
            }

            sr.Close();
            return -1;
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

            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(user + ";" + email + ';' + pw);
            sw.Close();

            return 1;
        }
    }
}
