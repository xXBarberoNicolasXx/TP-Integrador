using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using integrador.Operadores;

namespace integrador.Locations
{
    internal class Cuartel

    {
        public Cuartel()
        {
        }
        int RecargarBateria(Operador operador)
        {
            while (operador.Battery.BatteryActual < operador.Battery.BatteryMax)
            {
                operador.Battery.BatteryActual++;
            }
            return operador.Battery.BatteryActual;
            }
            int DepositoCarga(int cargaActual, Operador operador)
            {
                int depositoCuartel;
                depositoCuartel = cargaActual;
                cargaActual = 0;
                return cargaActual;
                //return depositoCuartel; // pongo el return por si en algun momento necesitamos saber cuanta carga hay en el deposito
                //lo comento xq si quiere retornar eso nos va a rompe to'
            }

            string Reparacion(string opState, Operador operador)
            {
                opState = "Ok";
                return opState;
            }
        
    }
}
