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
    public abstract class Movimiento
    {
        double CrearVelocidadActual(double speedMax, double speedActual, int batteryMax, int batteryActual)
        {
            double porcentajeVelocidad = (Bateria.ReduccionBateria(batteryMax, batteryActual) / 10.0) * 5.0;
            speedActual -= (speedActual * porcentajeVelocidad / 100.0);
            return speedActual;
            //Nicolas Barbero
        }

        int MovimientoBateria(int batteryActual, double speedMax)
        {
            Console.WriteLine("¿Cuántos kilómetros debe recorrer la unidad?");
            double distanciaARecorrer = double.Parse(Console.ReadLine());
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


        double TranspasoCarga(Operador operador, int cargaMax, int cargaActual;)
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
        }//Nicolas Barbero
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