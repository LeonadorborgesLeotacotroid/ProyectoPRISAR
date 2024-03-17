using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectofinal_2._0
{
    class Productos
    {
        private int Id_producto;
        private string Nombre;
        private double Precio;
        private string Stock;
        private string Disponibilidad;
        private bool Eliminado;

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

        public string Nombre1
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

        public double Precio1
        {
            get
            {
                return Precio;
            }

            set
            {
                Precio = value;
            }
        }

        public string Stock1
        {
            get
            {
                return Stock;
            }

            set
            {
                Stock = value;
            }
        }

        public string Disponibilidad1
        {
            get
            {
                return Disponibilidad;
            }

            set
            {
                Disponibilidad = value;
            }
        }

        public bool Eliminado1 // Cambiado a mayúscula para seguir convención de nombres
        {
            get { return Eliminado; }
            set { Eliminado = value; }
        }

    }
}
