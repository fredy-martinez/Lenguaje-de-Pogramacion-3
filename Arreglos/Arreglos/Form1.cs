using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutrarButton_Click(object sender, EventArgs e)
        {
            int[] arreglo1 = new int[5];

            arreglo1[0] = 40;
            arreglo1[1] = 10;
            arreglo1[2] = 31;
            arreglo1[3] = 56;
            arreglo1[4] = 89;

            //otra manera de hacer un arreglo
            int[] arreglo2 = new int[6] { 1, 2, 3, 4, 5, 7 };

            int[] arreglo3 = new int[] { 1, 3, 4, 5, 6, 7};

            int[] arreglo4 = { 1, 2, 3, 4, 5, 7 };

            string[] arreglo5 = new string[] { "carlos", "Juan" };

            /*for (int i = 0; i<arreglo5.Length; i++)
            {
                ListBox.Items.Add(arreglo5[i]);
            }*/
            
            foreach(var item in arreglo5) // Hace lo mismo que el for de arriba
            {
                ListBox.Items.Add(item);
            }
        }

        private void OrdenarButton_Click(object sender, EventArgs e)
        {
            int[] valores = new int[] { 3, 6, 9, 2, 1, 8, 7 };

            //Ordenar de menor a mayor
           /* Array.Sort(valores);

            foreach(var item in valores)
            {
                OrdenarListBox.Items.Add(item);
            }

            //Los escribe al reves
            Array.Reverse(valores);

            foreach (var item in valores)
            {
                OrdenarListBox.Items.Add(item);
            }*/

            // para hacerlo de mayor a menor es arreglarlos de menor a mayor y solo imprimirlos al reves así:

            Array.Sort(valores);
            Array.Reverse(valores);

            foreach (var item in valores)
            {
                OrdenarListBox.Items.Add(item);
            }

        }
    }
}
