using Datos_Pograma.Accesos;
using Datos_Pograma.Entidades;
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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        DatosUsuarios datosusuarios = new DatosUsuarios();
        Usuario user = new Usuario();
       
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
        }

        private void RegistrarseButton_Click(object sender, EventArgs e)
        {
            user.Codigo = CodigoTextBox.Text;
            user.Nombre = NombreTextBox.Text;
            user.Apellido = ApellidoTextBox.Text;
            user.Contraseña = ContraseñaTextBox.Text;


            bool inserto = datosusuarios.InsertarUsuario(user);

            if (inserto)
            {
                MessageBox.Show("Se ha registrado con exito");
                
            }
            
            else
            {
                MessageBox.Show("No se pudo registrar");
                
            }

            MostrarUsuarios mostrarUsuarios = new MostrarUsuarios();
            mostrarUsuarios.Show();


        }
       

    }
}
