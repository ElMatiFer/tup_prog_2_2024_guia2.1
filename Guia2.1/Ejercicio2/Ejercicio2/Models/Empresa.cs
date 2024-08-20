using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Empresa
    {
        public int AñoActual { get; set; }
        ArrayList empleados = new ArrayList();
        ArrayList liquidaciones = new ArrayList();
    
        public Empleado RegistrarEmpleado(string apellido, string nombre)
        {
            Empleado empleado = new Empleado(apellido, nombre, AñoActual);
            empleados.Add(empleado);
            return empleado;
        }
        public void GeneraraLiquidaciones(int mes, int año)
        {
            foreach (Empleado i in empleados)
            {
                Liquidacion liquidacion = new Liquidacion(i, año, mes);
                liquidacion.PorcObraSocial = 3d;
                liquidacion.PorcJubilado = 18d;
                liquidacion.PorcGremiales = 1.5d;
                liquidaciones.Add(liquidacion);
            }
        }
    }
}
