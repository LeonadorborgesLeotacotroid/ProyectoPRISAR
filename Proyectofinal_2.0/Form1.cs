using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectofinal_2._0
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Autenticador authenticator = new Autenticador();
            if (authenticator.VerificarCredenciales(txtUsuario.Text, txtContraseña.Text))
            {
                // Verificar el rol del usuario directamente en el método
                string rol = authenticator.ObtenerRol(txtUsuario.Text);
                if (rol == "Administrador")
                {
                    AdministradorForm adminform = new AdministradorForm();
                    adminform.Show();
                    this.Hide();
                }
                else if (rol == "Empleado")
                {
                    CajeroForm cajaform = new CajeroForm();
                    cajaform.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtelo de nuevo.");
            }
        }


        private void CloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registerbtn_Click(object sender, EventArgs e)
        {
            RegistroForm registroform = new RegistroForm();
            registroform.Show();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
