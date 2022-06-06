using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUII
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIngresoVehiculos_Click(object sender, EventArgs e)
        {
            new IngresoVehiculos().Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new IngresarPersona().Visible = true;
        }
    }
}
