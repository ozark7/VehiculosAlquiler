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
    public partial class IngresoVehiculos : Form
    {
        public IngresoVehiculos()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox.Checked) { MessageBox.Show("Le acabas de vender el alma al diablo"); btnGuardar.Enabled = true; }
            else { btnGuardar.Enabled = false; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String placa = this.txtPlaca.Text;
            double kilometraje = Convert.ToDouble(this.txtKilometraje.Text);
            MessageBox.Show(new ServicioVehiculos().Guardar(new Vehiculo(placa, kilometraje)));
            txtKilometraje.Clear();
            txtPlaca.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
