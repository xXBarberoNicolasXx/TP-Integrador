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
            battery = 6500;
            state = "idle";
            cargaMax = 40;
            cargaActual = CrearCargaActual();
            speed = 25;
            CreateId();
            CreateOperador(battery, state, cargaMax, cargaActual, speed);
        }
    
    }
}
