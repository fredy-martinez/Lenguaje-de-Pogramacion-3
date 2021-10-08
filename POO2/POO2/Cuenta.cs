using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Cuenta
    {
        public string NumeroCuenta  { get; set; }
        public Cliente MiCliente { get; set; }
        public DateTime FechaApertura { get; set; }
        public decimal Saldo { get; set; }

        public Cuenta()
        {

        }

        public Cuenta(string numeroCuenta, Cliente miCliente, DateTime fechaApertura)
        {
            NumeroCuenta = numeroCuenta;
            MiCliente = miCliente;
            FechaApertura = fechaApertura;
            Saldo = decimal.Zero; // Esto es lo mismo que == 0 o = 0
        }

        public void Depositar(decimal Monto)
        {
            Saldo = Saldo + Monto;
        }

        public bool Retirar(decimal Monto)
        {
            bool Puederetirar = false;

            if (Saldo == 0 || Saldo< Monto)
            {
                Puederetirar = false;
            }
            else
            {
                Saldo = Saldo - Monto;
                Puederetirar = true;
            }
            return Puederetirar;
        }

    }
}
