using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class ComboBoxItemsAssunto
    {
        public string Titulo { set; get; }
        public string Numero { set; get; }

        //Método- reescreve as strings inicializadas em cima com objetivos de devolver o valor do Titulo
        public override string ToString()
        {
            return Titulo;
        }
    }
}
