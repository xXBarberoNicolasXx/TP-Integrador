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
using integrador.Locations;

namespace integrador.Operadores

{    public class Movimiento
    {
    
    public double speedMax { get; set; }
    public double speedActual { get; set; }
    public int[] location { get; set; }
    public Movimiento(double speedMax, int[] location) 
        {
            this.speedMax = speedMax;
           
            this.location = location;
        }
        private static Random randy = new Random();

        
        /*public int[] CrearLocacionDeOperador(int[] location)
        {
            location[0] = randy.Next(0, 100);
            location[1] = randy.Next(0, 100);
            return location;
        }*/

        public static int[] DistanciaARecorrer(Locations.Locations[,] mapLocations, int[] location, int[] destination) 
        {
            int distanceX = location[0] - destination[0];
            int distanceY = location[1] - destination[1];
            int[] distance = new int[] {distanceX, distanceY};
            return distance;
        }



        public static int VelocidadPorBateria (Bateria batteryActual, Movimiento speedMax, int[] distance) 
        {
            Console.WriteLine("¿Cuántos kilómetros debe recorrer la unidad?");
            double distanciaARecorrerX = distance[0];
            double distanciaARecorrerY = distance[1];
            double distanciaRecorrida = 0;
            double distanciaBateria = 0;

            while (distanciaRecorrida < distanciaARecorrer)
            {
                distanciaRecorrida += 0.1;
                distanciaBateria += 0.1;

                if (distanciaBateria >= speedMax)
                {
                    batteryActual -= (int)(batteryActual * 0.1); // Resta el 10% de la batería
                    distanciaBateria = 0; // Reiniciar distanciaBateria
                }
            }

            return batteryActual;
            //Nicolas Barbero
        }
        public static void TotalRecall(Map map, List<Operador> operadores)
        {
            int cuartelI = -1;
            int cuartelJ = -1;
            for (int i = 0; i < map.mapLocations.GetLength(0); i++)
            {
                for (int j = 0; j < map.mapLocations.GetLength(1); j++)
                {
                    if (map.mapLocations[i, j] == Locations.Locations.Cuartel)
                    {
                        cuartelI = i;
                        cuartelJ = j;
                        break;
                    }
                }
                if (cuartelI != -1) break;
            }
            if (cuartelI != -1 && cuartelJ != -1)
            {
                int[] destination = new int[] { cuartelI, cuartelJ };

                foreach (Operador o in operadores)
                    if (o.Movement.location != null && o.Battery.BatteryActual != 0)
                    {
                        o.Movement.location = destination;
                    } //Falta crear e implementar la logica de movimiento por lugar
                      //Ivan Imperiale
            }
        }
        
        
        public void MoveLeft(int[] location, int[] destination)
        {
            do location[1]--;
            while (location[1] < destination[1]);
        }
        public void MoveRight(int[] location, int[] destination)
        {
            do location[1]++;
            while (location[1] > destination[1]);
        }
        public void MoveUp(int[] location, int[] destination)
        {
            do location[0]++;
            while (location[0] < destination[0]);
        }
        public void MoveDown(int[] location, int[] destination)
        {
            do location[0]--;
            while (location[0] < destination[0]);
        }
    }
}


        /* double TranspasoCarga(Operador operador, int cargaMax, int cargaActual)
        {
            Console.WriteLine("A cual operador desea transpasar la carga: ");
            Operador operadorRecibeCarga = Console.ReadLine();
            Console.WriteLine("A cual operador desea dar la carga: ");
            Operador operadorDonaCarga = Console.ReadLine();
            if (operadorRecibeCarga.cargaActual + operadorDonaCarga.cargaActual <= operadorRecibeCarga.cargaMax)
            {
                operadorRecibeCarga.cargaActual = operadorRecibeCarga.cargaActual + operadorDonaCarga.cargaActual;
            }
            else { Console.WriteLine("el peso supera la capacidad de carga del operador seleccionado"); }
        }//Nicolas Barbero /*
        // Crea operadores nuevos que no estan usando el constructor y los console readline no se guardan en ningun string, sino que estan guardandose en ese mismo operador

    }
}





/* chat gpt tiro esto, nose si implementarlo
 * double TranspasoCarga(Operador operador, int cargaMax, int cargaActual)
{
    Console.WriteLine("A cuál operador desea transferir la carga: ");
    string nombreOperadorRecibe = Console.ReadLine();

    // Encuentra el operador en la lista según su nombre (o algún identificador único)
    Operador operadorRecibeCarga = ObtenerOperadorPorNombre(nombreOperadorRecibe);

    if (operadorRecibeCarga != null)
    {
        Console.WriteLine("A cuál operador desea donar la carga: ");
        string nombreOperadorDona = Console.ReadLine();

        // Encuentra el segundo operador en la lista según su nombre
        Operador operadorDonaCarga = ObtenerOperadorPorNombre(nombreOperadorDona);

        if (operadorDonaCarga != null)
        {
            if (operadorRecibeCarga.cargaActual + operadorDonaCarga.cargaActual <= operadorRecibeCarga.cargaMax)
            {
                operadorRecibeCarga.cargaActual += operadorDonaCarga.cargaActual;
            }
            else
            {
                Console.WriteLine("El peso supera la capacidad de carga del operador receptor.");
            }
        }
        else
        {
            Console.WriteLine("No se encontró el operador que dona la carga.");
        }
    }
    else
    {
        Console.WriteLine("No se encontró el operador que recibe la carga.");
    }
}
 */