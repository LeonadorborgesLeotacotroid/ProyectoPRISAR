using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Proyectofinal_2._0
{
    class Ctrl_Producto : Conexion
    {
        public List<Productos> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Productos> lista = new List<Productos>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT Id_producto, Nombre, Precio, Stock, Disponibilidad FROM productos WHERE Eliminado = 0 ORDER BY Stock ASC";
            }
            else
            {
                sql = "SELECT Id_producto, Nombre, Precio, Stock, Disponibilidad, Eliminado FROM productos WHERE (Nombre LIKE '%" + dato + "%' OR Precio LIKE '%" + dato + "%' OR Stock LIKE '%" + dato + "%' OR Disponibilidad LIKE '%" + dato + "%)  AND Eliminado = 0 ORDER BY Stock ASC";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Productos _Producto = new Productos();
                    _Producto.Id_producto1 = int.Parse(reader.GetString(0));
                    _Producto.Nombre1 = reader[1].ToString();
                    _Producto.Precio1 = double.Parse(reader.GetString(2));
                    _Producto.Stock1 = reader[3].ToString();
                    _Producto.Disponibilidad1 = reader[4].ToString();
                    lista.Add(_Producto);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(Productos datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO productos (Nombre, Precio, Stock, Disponibilidad) VALUES ('" + datos.Nombre1 + "', '" + datos.Precio1 + "', '" + datos.Stock1 + "', '" + datos.Disponibilidad1 + "')";

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

        public bool actualizar(Productos datos)
        {
            bool bandera = false;

            string sql = "UPDATE productos SET Nombre='" + datos.Nombre1 + "', Precio ='" + datos.Precio1 + "', Stock='" + datos.Stock1 + "', Disponibilidad='" + datos.Disponibilidad1 + "' WHERE Id_producto ='" + datos.Id_producto1 + "'";

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

        public bool eliminarLogico(int idProducto)
        {
            bool bandera = false;

            string sql = "UPDATE productos SET Eliminado = 1 WHERE Id_producto = @idProducto";

            try
            {
                using (MySqlConnection conexionBD = base.conexion())
                {
                    conexionBD.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.Parameters.AddWithValue("@idProducto", idProducto);
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
