﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Modeles
{
    internal class DepartamentoVehicular
    {
        Random azar = new Random();
        int nroRegistro;
        int nroSerie;

        ArrayList registros = new ArrayList();

        public int CantidadRegistros
        {
            get
            {
                return registros.Count;
            }
        }

        private string GenerarPatente()
        {
            int nroCarac = azar.Next(100);

            char C1 = (char)azar.Next((int)'A', (int)'Z' + 1);
            char C2 = (char)azar.Next((int)'A', (int)'Z' + 1);

            string patente = $"{C1}{C2}{nroRegistro++:000}";

            return patente;
        }


        public RegistroVehiculo RegistrarVehiculo(Persona propietario)
        {
            string patente = GenerarPatente();
            int serie = nroSerie++;
            RegistroVehiculo registroVehiculo = new RegistroVehiculo(patente, propietario, serie);
            registros.Add(registroVehiculo);
            return registroVehiculo;
        }

        public RegistroVehiculo VerRegistro(int i)
        {
            if (i >= 0 && i < CantidadRegistros)
            {
                return registros[i] as RegistroVehiculo;
            }
            return null;
        }
    }
}
