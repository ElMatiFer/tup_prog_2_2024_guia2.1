using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Modeles
{
    internal class Persona
    {
        public string Dni
        {
            get; set;
        }
        public string Nombre
        {
            get; private set;
        }
        public Persona(string dni, string nombre) 
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }
    }
}
