using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblGenerar_Click(object sender, EventArgs e)
        {

        }

        private void lblRegAlumno_Click(object sender, EventArgs e)
        {

        }

        private void lblRegPapás_Click(object sender, EventArgs e)
        {

        }

        private void lblFactEmitidas_Click(object sender, EventArgs e)
        {

        }

        private void lblEstadistica_Click(object sender, EventArgs e)
        {

        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del sistema...");
            Application.Exit();
        }

        private void btnEmisores_Click(object sender, EventArgs e)
        {
            Form4 formEmisor = new Form4();
            formEmisor.Show(); //mostrar el formulario de los emisores
        }
    }
}
