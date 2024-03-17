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
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void close_Click(object sender, EventArgs e)
        {
            AdministradorForm adminform = new AdministradorForm();
            adminform.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Productos _producto = new Productos();
            _producto.Nombre1 = txtNombreProducto.Text;
            _producto.Precio1 = double.Parse(txtPrecio.Text);
            _producto.Stock1 = txtCantidad.Text;
            _producto.Disponibilidad1 = CBoxEstado.Text;

            Ctrl_Producto ctrl = new Ctrl_Producto();

            if (txtIdProducto.Text != "")
            {
                _producto.Id_producto1 = int.Parse(txtIdProducto.Text);
                bandera = ctrl.actualizar(_producto);
            }
            else
            {
                bandera = ctrl.insertar(_producto);
            }

            if (bandera)
            {
                MessageBox.Show("Datos Guardado");
                limpiar();
                cargarTabla(null);
            }
        }

        private void limpiar()
        {
            txtIdProducto.Text = "";
            txtNombreProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            CBoxEstado.Text = "";
        }


        private void cargarTabla(string dato)
        {
            List<Productos> lista = new List<Productos>();
            Ctrl_Producto _Control_Producto = new Ctrl_Producto();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.DataSource = _Control_Producto.consulta(dato);
            // Asegúrate de que las propiedades de la clase Productos estén configuradas correctamente para que se muestren en el DataGridView
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtIdProducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombreProducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            CBoxEstado.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdProducto.Text = "";
            txtNombreProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            CBoxEstado.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            cargarTabla(dato);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {

        }

        private void adminAddProducts_importBtn_Click(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                Ctrl_Producto controlador = new Ctrl_Producto();
                bool eliminado = controlador.eliminarLogico(idProducto);

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

