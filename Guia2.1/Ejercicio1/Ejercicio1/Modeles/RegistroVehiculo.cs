using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Modeles
{
    internal class RegistroVehiculo
    {
        public string Patente
        {
            get; private set;
        }
        public string Serie
        {
            get; private set;
        }
        public Persona Propietario
        {
            get; private set;
        }

        public RegistroVehiculo(string patente, Persona propietario, int serie)
        {
            this.Patente = patente;
            this.Serie = serie.ToString();
            this.Propietario = propietario;
        }
        public string VerDetalle()
        {
            return $"Nombre: {Propietario.Nombre} Dni: {Propietario.Dni} Patente: {Patente} Serie: {Serie}";
        }
    }
}
