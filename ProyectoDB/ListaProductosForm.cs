using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoDB
{
    
    public partial class ListaProductosForm: Form
    {
        private readonly DatabaseHelper dbHelper;
        public ListaProductosForm()
        {
            
            dbHelper = new DatabaseHelper("Server=DESKTOP-U8IQ7DR;Database=PAPELERIA;Trusted_Connection=True");
            InitializeComponent();
            CargarProductos();

        }
        private void CargarProductos()
        {
            try
            {
                string query = "SELECT Id_Producto, Nombre, Precio, Stock, Descripcion FROM Producto";
                DataTable dtProductos = dbHelper.ExecuteQuery(query);

                // Limpiar el DataGridView antes de cargar nuevos datos
                ListaProductos.Rows.Clear();

                // Llenar el DataGridView con los datos del DataTable
                foreach (DataRow row in dtProductos.Rows)
                {
                    ListaProductos.Rows.Add(
                        row["Id_Producto"],
                        row["Nombre"],
                        row["Precio"],
                        row["Stock"],
                        row["Descripcion"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            ProductosForm AgregarProducto = new ProductosForm();

            AgregarProducto.Show();

            this.Hide();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();

            // Mostrar el formulario Menú
            menuForm.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void ListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no es el encabezado
            {
                DataGridViewRow row = ListaProductos.Rows[e.RowIndex];

                // Crear objeto Producto con los datos de la fila
                Producto productoSeleccionado = new Producto
                {
                    IdProducto =row.Cells["Id_Producto"].Value.ToString(),
                    Nombre = row.Cells["Nombre"].Value.ToString(),
                    Precio = Convert.ToDecimal(row.Cells["Precio"].Value),
                    Stock = Convert.ToInt32(row.Cells["Stock"].Value),
                    Descripcion = row.Cells["Descripcion"].Value?.ToString() ?? ""
                };

                // Abrir formulario de edición
                using (var editarForm = new Moidifcar_Producto(productoSeleccionado))
                {
                    if (editarForm.ShowDialog() == DialogResult.OK)
                    {
                        // Actualizar el producto en la base de datos
                        ActualizarProducto(editarForm.ProductoActual);
                    }
                }


            }
        }
        private void ActualizarProducto(Producto producto)
        {
            try
            {
                string query = @"UPDATE Producto SET 
                        Nombre = @Nombre, 
                        Precio = @Precio, 
                        Stock = @Stock, 
                        Descripcion = @Descripcion
                        WHERE Id_Producto = @Id_Producto";

                SqlParameter[] parameters = {
            new SqlParameter("@Id_Producto", producto.IdProducto),
            new SqlParameter("@Nombre", producto.Nombre),
            new SqlParameter("@Precio", producto.Precio),
            new SqlParameter("@Stock", producto.Stock),
            new SqlParameter("@Descripcion", producto.Descripcion)
        };

                int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Producto actualizado correctamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductData(); // Refrescar el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar producto: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
