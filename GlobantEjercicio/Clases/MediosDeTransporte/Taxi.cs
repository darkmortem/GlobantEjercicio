﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobantEjercicio.Clases.MediosDeTransporte
{
    /// <summary>  
    ///  La clase Taxi describe un tipo de transporte y hereda de la clase medio de transporte.
    /// </summary> 
    class Taxi : MedioDeTransporte
    {
        public Taxi(string nombre)
        {
            this.TipoUnidadGetSet = nombre;
            this.MinutosTotal = 0;
        }
        public override void MinutosEnViaje(int minutos)
        {
            this.MinutosTotal += minutos;
        }
    }
}
