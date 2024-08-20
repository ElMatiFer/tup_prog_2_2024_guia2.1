using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Empleado
    {
        public string Apellido { get; private set; }
        public string Nombre { get; private set; }
        public string ApellidoNombre { get; private set; }
        public int AñoContratado { get; private set; }
        public double MontoBasicoNominal { get; set; }
        public int HorasExtras50 { get; set; }
        public int HorasExtras100 { get; set; }

        public Empleado(string apellido, string nombre, int añoContratado) 
        {
            Apellido = apellido;
            Nombre = nombre;
            AñoContratado =  añoContratado;
            ApellidoNombre = $"{Apellido} {Nombre}";
        }
       
    }
}
