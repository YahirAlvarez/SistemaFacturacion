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

namespace SistemaFacturacion
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-9AO7TKC\\SQLEXPRESS;database=SystemFacturacion; integrated security=true");
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                cBoxPuestos.SelectedItem == null)
            {
                // Mostrar un mensaje si hay algún campo vacío
                MessageBox.Show("Todos los campos son obligatorios. Por favor, completa toda la información.");
                return; // Detener la ejecución si algún campo está vacío
            }
            conexion.Open();
            string consulta = "INSERT INTO Usuarios (Nombre, Apellido, Puesto, Usuario, Contraseña) " +
                  "VALUES (@Nombre, @Apellido, @Puesto, @Usuario, @Contraseña)";            

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                //comando.Parameters.AddWithValue("@idUsuario",1+"idUsuario");
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                comando.Parameters.AddWithValue("@Puesto", cBoxPuestos.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                // Ejecutas la consulta
                comando.ExecuteNonQuery();
            }
            MessageBox.Show("El usuario fue registrado correctamente.");
            this.Hide();
        }
    }
}
