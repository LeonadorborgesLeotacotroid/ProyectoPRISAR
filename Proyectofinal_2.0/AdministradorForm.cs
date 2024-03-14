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
    public partial class AdministradorForm : Form
    {
        public AdministradorForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelForm panelform = new PanelForm();
            panelform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CajeroForm cajeroform = new CajeroForm();
            cajeroform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductosForm productosform = new ProductosForm();
            productosform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteForm clienteform = new ClienteForm();
            clienteform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosform = new UsuariosForm();
            usuariosform.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
