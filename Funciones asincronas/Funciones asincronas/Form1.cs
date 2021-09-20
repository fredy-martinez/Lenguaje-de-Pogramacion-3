using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Funciones_asincronas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = "Proceso Inciado";
            HornearPizzaAsyn();
            ResultadoLabel.Text = "Proceso Terminado";
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsyn() // Task lo vuelve (asincronico) significa que va a hacer los procesos al mismo tiempo
        {
            return Task.Delay(10000);
        }

        private async void SumarButton_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(await SumarDosValoresAsync(25M, 50M)); 
        }

        private async Task<decimal> SumarDosValoresAsync(decimal num1, decimal num2)
        {
            var resultado = await Task.Run(() =>
            {
                return num1 + num2;
            });
            return resultado;
        }
    }
}
