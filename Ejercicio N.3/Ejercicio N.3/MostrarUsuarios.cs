using Datos_Pograma.Accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_N._3
{
    public partial class MostrarUsuarios : Form
    {
        public MostrarUsuarios()
        {
            InitializeComponent();
        }
        DatosUsuarios datosUsuarios = new DatosUsuarios();
       
        private void MostrarUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            dataGridView1.DataSource = datosUsuarios.ListaDeUsuarios();
            

        }
       

    }
}
