using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Locations
{
    internal class Reciclaje : Locations
    {
        public Reciclaje()
        {
        }

        public override void LocationEffect(int batteryMax, int batteryActual, Operador operador)
        {
            int RecargarBateria(int batteryMax, int batteryActual, Operador operador)
            {
                while (batteryActual < batteryMax)
                {
                    batteryActual++;
                }
                return batteryActual;
            }
        }
    }
}
