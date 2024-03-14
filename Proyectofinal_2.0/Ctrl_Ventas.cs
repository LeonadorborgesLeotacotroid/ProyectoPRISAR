using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Proyectofinal_2._0
{
    class Ctrl_Venta : Conexion
    {
        public List<Ventas> Consulta()
        {
            List<Ventas> lista = new List<Ventas>();
            //
            string sql = "SELECT Id_venta, Id_producto, Cantidad, Subtotal FROM ventas";

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Ventas venta = new Ventas();
                    venta.Id_venta1 = int.Parse(reader.GetString(0));
                    venta.Id_producto1 = int.Parse(reader.GetString(1));
                    venta.Cantidad1 = int.Parse(reader.GetString(2));
                    venta.Subtotal1 = double.Parse(reader.GetString(3));
                    lista.Add(venta);
                }

                conexionBD.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;
        }

        public bool Insertar(Ventas venta)
        {
            bool exito = false;

            string sqlInsertarVenta = "INSERT INTO ventas (Id_producto, Cantidad, Subtotal, Folio) VALUES ('" + venta.Id_producto1 + "', '" + venta.Cantidad1 + "', '" + venta.Subtotal1 + "', '" + Configuracion.FolioActual + "')";
            string sqlActualizarProductos = "UPDATE productos SET Stock = Stock - " + venta.Cantidad1 + " WHERE Id_producto = " + venta.Id_producto1;

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();

                // Inicia una transacción para garantizar que ambas consultas se ejecuten correctamente o ninguna
                MySqlTransaction transaccion = conexionBD.BeginTransaction();

                MySqlCommand comandoInsertar = new MySqlCommand(sqlInsertarVenta, conexionBD);
                MySqlCommand comandoActualizarProductos = new MySqlCommand(sqlActualizarProductos, conexionBD);

                comandoInsertar.ExecuteNonQuery();
                comandoActualizarProductos.ExecuteNonQuery();

                // Si las dos consultas se ejecutaron correctamente, se realiza el commit de la transacción
                transaccion.Commit();

                conexionBD.Close();
                exito = true;

                // Actualizar el folio actual en la configuración
                Configuracion.FolioActual++;
                // Guardar el folio actual en la configuración de la aplicación
                Properties.Settings.Default["FolioActual"] = Configuracion.FolioActual;
                Properties.Settings.Default.Save();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return exito;
        }
    }
}
