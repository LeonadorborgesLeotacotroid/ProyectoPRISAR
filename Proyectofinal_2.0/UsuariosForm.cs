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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void close_Click(object sender, EventArgs e)
        {
            AdministradorForm adminform = new AdministradorForm();
            adminform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {
            // Boton GUARDAR
            bool bandera = false;
            Users _users = new Users();
            _users.Usuarios1 = txtUser.Text;
            _users.Contrasena1 = txtContrasena.Text;
            _users.Roles1 = CBrol.Text;
            _users.Estado1 = CBEstado.Text;

            Controlador_Usuario ctrl = new Controlador_Usuario();

            if (txtId.Text != "")
            {
                _users.Id_usuario1 = int.Parse(txtId.Text);
                bandera = ctrl.actualizar(_users);
            }
            else
            {
                bandera = ctrl.insertar(_users);
            }

            if (bandera)
            {
                MessageBox.Show("Dato Guardado");
                limpiar();
                cargarTabla(null);
            }
        }

        private void limpiar()
        {
            txtId.Text = "";
            txtUser.Text = "";
            txtContrasena.Text = "";
            CBrol.Text = "";
            CBEstado.Text = "";
        }

        private void cargarTabla(string dato)
        {
            List<Users> lista = new List<Users>();
            Controlador_Usuario _Control_Usuario = new Controlador_Usuario();
            dataGridView1.DataSource = _Control_Usuario.consulta(dato);

            // Ocultar la columna "Eliminado" si no está presente en el DataGridView
            if (dataGridView1.Columns.Contains("Eliminado"))
            {
                dataGridView1.Columns["Eliminado"].Visible = false;
                dataGridView1.Columns["Eliminado"].Width = 0;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ////NO SE USA PAPU
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            cargarTabla(dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Modificar
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUser.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtContrasena.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CBrol.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            CBEstado.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                Controlador_Usuario controlador = new Controlador_Usuario();
                bool eliminado = controlador.eliminarLogico(idUsuario);

                if (eliminado)
                {
                    MessageBox.Show("Usuario eliminado correctamente");

                    // Actualizar el DataGridView para reflejar el cambio de estado
                    cargarTabla(null);
                }
                else
                {
                    MessageBox.Show("Error al eliminar usuario");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar");
            }
        }



    }
}
