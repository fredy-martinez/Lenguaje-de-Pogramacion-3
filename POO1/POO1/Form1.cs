using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Usuario usuario = new Usuario("FMART", "famartinezg@unah.hn");

            Usuario usuario = new Usuario();

            usuario.Correo = "FMART";
            usuario.Codigo = "famartinezg@unah.hn";
            usuario.Nombre = "Fredy";
            usuario.Apellidos = "Martinez";

            MessageBox.Show(usuario.GetNombre(usuario.Nombre, usuario.Apellidos));
        }
    }
}
