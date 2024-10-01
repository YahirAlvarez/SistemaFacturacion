using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SistemaFacturacion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-9AO7TKC\\SQLEXPRESS;database=SystemFacturacion; integrated security=true");
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtRFC.Text) ||
                string.IsNullOrWhiteSpace(txtRegimenFiscal.Text) ||
                string.IsNullOrWhiteSpace(txtDireccionFiscal.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, completa toda la información.");
                return; // Detener la ejecución si algún campo está vacío
            }

            // Validar el RFC (12 o 13 caracteres, letras y números)
            if (!ValidarRFC(txtRFC.Text))
            {
                MessageBox.Show("El RFC ingresado no es válido. Asegúrate de que tenga el formato correcto (12 o 13 caracteres).");
                return; // Detener la ejecución si el RFC no es válido
            }

            // Consulta para insertar los datos del emisor
            string consulta = "INSERT INTO Emisor (Nombre, RFC, RegimenFiscal, DireccionFiscal) " +
                              "VALUES (@Nombre, @RFC, @RegimenFiscal, @DireccionFiscal)";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                // Asignar los valores de los TextBox a los parámetros
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@RFC", txtRFC.Text);
                comando.Parameters.AddWithValue("@RegimenFiscal", txtRegimenFiscal.Text);
                comando.Parameters.AddWithValue("@DireccionFiscal", txtDireccionFiscal.Text);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery(); // Ejecutar la consulta de inserción
                    conexion.Close();

                    MessageBox.Show("Emisor registrado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar emisor: " + ex.Message);
                }
            }
        }

        private bool ValidarRFC(string rfc)
        {
            // Expresión regular para validar RFC (12 o 13 caracteres, letras y números)
            string patronRFC = @"^([A-ZÑ&]{3,4})?(\d{2})(\d{2})(\d{2})[A-Z\d]{3}$";

            // Verificar si el RFC cumple con el formato
            return Regex.IsMatch(rfc, patronRFC, RegexOptions.IgnoreCase);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtRFC.Text) ||
                string.IsNullOrWhiteSpace(txtRegimenFiscal.Text) ||
                string.IsNullOrWhiteSpace(txtDireccionFiscal.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, completa toda la información.");
                return; // Detener la ejecución si algún campo está vacío
            }

            // Validar el RFC
            if (!ValidarRFC(txtFiltrarRFC.Text))
            {
                MessageBox.Show("El RFC ingresado no es válido.");
                return;
            }

            // Consulta SQL para modificar los datos del emisor
            string consulta = "UPDATE Emisor SET Nombre = @Nombre, RegimenFiscal = @RegimenFiscal, DireccionFiscal = @DireccionFiscal WHERE RFC = @RFC";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@RegimenFiscal", txtRegimenFiscal.Text);
                comando.Parameters.AddWithValue("@DireccionFiscal", txtDireccionFiscal.Text);
                comando.Parameters.AddWithValue("@RFC", txtRFC.Text);

                try
                {
                    conexion.Open();
                    int rowsAffected = comando.ExecuteNonQuery();
                    conexion.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Emisor modificado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un emisor con ese RFC.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar emisor: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que el RFC no esté vacío
            if (string.IsNullOrWhiteSpace(txtRFC.Text))
            {
                MessageBox.Show("Por favor, ingresa el RFC para eliminar.");
                return;
            }

            // Validar el RFC
            if (!ValidarRFC(txtRFC.Text))
            {
                MessageBox.Show("El RFC ingresado no es válido.");
                return;
            }

            // Confirmación antes de eliminar
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este emisor?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Consulta SQL para eliminar el emisor
                string consulta = "DELETE FROM Emisor WHERE RFC = @RFC";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@RFC", txtRFC.Text);

                    try
                    {
                        conexion.Open();
                        int rowsAffected = comando.ExecuteNonQuery();
                        conexion.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Emisor eliminado con éxito.");
                            // Limpiar los campos del formulario
                            txtNombre.Text = "";
                            txtRegimenFiscal.Text = "";
                            txtDireccionFiscal.Text = "";
                            txtRFC.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un emisor con ese RFC.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar emisor: " + ex.Message);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que el RFC no esté vacío
            if (string.IsNullOrWhiteSpace(txtFiltrarRFC.Text))
            {
                MessageBox.Show("Por favor, ingresa el RFC para buscar.");
                return;
            }

            // Validar el RFC
            if (!ValidarRFC(txtFiltrarRFC.Text))
            {
                MessageBox.Show("El RFC ingresado no es válido.");
                return;
            }

            // Consulta SQL para buscar los datos del emisor
            string consulta = "SELECT Nombre, RegimenFiscal, DireccionFiscal FROM Emisor WHERE RFC = @RFC";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@RFC", txtFiltrarRFC.Text);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        // Rellenar los campos con los datos del emisor
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtRFC.Text = reader["RFC"].ToString();
                        txtRegimenFiscal.Text = reader["RegimenFiscal"].ToString();
                        txtDireccionFiscal.Text = reader["DireccionFiscal"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un emisor con ese RFC.");
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar emisor: " + ex.Message);
                }
            }
        }
    }
}
