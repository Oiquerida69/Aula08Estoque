using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08Estoque
{
    internal class Ultilidades
    {
        public void mostraMensagem()
        {
            MessageBox.Show("Oii sumido :)");

        }
        public bool textboxestavazio(TextBox Texto)
        {
            if (Texto.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
