using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

using System;

namespace integrador.Operadores
{
    public class Bateria : Operador
    {
        int RecargarBateria(int batteryMax, int batteryActual, Operador operador)
        {
            while (batteryActual < batteryMax)
            {
                batteryActual++;
            }
            return batteryActual;
        }

        int ReduccionBateria(int batteryMax, int batteryActual) 
        {
            int porcentajeBateria;
            int reduccionBateria;
            porcentajeBateria = (batteryActual * 100) / batteryMax; // si batteryMax es el 100% de la bateria, batteryActual = porcentajeBateria 
            reduccionBateria = 100 - porcentajeBateria; // la diferencia entre 100 (batteryMax) y batteryActual es cuanto se redujo la carga 
            return reduccionBateria;
        }

    }
}