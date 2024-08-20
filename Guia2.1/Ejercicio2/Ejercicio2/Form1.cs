using Ejercicio2.Forms;
using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class fLiquidacion : Form
    {
        public fLiquidacion()
        {
            InitializeComponent();
        }

        private void btRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            fRegistrarEmpleado vRegistrar = new fRegistrarEmpleado();

            if (vRegistrar.ShowDialog() == DialogResult.OK)
            {
            
                
            }

        }
    }
}
