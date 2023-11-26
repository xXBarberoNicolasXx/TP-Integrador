using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Locations
{
    internal class Cuartel : Locations

    {
        public Cuartel()
        {
        }

        public override void LocationEffect()
        {
            int RecargarBateria(int batteryMax, int batteryActual, Operador operador)
            {
                while (batteryActual < batteryMax)
                {
                    batteryActual++;
                }
                return batteryActual;
            }
            int DepositoCarga(int cargaActual)
            { 
                int depositoCuartel;
                depositoCuartel = cargaActual;
                cargaActual = 0;
                return cargaActual;
                return depositoCuartel; // pongo el return por si en algun momento necesitamos saber cuanta carga hay en el deposito 
            }

            string  Reparacion (string opState)
            {
                opState= "Ok";
            }
    }
}
