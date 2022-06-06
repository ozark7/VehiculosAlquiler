using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;
namespace PresentacionGUII
{
    public partial class IngresarPersona : Form
    {
        public IngresarPersona()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void IngresarPersona_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona;
            if (ComboTipoPersona.Text.Equals("Ocasional"))
            {
                persona = new Ocasional();
                persona.Id = txtId.Text;
                persona.Nombre=txtNombre.Text;
            }
            else
            {
                persona = new PorContrato();
                persona.Id = txtId.Text;
                persona.Nombre = txtNombre.Text;
            }
            MessageBox.Show(new ServicioPersonas().Guardar(persona));
            txtId.Clear();
            txtNombre.Clear();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
