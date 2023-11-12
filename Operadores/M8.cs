using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Operadores
{
    internal class M8 : Operador
    {
        public M8()
        {
            batteryMax = 6500;
            batteryActual = 0;
            state = "idle";
            cargaMax = 250;
            cargaActual = CrearCargaActual();
            speedMax = 10;
            speedActual = CrearVelocidadActual();
            location = CrearLocacionDeOperador(location);
            CreateId();
            CreateOperador(batteryMax, batteryActual, state, cargaMax, cargaActual, speedMax, speedActual, location);
            
        }
     
    }
}
