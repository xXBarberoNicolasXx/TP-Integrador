using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Operadores
{
    internal class UAV : Operador
    {
        public UAV()
        {
            batteryMax = 4000;
            batteryActual = 0;
            state = "idle";
            cargaMax = 5;
            cargaActual = CrearCargaActual();
            speedMax = 50;
            speedActual = CrearVelocidadActual();
            location = CrearLocacionDeOperador(location);
            id = CreateId();
            CreateOperador(id, batteryMax, batteryActual, state, cargaMax, cargaActual, speedMax, speedActual, location);
        }
            
    }
}
