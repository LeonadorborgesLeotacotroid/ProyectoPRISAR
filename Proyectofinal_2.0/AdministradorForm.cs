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
            AbrirForm(new PanelForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new CajeroForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm(new ProductosForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new ClienteForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirForm(new UsuariosForm());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirForm(object formnuevo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fc = formnuevo as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fc);
            this.panelContenedor.Tag = fc;
            fc.Show();
        }
    }
}
