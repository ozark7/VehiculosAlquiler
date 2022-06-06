using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerDeVehiculos
{
    public partial class IngresarVehiculo : Form
    {
        public IngresarVehiculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked) { btnGuardar.Enabled = true; }
        }

        private void IngresarVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
