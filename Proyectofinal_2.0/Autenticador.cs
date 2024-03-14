using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyectofinal_2._0
{
    public class Autenticador
    {
        private Conexion conexion = new Conexion();

        public bool VerificarCredenciales(string usuario, string contraseña)
        {
            MySqlConnection conexionBD = conexion.conexion();
            if (conexionBD == null)
            {
                return false;
            }

            try
            {
                string consulta = "SELECT * FROM usuarios WHERE Usuarios = @Usuarios AND Contrasena = @Contrasena AND Estado = 'Activo' AND Eliminado = 0";
                using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@Usuarios", usuario);
                    comando.Parameters.AddWithValue("@Contrasena", contraseña);

                    conexionBD.Open();
                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (conexionBD != null && conexionBD.State == ConnectionState.Open)
                {
                    conexionBD.Close();
                }
            }
        }

        public string ObtenerRol(string usuario)
        {
            MySqlConnection conexionBD = conexion.conexion();
            if (conexionBD == null)
            {
                return null;
            }

            try
            {
                string consulta = "SELECT Roles FROM usuarios WHERE Usuarios = @Usuarios";
                using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@Usuarios", usuario);

                    conexionBD.Open();
                    return comando.ExecuteScalar()?.ToString();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (conexionBD != null && conexionBD.State == ConnectionState.Open)
                {
                    conexionBD.Close();
                }
            }
        }
    }
}
