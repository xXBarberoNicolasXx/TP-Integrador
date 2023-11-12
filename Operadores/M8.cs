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
            battery = 6500;
            state = "idle";
            cargaMax = 250;
            cargaActual = CrearCargaActual();
            speed = 10;
            CreateId();
            CreateOperador(battery, state, cargaMax, cargaActual, speed);
        }
     
    }
}
