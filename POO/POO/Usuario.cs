using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Usuario
    {
        // Atributos
        private string apellidos;


        // Propiedades
        public string Codigo { get; set; }
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

        // Constructores
        public Usuario()
        {

        }

        public Usuario(string codigo, string correo)
        {
            Codigo = codigo;
            Correo = correo;
        }

        public Usuario(string codigo, string nombre, string correo)
        {
            
        }

        // Metodos
        public string GetNombreCompleto(string Nombre, string Apellidos)
        {
            string nombreCompleto = Nombre + " " + Apellidos;
            return nombreCompleto;
        }
    }
}
