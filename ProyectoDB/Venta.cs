﻿using System;
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
            dbHelper = new DatabaseHelper("Server=DESKTOP-U8IQ7DR;Database=PAPELERIA;Trusted_Connection=True");
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
                e.Handled = true;
                e.SuppressKeyPress = true;

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
            SqlParameter[] selectParameters = { new SqlParameter("@IdProducto", idProducto) };

            DataTable dtProducto = dbHelper.ExecuteQueryWithParameters(query, selectParameters);

            if (dtProducto.Rows.Count > 0)
            {
                DataRow row = dtProducto.Rows[0];
                string id = row["Id_Producto"].ToString();
                int stock = Convert.ToInt32(row["Stock"]);
                decimal precio = Convert.ToDecimal(row["Precio"]);
                string nombre = row["Nombre"].ToString();

                if (stock > 0)
                {
                    decimal puntosGenerados = precio / 10; //  Calcula los puntos generados

                    // 🔹 Agregar el producto al DataGridView con solo los datos requeridos
                    ListaProductos.Rows.Add(id, nombre, precio, puntosGenerados);

                    // Crear un nuevo array de parámetros para la consulta UPDATE
                    SqlParameter[] updateParameters = { new SqlParameter("@IdProducto", idProducto) };
                    string updateQuery = "UPDATE Producto SET Stock = Stock - 1 WHERE Id_Producto = @IdProducto";
                    dbHelper.ExecuteNonQueryWithParameters(updateQuery, updateParameters);

                    // Agregar el producto a la lista para el ticket
                    DatosVenta.ListaProdTicket.Add(new Productos
                    {
                        IdProducto = id,
                        Nombre = nombre,
                        Precio = precio
                    });

                    ActualizarTotales(); //  Recalcula los totales
                    txtBuscarProdVenta.Clear(); //  Limpia el TextBox después de agregar el producto
                }
                else
                {
                    MessageBox.Show("El producto no tiene stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        private void ListaProductos_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si se presionó la tecla "Delete" o "Backspace"
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                // Verifica si hay una fila seleccionada
                if (ListaProductos.SelectedRows.Count > 0)
                {
                    // Obtiene el ID y nombre del producto de la fila seleccionada
                    string idProducto = ListaProductos.SelectedRows[0].Cells[0].Value.ToString(); // Columna 0 = ID

                    //  Elimina la fila del DataGridView
                    ListaProductos.Rows.RemoveAt(ListaProductos.SelectedRows[0].Index);

                    //  Reponer stock en la base de datos
                    string updateQuery = "UPDATE Producto SET Stock = Stock + 1 WHERE Id_Producto = @IdProducto";
                    SqlParameter[] parameters = { new SqlParameter("@IdProducto", idProducto) };

                    dbHelper.ExecuteNonQueryWithParameters(updateQuery, parameters);

                    //  Actualiza los totales después de eliminar el producto
                    ActualizarTotales();
                }
            }
        }













        //PAGAR
        private void PagarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay productos en la lista antes de continuar
                if (ListaProductos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos en la venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar y convertir el ID del Cliente
                if (!int.TryParse(txtNumCtrlVenta.Text, out int idCliente))
                {
                    MessageBox.Show("ID de cliente inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar y convertir el total de la venta
                if (!float.TryParse(txtCostoTotal.Text, out float totalVenta))
                {
                    MessageBox.Show("Total de venta inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertir los puntos generados de forma segura
                int puntosGen = ConvertirPuntosGenerados(txtPtosGenerados.Text);

                // Generar un identificador único para la venta (Siempre positivo)
                int idVenta = Math.Abs(Guid.NewGuid().GetHashCode());

                // Preparar los datos de la venta para TransferenciaForm
                var metodoPagoForm = new MetodoPagoForm
                {
                    IDVenta = idVenta,
                    IdCliente = idCliente,          // Pasa el IdCliente al formulario
                    TotalVenta = totalVenta,       // Pasa el total de la venta
                    ProductosVenta = DatosVenta.ListaProdTicket, // Envía los productos
                    PuntosGenerados = puntosGen   // Envía los puntos generados
                };

                metodoPagoForm.Show(); // Abre la ventana de método de pago
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private int ConvertirPuntosGenerados(string puntosGeneradosText)
        {
            try
            {
                if (!float.TryParse(puntosGeneradosText, out float puntosGenerados))
                {
                    MessageBox.Show("El valor de los puntos generados no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                return Convert.ToInt32(Math.Round(puntosGenerados)); // Redondea al entero más cercano
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al convertir los puntos generados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();

            // Mostrar el formulario Menú
            menuForm.Show();

            // Ocultar el formulario actual
            this.Hide();
        }
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
        public decimal Precio { get; set; }  // Precio unitario
       
    }


}

