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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-9AO7TKC\\SQLEXPRESS;database=SystemFacturacion; integrated security=true");
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Verificar las credenciales
    string consultaLogin = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@Usuario AND Contraseña=@Contraseña";

            using (SqlCommand comando = new SqlCommand(consultaLogin, conexion))
            {
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                conexion.Open();
                int userCount = (int)comando.ExecuteScalar();
                conexion.Close();

                // Si las credenciales son correctas
                if (userCount > 0)
                {
                    // Verificar si hay un emisor registrado
                    VerificarEmisor();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Intenta de nuevo.");
                }
            }
        }

        private void VerificarEmisor()
        {
            // Consulta para verificar si ya existe un emisor
            string consultaEmisor = "SELECT COUNT(*) FROM Emisor";

            using (SqlCommand comando = new SqlCommand(consultaEmisor, conexion))
            {
                conexion.Open();
                int emisorCount = (int)comando.ExecuteScalar();
                conexion.Close();

                if (emisorCount == 0)
                {
                    // Si no hay emisor, abrir el formulario de registro del emisor
                    MessageBox.Show("No hay ningún emisor registrado. Debe registrar uno para continuar.");
                    Form4 formRegistroEmisor = new Form4();
                    formRegistroEmisor.ShowDialog();

                    // Verificar nuevamente si se ha registrado el emisor
                    VerificarEmisor(); // Esto permitirá que el usuario registre y luego acceda al menú
                }
                else
                {
                    // Si ya hay un emisor, se puede acceder al menú principal
                    MostrarMenuPrincipal();
                }
            }
        }

        private void MostrarMenuPrincipal()
        {
            // Abrir el formulario del menú principal
            Form2 formMenuPrincipal = new Form2();
            formMenuPrincipal.Show();
            this.Hide(); // Ocultar el formulario de login
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close(); //cerar el programa
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form3 formRegistrar = new Form3();
            formRegistrar.Show(); //mostrar el formulario de registrr
        }
    }
}
