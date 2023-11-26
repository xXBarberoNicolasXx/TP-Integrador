using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Operadores
{
    internal class K9 : Operador
    {
        public K9()
        {
            batteryMax = 6500;
            batteryActual = 0;
            state = "idle";
            opState = "Ok";
            cargaMax = 40;
            cargaActual = CrearCargaActual();
            speedMax = 25;
            speedActual = CrearVelocidadActual();
            location = CrearLocacionDeOperador(location);
            id = CreateId();
            CreateOperador(id, batteryMax, batteryActual, state, cargaMax, cargaActual, speedMax, speedActual, location);
        }//Ivan Imperiale

    }
}
