using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Liquidacion
    {
        #region Propiedades
        public int Año { get; private set; }
        public int Mes { get; private set; }
        public double MontoBasico { get; private set; }
        public double PorcAntiguedad { get; private set; }
        public double MontoAntiguedad { get; private set; }
        public double HorasExtras50 { get; private set; }
        public double MontoExtras50 { get; private set; }
        public double HorasExtras100 { get; private set; }
        public double MontoExtras100 { get; private set; }
        public double Nominal { get; private set; }
        public double MontoObraSocial { get; private set; }
        public double MontoJubilado { get; private set; }
        public double MontoGremial { get; private set; }
        public double Neto { get; private set; }
        public double Productividad { get; private set; }
        public double ACobrar { get; private set; }
        public double PorcObraSocial { get; set; }
        public double PorcJubilado { get; set; }
        public double PorcGremiales { get; set; }
        public Empleado Empleado { get; private set; }
        #endregion

        public Liquidacion(Empleado empleado, int año, int mes)
        {
            Mes = mes;
            Año = año;
            Empleado = empleado;
        }


    }
}
