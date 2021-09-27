using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones_recursivas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoEnUno(1, 10);
        }

        private void RecorrerDeUnoEnUno(int num1, int num2)
        {
            listBox1.Items.Add(num1);

            if (num1 < num2)
            {
                RecorrerDeUnoEnUno(num1 + 1, num2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void FactorizarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El factorial de " + FactorizarTextBox.Text + " es: " + Factorial(Convert.ToDecimal(FactorizarTextBox.Text)).ToString());
        }

        private decimal Factorial(decimal num)
        {
            if (num == 1)
            {
                return num;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
    }
}
