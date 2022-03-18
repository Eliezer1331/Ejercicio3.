using Datos_Pograma.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Pograma.Accesos
{
    public class DatosUsuarios
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=prograejercicio3; Uid=root; Pwd=13@Eliezer31;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public  bool InsertarUsuario(Usuario usuario)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO usuarios VALUES (@Codigo, @Nombre, @Apellido, @Contraseña);";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Codigo", usuario.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

                cmd.ExecuteNonQuery();
                inserto = true;
                conn.Close();
            }
            catch (Exception)
            {

               
            }
            return inserto;
        }

       public Usuario Login(string codigo,string contraseña)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuarios WHERE Codigo = @Codigo AND Contraseña = @Contraseña;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    user = new Usuario();
                    user.Codigo = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Apellido = reader[2].ToString();
                    user.Contraseña = reader[3].ToString();

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

                
            }
            return user;
        }

        public DataTable ListaDeUsuarios()
        {

            DataTable ListaUsuarios = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuarios ";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                ListaUsuarios.Load(reader);
            }
            catch (Exception ex)
            {

                
            }
            return ListaUsuarios;
        }

    }
}
