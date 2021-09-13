using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones_y_procediminetos_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            //Longitud de la cadena ingresada
            LongitudTextBox.Text = cadena.Length.ToString();

            //Obtener 1 caracter
            PrimerCaracterTextBox.Text = cadena.Substring(0, 1);

            //obtener ultimo caracter
            UltimoTextBox.Text = cadena.Substring(cadena.Length - 1, 1);

            RangoTextBox.Text = cadena.Substring(5,15);

            //Convertir a mayusculas
            MayusculasTextBox.Text = cadena.ToUpper();

            //Minusculas
            MinusculasTextBox.Text = cadena.ToLower();

            //Reemplazar
            ReemplazarTextBox.Text = cadena.Replace("a", "b");

            //Primera letra en mayuscula
            PrimeraMayusculaTextBox.Text = cadena.Substring(0, 1).ToUpper() + cadena.Substring(1, cadena.Length - 1).ToLower(); 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
