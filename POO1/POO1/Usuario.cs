using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    public class Usuario
    {
        //Propiedades, CaracteristicasAtributos

        // Atributos
        private string apellidos;


        //Propiedades
        public string Codigo { get; set; } // Para hacerlo automaticamente poner prop
        public string Nombre { get; set; }
        public string Apellidos
        {
            set
            {
                apellidos = value;
            }
            get
            {
                return apellidos;
            }
        }

        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }

        //Constructores
        public Usuario() // Es recomendable usar un constructor vacio
        {

        }

        public Usuario(string codigo, string correo)
        {
            Codigo = codigo;
            Correo = correo;
        }

        public Usuario(string codigo, string nombre, string apellidos, int edad, string correo, string password) : this(codigo, nombre)
        {
            Apellidos = apellidos;
            Edad = edad;
            Correo = correo;
            Password = password;
        }

        // Metodos
        public string GetNombre(string nombre, string apellidos)
        {
            string NombreCompleto = nombre + " " + apellidos;
            return NombreCompleto;
        }
    }
}
