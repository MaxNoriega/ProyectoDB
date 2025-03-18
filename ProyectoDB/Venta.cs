using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class Venta : Form
    {
        private readonly DatabaseHelper dbHelper;
        public Venta()
        {
            InitializeComponent();
            ListaProductos.KeyDown += ListaProductos_KeyDown;
            txtBuscarProdVenta.KeyDown += txtBuscarProdVenta_KeyDown;
            dbHelper = new DatabaseHelper("Server=DESKTOP-0A6Q7FV;Database=PAPELERIA;Trusted_Connection=True");
        }



        public static class DatosVenta
        {
            public static List<Productos> ListaProdTicket { get; set; } = new List<Productos>();
        }





        //Agregar Producto
        // Evento que se ejecuta cuando se presiona una tecla en el campo de búsqueda
        private void txtBuscarProdVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;  // ✅ Bloquea que el evento se vuelva a ejecutar
                e.SuppressKeyPress = true;  // ✅ Evita que la tecla se registre dos veces

                string idProducto = txtBuscarProdVenta.Text.Trim();

             

                try
                {
                    AgregarProducto(idProducto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AgregarProducto(string idProducto)
        {
            // Consulta SQL para obtener el producto desde la base de datos
            string query = "SELECT Id_Producto, Nombre, Precio, Stock FROM Producto WHERE Id_Producto = @IdProducto";
            SqlParameter[] parameters = { new SqlParameter("@IdProducto", idProducto) };

            DataTable dtProducto = dbHelper.ExecuteQueryWithParameters(query, parameters);

            if (dtProducto.Rows.Count > 0)
            {
                DataRow row = dtProducto.Rows[0];
                string id = row["Id_Producto"].ToString();
                int stock = Convert.ToInt32(row["Stock"]);
                decimal precio = Convert.ToDecimal(row["Precio"]);
                string nombre = row["Nombre"].ToString();

                if (stock > 0)
                {
                    decimal puntosGenerados = precio / 10; // ✅ Calcula los puntos generados

          

                    // 🔹 Agregar el producto al DataGridView con solo los datos requeridos
                    ListaProductos.Rows.Add(id,nombre, precio, puntosGenerados);
                    // ✅ Actualizar el stock en la base de datos restando 1
                    MessageBox.Show($"Reduciendo stock del producto con ID: {idProducto}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string updateQuery = $"UPDATE Producto SET Stock = Stock - 1 WHERE Id_Producto = @{id}";
                    dbHelper.ExecuteNonQueryWithParameters(updateQuery, parameters);

                    // 🔍 Verifica si la consulta se ejecutó
                    MessageBox.Show("Stock reducido en la base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ActualizarTotales(); // ✅ Recalcula los totales
                    txtBuscarProdVenta.Clear(); // ✅ Limpia el TextBox después de agregar el producto
                }
                else
                {
                    MessageBox.Show("El producto no tiene stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
            }
        }

        // Método para actualizar los totales de la venta
        private void ActualizarTotales()
        {
            decimal totalPrecio = 0;
            decimal totalPuntos = 0;

            foreach (DataGridViewRow fila in ListaProductos.Rows)
            {
                // Verifica si las celdas no están vacías antes de hacer cálculos
                if (fila.Cells["Precio_Venta_Producto"].Value != null && decimal.TryParse(fila.Cells["Precio_Venta_Producto"].Value.ToString(), out decimal subtotal))
                {
                    totalPrecio += subtotal;
                }
                if (fila.Cells["PtosGen_Producto_Venta"].Value != null && decimal.TryParse(fila.Cells["PtosGen_Producto_Venta"].Value.ToString(), out decimal puntos))
                {
                    totalPuntos += puntos;
                }
            }

            // Actualiza los campos de total en la interfaz
            txtCostoTotal.Text = totalPrecio.ToString("0.00");
            txtPtosGenerados.Text = totalPuntos.ToString("0.00");
        }





        //Eliminar Producto de la lista
        private async void ListaProductos_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si se presionó la tecla Suprimir (Delete)
            if (e.KeyCode == Keys.Delete)
            {
                // Verifica si se seleccionó alguna fila
                if (ListaProductos.SelectedRows.Count > 0)
                {
                    string idProducto = ListaProductos.SelectedRows[0].Cells[0].Value.ToString(); // Columna 0 = IdProducto
                    string nombreProducto = ListaProductos.SelectedRows[0].Cells["Nombre_Producto_Venta"].Value.ToString();

                    // Pregunta al usuario si está seguro de eliminar el producto
                    var confirmResult = MessageBox.Show($"¿Estás seguro de eliminar el producto '{nombreProducto}'?",
                        "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Elimina la fila del DataGridView
                        ListaProductos.Rows.RemoveAt(ListaProductos.SelectedRows[0].Index);

                        // Recupera el producto desde la API por su nombre

                        //var producto = await ObtenerProductoPorNombreAsync(nombreProducto);

                        //if (producto != null)
                        //{
                        //    // Restaura el stock en la API
                        //    producto.Stock += 1;
                        //    bool actualizado = await ActualizarProductoAsync(producto);

                        //    // Actualizar los totales después de la eliminación
                        //    ActualizarTotales();

                        //    //if (actualizado)
                        //    //{
                        //    //    MessageBox.Show("Producto eliminado y stock actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    //}
                        //    //else
                        //    //{
                        //    //    MessageBox.Show("No se pudo actualizar el stock en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    //}
                        //}
                    }
                }

            }
        }











        //PAGAR
        //private void PagarBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Datos básicos de la venta
        //        int idCliente = int.Parse(txtNumCtrlVenta.Text);
        //        float totalVenta = float.Parse(txtCostoTotal.Text);
        //        int puntosGen = ConvertirPuntosGenerados(txtPtosGenerados.Text);
        //        // Generar un identificador único para la venta
        //        var idVenta = Guid.NewGuid().GetHashCode(); // Genera un ID numérico único
        //        //PrepararProductosVenta();
        //        // Prepara los datos de la venta para TransferenciaForm
        //        var metodoPagoForm = new MetodoPagoForm
        //        {
        //            IDVenta = idVenta,
        //            IdCliente = idCliente,          // Pasa el IdCliente al formulario
        //            TotalVenta = totalVenta,       // Crea una nueva propiedad para recibir TotalVenta
        //            ProductosVenta = DatosVenta.ListaProdTicket, // Envía los productos
        //            PuntosGenerados = puntosGen   // Nueva propiedad para recibir los puntos generados
        //        };
        //        metodoPagoForm.Show();





        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al procesar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //private int ConvertirPuntosGenerados(string puntosGeneradosText)
        //{
        //    try
        //    {
        //        // Intentar convertir a float y redondear
        //        float puntosGenerados = float.Parse(puntosGeneradosText);
        //        return Convert.ToInt32(Math.Round(puntosGenerados));
        //    }
        //    catch (FormatException)
        //    {
        //        // Manejo de error si el formato no es válido
        //        MessageBox.Show("El valor de los puntos generados no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return 0; // Retorna 0 en caso de error
        //    }
        //    catch (Exception ex)
        //    {
        //        // Manejo de otros errores
        //        MessageBox.Show($"Error al convertir los puntos generados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return 0; // Retorna 0 en caso de error
        //    }
        //}
        //private void BackBtn_Click(object sender, EventArgs e)
        //{
        //    Menu menuForm = new Menu();

        //    // Mostrar el formulario Menú
        //    menuForm.Show();

        //    // Ocultar el formulario actual
        //    this.Hide();
        //}
    }
    public class Producto
    {
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }

    public class Productos
    {
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }


}

