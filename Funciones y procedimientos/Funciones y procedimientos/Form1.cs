using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones_y_procedimientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            Numero1TextBox.Clear();
            Numero2TextBox.Clear();
            ResultadoLabel.Text = string.Empty;
        }

        private int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        private int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        private int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        private int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        private void SumaButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Suma(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString(); // convertir esa cadena de caracteres a entero.
        }

        private void RestaButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Resta(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString(); // convertir esa cadena de caracteres a entero.
        }

        private void MultiplicacionButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Multiplicar(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString(); // convertir esa cadena de caracteres a entero.
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Dividir(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString(); // convertir esa cadena de caracteres a entero.
        }
    }
}
