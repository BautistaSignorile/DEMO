using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    internal class Problema
    {
        public void saludar() 
        {
            MessageBox.Show("HOLA");
        }
        public void VerFruta(ListBox lst) 
        {
            string[] frutas = { "Uva", "Pera" };
            lst.Items.Clear();
            foreach (string fruta in frutas) 
            { 
                lst.Items.Add(fruta);
            }
        }
    }
}
