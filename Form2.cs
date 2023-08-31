using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DEMO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.Exists("D:/Mosquito");
            Directory.CreateDirectory("D:/Mosquito/Langosta");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool valor = Directory.Exists("D:/Mosquito/Langosta");
            if (valor == true)
            Directory.Delete("D:/Mosquito/Langosta");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Create("D:/ Mosquito / hola.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // File.Copy("D:/receta1/pollo.txt");
        }
    }
}
