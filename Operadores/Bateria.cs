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
        int RecargarBateria(int batteryMax, int batteryActual)
        {
            while (batteryActual < batteryMax)
            {
                batteryActual++;
            }
            return batteryActual;
            //Nicolas Barbero
        }

        int ReduccionBateria(int batteryMax, int batteryActual) 
        {
            int porcentajeBateria;
            int reduccionBateria;
            porcentajeBateria = (batteryActual * 100) / batteryMax; // si batteryMax es el 100% de la bateria, batteryActual = porcentajeBateria 
            reduccionBateria = 100 - porcentajeBateria; // la diferencia entre 100 (batteryMax) y batteryActual es cuanto se redujo la carga 
            return reduccionBateria;
            //Nicolas Barbero
        }

        public string int DañoBateria(int batteryMax, string opState)
        {
            if (opState == "Bateria dañada, su capacidad maxima se reduce en 20%") 
            {
                double reduccion = batteryMax * 0.20; // Calcula el 20% de la batería
                batteryMax = (int)(batteryMax - reduccion);
            }
            return batteryMax;
            //Nicolas Barbero
        }
        int TransferirBateria(Operadores operador, int batteryMax, int batteryActual)
        {
            Console.WriteLine("A cual operador desea cargar la bateria:"); 
            Operador operadorRecibeBateria = Console.ReadLine();
            Console.WriteLine("A cual operador desea donar su bateria: ");
            Operador operadorDonaBateria = Console.ReadLine(); 
            while (operadorRecibeBateria.batteryActual < operadorRecibeBateria.batteryMax && operadorDonaBateria.batteryActual > 0)
            {
                operadorRecibeBateria.OperadorBatery++;
                operadorDonaBateria.OperadorBatery--;
                //Nicolas Barbero
            }
        }

    }
}