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
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void register_loginbtn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void register_Password_TextChanged(object sender, EventArgs e)
        {
            register_Password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void CloseRegistro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
