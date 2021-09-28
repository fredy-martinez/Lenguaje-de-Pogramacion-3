using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declaraar matriz
            int[,] matrizEjemplo = new int[2, 3] { { 4, 64, 30 },
                                                   { 40, 47, 10 } 
                                                 };

            //matrizEjemplo[0, 0] = 25;
            int[,] OtraMatriz = new int[3, 3];
            //Lenar matriz
            for (int f = 0; f < OtraMatriz.GetLength(0); f++) // f de fila
            {
                for (int c = 0; c < OtraMatriz.GetLength(1); c++) // c de Columna
                {
                    OtraMatriz[f, c] = 4 + (f + 4) * (c + 3);
                }
            }

            //Mostrar matriz
            for (int f = 0; f < OtraMatriz.GetLength(0); f++) // f de fila
            {
                for (int c = 0; c < OtraMatriz.GetLength(1); c++) // c de Columna
                {
                    listBox1.Items.Add("La posición es: [" + f + ", " + c + "] = " + OtraMatriz[f, c]);
                   // MessageBox.Show("La posición es: [" + f + ", " + c + "] = " + OtraMatriz[f,c]);
                }
            }
        }
    }
}
