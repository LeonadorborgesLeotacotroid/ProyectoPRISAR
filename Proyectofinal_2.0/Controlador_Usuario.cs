using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyectofinal_2._0
{
    class Controlador_Usuario : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT Id_usuario, Usuarios, Contrasena, Roles, Estado, Eliminado FROM usuarios WHERE Eliminado = 0 ORDER BY Roles ASC";
            }
            else
            {
                sql = "SELECT Id_usuario, Usuarios, Contrasena, Roles, Estado, Eliminado FROM usuarios WHERE (Usuarios LIKE '%" + dato + "%' OR Contrasena LIKE '%" + dato + "%' OR Roles LIKE '%" + dato + "%' OR Estado LIKE '%" + dato + "%') AND Eliminado = 0 ORDER BY Roles ASC";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                //aqui se llama el modelo es decir Users.cs
                while (reader.Read())
                {
                    Users _users = new Users();
                    _users.Id_usuario1 = int.Parse(reader.GetString(0));
                    _users.Usuarios1 = reader[1].ToString();
                    _users.Contrasena1 = reader[2].ToString();
                    _users.Roles1 = reader[3].ToString();
                    _users.Estado1 = reader[4].ToString();
                    lista.Add(_users);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(Users datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO usuarios (Usuarios, Contrasena, Roles, Estado, Eliminado) VALUES (@Usuarios, @Contrasena, @Roles, @Estado, 0)";

            try
            {
                using (MySqlConnection conexionBD = base.conexion())
                {
                    conexionBD.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.Parameters.AddWithValue("@Usuarios", datos.Usuarios1);
                    comando.Parameters.AddWithValue("@Contrasena", datos.Contrasena1);
                    comando.Parameters.AddWithValue("@Roles", datos.Roles1);
                    comando.Parameters.AddWithValue("@Estado", datos.Estado1);
                    comando.ExecuteNonQuery();
                    bandera = true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }

            return bandera;
        }


        public bool actualizar(Users datos)
        {
            bool bandera = false;

            string sql = "UPDATE usuarios SET Usuarios='" + datos.Usuarios1 + "', Contrasena ='" + datos.Contrasena1 + "', Roles='" + datos.Roles1 + "', Estado='" + datos.Estado1 + "' WHERE Id_usuario='" + datos.Id_usuario1 + "'";

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }

            return bandera;
        }


        public bool eliminarLogico(int idUsuario)
        {
            bool bandera = false;

            string sql = "UPDATE usuarios SET Estado = 'Inactivo', Eliminado = 1 WHERE Id_usuario = " + idUsuario;

            try
            {
                using (MySqlConnection conexionBD = base.conexion())
                {
                    conexionBD.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    bandera = true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }

            return bandera;
        }


    }
}
