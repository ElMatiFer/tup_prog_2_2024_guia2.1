using Ejercicio1.Forms;
using Ejercicio1.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class fPrincipal : Form
    {
        DepartamentoVehicular depto = new DepartamentoVehicular();
        public fPrincipal()
        {
            InitializeComponent(); 
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            fRegistrar vRegistro = new fRegistrar();    

            if (vRegistro.ShowDialog() == DialogResult.OK)
            {
                string nombre = vRegistro.tbNombre.Text;
                string dni = vRegistro.tbDni.Text;
                Persona nuevo = new Persona(dni, nombre);

                RegistroVehiculo registro = depto.RegistrarVehiculo(nuevo);
            }
        }
        private void btListarRegistros_Click(object sender, EventArgs e)
        {
            lbListarRegistros.Items.Clear();
            for (int i = 0; i < depto.CantidadRegistros; i++)
            {
                RegistroVehiculo registro = depto.VerRegistro(i);
                lbListarRegistros.Items.Add(registro.VerDetalle());
            }
        }
    }
}
