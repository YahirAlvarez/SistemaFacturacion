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
            conexion.Open();
            string consulta = "SELECT * FROM Usuarios WHERE Usuario='"+txtUsuario.Text+"'AND Contraseña='"+txtContraseña.Text+"'";
            SqlCommand comando = new SqlCommand(consulta,conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if(lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido al sistema Alab");
                this.Hide();
                Form2 formOpciones = new Form2();
                formOpciones.Show();
            }
            else
            {
                MessageBox.Show("Usuario o ontraseña incorrectos");
            }
            conexion.Close();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
