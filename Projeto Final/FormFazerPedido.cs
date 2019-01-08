using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class FormFazerPedido : Form
    {
        public FormFazerPedido()
        {
            InitializeComponent();

            //Aparecer a data de hoje na TextBox da Hora- DatatextBox
            DataTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Aparacer hora do dia de hoje na textBox6
            HoraTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
