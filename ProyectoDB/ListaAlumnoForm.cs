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
    public partial class ListaUsuariosForm: Form
    {
        private readonly DatabaseHelper dbHelper;
        public ListaUsuariosForm()
        {
            dbHelper = new DatabaseHelper("Server=DESKTOP-U8IQ7DR;Database=PAPELERIA;Trusted_Connection=True");
            InitializeComponent();
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {
            try
            {
                string query = "SELECT NumCtrl, Nombre FROM Alumno";
                DataTable dtAlumnos = dbHelper.ExecuteQuery(query);

                // Limpiar el DataGridView antes de cargar nuevos datos
                ListaAlumnos.Rows.Clear();

                // Llenar el DataGridView con los datos del DataTable
                foreach (DataRow row in dtAlumnos.Rows)
                {
                    ListaAlumnos.Rows.Add(
                        row["Nombre"],
                        row["NumCtrl"]
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
            AgregarAlumno agregarAlumno = new AgregarAlumno();

            agregarAlumno.Show();

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

        private void ListaUsuariosForm_Click(object sender, EventArgs e)
        {

        }

        private void ListaUsuariosForm_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
