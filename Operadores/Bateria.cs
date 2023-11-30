using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using integrador.Operadores;
using System;

using System;

using System;

namespace integrador.Operadores
{
    public class Bateria
    { 
        public int BatteryMax { get; set; }
        public int BatteryActual { get; set; }
        public Bateria(int BatteryMax, int BatteryActual) 
        {
            this.BatteryMax = BatteryMax;
            this.BatteryActual = BatteryActual;
        }
        public int RecargarBateria(int batteryMax, int batteryActual)
        {
            while (batteryActual < batteryMax)
            {
                batteryActual++;
            }
            return batteryActual;
            //Nicolas Barbero
        }

        public int GastoBateria(int batteryMax, int batteryActual)  //lo hice static pa que
        {
            int porcentajeBateria;
            int gastoBateria;
            porcentajeBateria = (batteryActual * 100) / batteryMax; // si batteryMax es el 100% de la bateria, batteryActual = porcentajeBateria 
            gastoBateria = 100 - porcentajeBateria; // la diferencia entre 100 (batteryMax) y batteryActual es cuanto se redujo la carga 
            return gastoBateria;
            //Nicolas Barbero
        }

        public int DañoBateria(int batteryMax, string opState)
        {
            if (opState == "Bateria dañada, su capacidad maxima se reduce en 20%") 
            {
                double reduccion = batteryMax * 0.20; // Calcula el 20% de la batería
                batteryMax = (int)(batteryMax - reduccion);
            }
            return batteryMax;
            //Nicolas Barbero
        }

        public static int ReduccionBateria(Operador operador, int[] distance)
        {
            int distanciaARecorrerX = distance[0];
            int distanciaARecorrerY = distance[1];
            int distanciaRecorrida = 0;
            int distanciaBateria = 0;

            while (distanciaRecorrida != distanciaARecorrerX)
            {
                if (distanciaARecorrerX > 0) { distanciaRecorrida += 1; }
                else { distanciaRecorrida -= 1; }
                distanciaBateria += 1;

                if (distanciaBateria >= operador.Movement.speedMax)
                {
                    operador.Battery.BatteryActual -= (int)(operador.Battery.BatteryActual * 0.1); // Resta el 10% de la batería
                    distanciaBateria = 0; // Reiniciar distanciaBateria
                }
            }
            while (distanciaRecorrida != distanciaARecorrerY)
            {
                if (distanciaARecorrerY > 0) { distanciaRecorrida += 1; }
                else { distanciaRecorrida -= 1; }
                distanciaBateria += 1;

                if (distanciaBateria >= operador.Movement.speedMax)
                {
                    operador.Battery.BatteryActual -= (int)(operador.Battery.BatteryActual * 0.1); // Resta el 10% de la batería
                    distanciaBateria = 0; // Reiniciar distanciaBateria
                }
            }

            return operador.Battery.BatteryActual;
            //Nicolas Barbero
        }
        /*int TransferirBateria(Operador operador, int batteryMax, int batteryActual)
        {
            Console.WriteLine("A cual operador desea cargar la bateria:"); 
            Operador operadorRecibeBateria = Console.ReadLine();
            Console.WriteLine("A cual operador desea donar su bateria: ");
            Operador operadorDonaBateria = Console.ReadLine(); 
            while (operadorRecibeBateria.batteryActual < operadorRecibeBateria.batteryMax && operadorDonaBateria.batteryActual > 0)
            {
                operadorRecibeBateria.OperadorBatery++;
                operadorDonaBateria.OperadorBatery--;
                //Nicolas Barbero Nombres de variables no pegan a nada
            }
        }*/

    }
}