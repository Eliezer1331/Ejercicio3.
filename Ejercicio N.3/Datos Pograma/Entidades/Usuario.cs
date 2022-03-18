using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Pograma.Entidades
{
    public class Usuario
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contraseña { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigo, string nombre, string apellido, string contraseña)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Contraseña = contraseña;
        }
    }
}
