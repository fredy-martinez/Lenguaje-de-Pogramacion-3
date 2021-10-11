using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Cliente cliente;
        Cuenta cuenta;
        MovimientosCuenta Movimientocuenta;
        List<MovimientosCuenta> ListaMovimientoCuenta;

        private void CrearCuentaButton_Click(object sender, EventArgs e)
        {
            // 1 Crear cuenta
            cliente = new Cliente(IdentidadTextBox.Text, NombretextBox.Text); // Identidad, Nombre

            // 2 crear La Cuenta
            cuenta = new Cuenta(NumeroCuentaTextBox.Text, cliente, DateTime.Now); // Numeor de cuenta, Cliente y Hora

            SaldotextBox.Text = cuenta.Saldo.ToString("N"); // N para que tire .00 como moneda


        }

        private void AgregarCuentaButton_Click(object sender, EventArgs e)
        {
            if (MontoTextBox.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el monto");
                MontoTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TipoMovimientoComboBox.Text) )
            {
                MessageBox.Show("Ingrese el Tipo de movimiento");
                MontoTextBox.Focus();
                return;
            }
            if (TipoMovimientoComboBox.Text == "Deposito")
            {
               cuenta.Depositar(Convert.ToDecimal(MontoTextBox.Text));

                Movimientocuenta = new MovimientosCuenta(cuenta, DateTime.Now, 
                                       Convert.ToDecimal(MontoTextBox.Text), 
                                       TipoMovimientoComboBox.Text);

                ListaMovimientoCuenta = new List<MovimientosCuenta>();
                ListaMovimientoCuenta.Add(Movimientocuenta);

                EnumerarListBox.Items.Add("Deposito a la cuenta N° "+ cuenta.NumeroCuenta + " por la cantidad de "+ 
                                            Convert.ToDecimal(MontoTextBox.Text) + " con fecha " + 
                                            Movimientocuenta.FechaMovimiento.ToShortDateString());

                SaldotextBox.Text = cuenta.Saldo.ToString("N");
            }
            else if (TipoMovimientoComboBox.Text == "Retiro")
            {
                bool pudoRetirar = cuenta.Retirar(Convert.ToDecimal(MontoTextBox.Text));
                if (pudoRetirar)
                {
                    Movimientocuenta = new MovimientosCuenta(cuenta, DateTime.Now,
                                       Convert.ToDecimal(MontoTextBox.Text),
                                       TipoMovimientoComboBox.Text);

                    ListaMovimientoCuenta = new List<MovimientosCuenta>();
                    ListaMovimientoCuenta.Add(Movimientocuenta);

                    EnumerarListBox.Items.Add("Retiro de la cuenta N° " + cuenta.NumeroCuenta + " por la cantidad de " +
                                                Convert.ToDecimal(MontoTextBox.Text) + " con fecha " +
                                                Movimientocuenta.FechaMovimiento.ToShortDateString());

                    SaldotextBox.Text = cuenta.Saldo.ToString("N");
                }
                else
                {
                    MessageBox.Show("No tiene saldo suficiente para realizar la transaccion");
                }
            }
            MontoTextBox.Clear();
        }
    }
}
