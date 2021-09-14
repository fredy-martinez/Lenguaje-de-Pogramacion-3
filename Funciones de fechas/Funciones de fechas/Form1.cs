using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones_de_fechas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fechaIngresada = dateTimePicker1.Value;

            DiaTextBox.Text = fechaIngresada.Day.ToString();
            MesTextBox.Text = fechaIngresada.Month.ToString();
            YearTextBox.Text = fechaIngresada.Year.ToString();
            HoraTextBox.Text = fechaIngresada.Hour.ToString();
            //Convertir el mes a letras
            MesLetrastextBox.Text = fechaIngresada.ToString("MMMM");

            //Agregar dias
            int numeroDias = Convert.ToInt32(AgergarDiasTextBox.Text);
            NuevoDiaTextBox.Text = fechaIngresada.AddDays(numeroDias).ToShortDateString();

            //Restar dias
            //NuevoDiaTextBox.Text = fechaIngresada.AddDays(numeroDias).ToShortDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
