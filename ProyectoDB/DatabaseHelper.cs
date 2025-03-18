using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DatabaseHelper
{
    private string connectionString;

    // Constructor que recibe la cadena de conexión
    public DatabaseHelper(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Método para ejecutar una consulta SELECT y devolver un DataTable
    public DataTable ExecuteQuery(string query)
    {
        DataTable dataTable = new DataTable();
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error de base de datos: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error general: " + ex.Message);
        }
        return dataTable;
    }

    // ✅ Método para ejecutar una consulta SELECT con parámetros
    public DataTable ExecuteQueryWithParameters(string query, SqlParameter[] parameters)
    {
        DataTable dataTable = new DataTable();
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error de base de datos: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error general: " + ex.Message);
        }
        return dataTable;
    }

    public void ExecuteNonQueryWithParameters(string query, SqlParameter[] parameters)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Stock actualizado correctamente. Filas afectadas: {rowsAffected}",
                            "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("⚠ No se actualizó ninguna fila. Verifica si el ID existe en la base de datos.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



}
