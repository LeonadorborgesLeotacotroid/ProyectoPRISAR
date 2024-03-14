using System;

namespace Proyectofinal_2._0
{
    class Users
    {
        private int Id_usuario;
        private string Usuarios;
        private string Contrasena;
        private string Roles;
        private string Estado;
        private bool Eliminado; // Cambiado a mayúscula para seguir convención de nombres

        public int Id_usuario1
        {
            get { return Id_usuario; }
            set { Id_usuario = value; }
        }

        public string Usuarios1
        {
            get { return Usuarios; }
            set { Usuarios = value; }
        }

        public string Contrasena1
        {
            get { return Contrasena; }
            set { Contrasena = value; }
        }

        public string Roles1
        {
            get { return Roles; }
            set { Roles = value; }
        }

        public string Estado1
        {
            get { return Estado; }
            set { Estado = value; }
        }

        public bool Eliminado1 // Cambiado a mayúscula para seguir convención de nombres
        {
            get { return Eliminado; }
            set { Eliminado = value; }
        }
    }
}
