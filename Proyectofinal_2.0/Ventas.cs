using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectofinal_2._0
{
    class Ventas
    {
        private int Id_venta;
        private int Id_producto;
        private int Cantidad;
        private double Subtotal;
        private bool Eliminado;
        private int? Folio;
        private DateTime Fecha;

        public int Id_venta1
        {
            get
            {
                return Id_venta;
            }

            set
            {
                Id_venta = value;
            }
        }

        public int Id_producto1
        {
            get
            {
                return Id_producto;
            }

            set
            {
                Id_producto = value;
            }
        }

        public int Cantidad1
        {
            get
            {
                return Cantidad;
            }

            set
            {
                Cantidad = value;
            }
        }

        public double Subtotal1
        {
            get
            {
                return Subtotal;
            }

            set
            {
                Subtotal = value;
            }
        }
        public bool Eliminado1 // Cambiado a mayúscula para seguir convención de nombres
        {
            get { return Eliminado; }
            set { Eliminado = value; }
        }

        public DateTime Fecha1
        {
            get
            {
                return Fecha;
            }

            set
            {
                Fecha = value;
            }
        }

        public int? Folio1
        {
            get
            {
                return Folio;
            }

            set
            {
                Folio = value;
            }
        }
    }
}
