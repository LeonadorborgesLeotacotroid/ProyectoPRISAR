using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyectofinal_2._0
{
    public partial class CajeroForm : Form
    {
        private static int folioActual = 1; // Variable estática para el folio
        private Ctrl_Venta ctrlVenta;
        private List<Ventas> ventasTemporales;

        public CajeroForm()
        {
            InitializeComponent();
            ctrlVenta = new Ctrl_Venta();
            ventasTemporales = new List<Ventas>();
            cargarTablaProductos();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Add("Folio", "Folio"); // Agrega la columna Folio
            dataGridView2.Columns.Add("IdProducto", "ID Producto");
            dataGridView2.Columns.Add("Cantidad", "Cantidad");
            dataGridView2.Columns.Add("Precio", "Precio");
            dataGridView2.Columns.Add("Subtotal", "Subtotal");
        }

        private void close_Click(object sender, EventArgs e)
        {
            AdministradorForm adminform = new AdministradorForm();
            adminform.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                int idProducto = int.Parse(txtId.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                double precio = double.Parse(txtPrecio.Text);
                double subtotal = cantidad * precio;

                // Agregar la venta a la lista de ventas temporales con el folio generado
                Ventas ventaTemporal = new Ventas();
                ventaTemporal.Id_producto1 = idProducto;
                ventaTemporal.Cantidad1 = cantidad;
                ventaTemporal.Subtotal1 = subtotal;
                ventaTemporal.Folio1 = folioActual;
                // Asignar el folio actual como string
                ventasTemporales.Add(ventaTemporal);

                // Limpiar los campos después de agregar el producto
                limpiarCampos();

                // Calcular y mostrar el total de la compra
                double totalCompra = CalcularTotalCompra();
                txtSubtotal.Text = totalCompra.ToString("C2");

                // Agregar la venta al DataGridView2
                dataGridView2.Rows.Add(ventaTemporal.Folio1, idProducto, cantidad, precio, subtotal);
            }
        }

        private void limpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

        private void cargarTablaProductos()
        {
            Ctrl_Producto ctrlProducto = new Ctrl_Producto();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.DataSource = ctrlProducto.consulta(null);
        }

        private double CalcularTotalCompra()
        {
            double total = 0;
            foreach (Ventas venta in ventasTemporales)
            {
                total += venta.Subtotal1;
            }
            return total;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double totalCompra = CalcularTotalCompra();
            double efectivo;

            if (!double.TryParse(txtEfectivo.Text, out efectivo))
            {
                MessageBox.Show("Por favor, ingrese un monto válido para el efectivo.");
                return;
            }

            double cambio = efectivo - totalCompra;

            if (efectivo >= totalCompra)
            {
                // Insertar cada venta temporal en la base de datos
                foreach (Ventas ventaTemporal in ventasTemporales)
                {
                    ctrlVenta.Insertar(ventaTemporal);
                }

                // Incrementar el folio actual para la siguiente compra
                folioActual++;

                // Limpiar la lista de ventas temporales
                ventasTemporales.Clear();

                // Limpiar el DataGridView de ventas
                LimpiarDataGridViewVentas();

                // Limpiar los campos de la compra actual
                limpiarCampos();

                // Actualizar la tabla de productos
                cargarTablaProductos();

                if (cambio >= 0)
                {
                    MessageBox.Show($"Cambio: ${cambio.ToString("0.00")}");
                }
                else
                {
                    MessageBox.Show("El monto pagado es insuficiente.");
                }
            }
            else
            {
                MessageBox.Show("El efectivo ingresado es insuficiente.");
            }
        }

        private void LimpiarDataGridViewVentas()
        {
            // Limpiar el DataGridView de ventas
            dataGridView2.Rows.Clear();
            txtSubtotal.Text = "";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView2.SelectedRows[0].Index;
                ventasTemporales.RemoveAt(rowIndex);
                dataGridView2.Rows.RemoveAt(rowIndex);
                double totalCompra = CalcularTotalCompra();
                txtSubtotal.Text = totalCompra.ToString("C2");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDataGridViewVentas();
            limpiarCampos();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


      
