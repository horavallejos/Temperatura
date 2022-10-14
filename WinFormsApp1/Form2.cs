using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            text1.Clear();
            text2.Clear();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DECLARACION DE VARIABLES
            byte temperatura;
            string clima;
            // ENTRADA DE DATOS
            temperatura = Convert.ToByte(text1.Text);
            // PROCESO DE INFORMACION
            if (temperatura < 10)
            {
                clima = "Frio";
            }
            else if (temperatura >= 10 && temperatura <= 20)
            {
                clima = "Nublado";
            }
            else if (temperatura > 20 && temperatura <= 30)
            {
                clima = "Templado";
            }
            else if (temperatura > 30)
            {
                clima = "CALOORRR";
            }
            else
            {
                clima = "Lo que pusiste en temperatura es ridiculo";
            }

            // SALIDA DE INFORMACION

            text2.Text = clima;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}