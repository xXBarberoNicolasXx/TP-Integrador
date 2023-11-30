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
            static int DepositoCarga(Operador operador)
            {
                int depositoCuartel;
                depositoCuartel = operador.Carga.CargaActual;
                operador.Carga.CargaActual = 0;
                return operador.Carga.CargaActual;
                //return depositoCuartel; // pongo el return por si en algun momento necesitamos saber cuanta carga hay en el deposito
                //lo comento xq si quiere retornar eso nos va a rompe to'
            }

            string Reparacion(Operador operador)
            {
                operador.OperatorState = "OK";
                return operador.OperatorState;
            }
        
    }
}
