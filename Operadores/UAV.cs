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
            battery = 4000;
            state = "idle";
            cargaMax = 5;
            cargaActual = CrearCargaActual();
            speed = 50;
            CreateId();
            CreateOperador(battery, state, cargaMax, cargaActual, speed);
        }
            
    }
}
