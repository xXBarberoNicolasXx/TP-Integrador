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

{
    public class Movimiento
    {

        public double speedMax { get; set; }
        public double speedActual { get; set; }
        public int[] location { get; set; }
        public Movimiento(double speedMax, int[] location)
        {
            this.speedMax = speedMax;
            this.location = location;
        }

        public double CrearVelocidadActual(Operador operador)
        {
            double porcentajeVelocidad = operador.Battery.GastoBateria(operador.Battery.BatteryMax, operador.Battery.BatteryActual) / 10.0 * 5.0;
            operador.Movement.speedActual -= (operador.Movement.speedActual * porcentajeVelocidad / 100.0);
            return operador.Movement.speedActual;
            //Nicolas Barbero
        }

        public static int[] DistanciaARecorrer(int[] location, int[] destination)
        {
            int distanceX = location[0] - destination[0];
            int distanceY = location[1] - destination[1];
            int[] distance = new int[] { distanceX, distanceY };
            return distance;
        }


        public void MoverOperador(Operador operador, Map map, int[] destination)
        {
            int[] originalLocation;
            originalLocation = operador.Movement.location;
            int originalBattery;
            originalBattery = operador.Battery.BatteryActual;
            bool seMovio = false;
            bool isK9 = operador.OperatorClass == OperatorClass.K9;
            bool isM8 = operador.OperatorClass == OperatorClass.M8;
            bool isUAV = operador.OperatorClass == OperatorClass.UAV;
            int[] distance = DistanciaARecorrer(operador.Movement.location, destination);

            if (isK9 && !map.IsLago(operador.Movement.location) && operador.Movement.location != destination)
            {
                try
                {
                    while (operador.Movement.location[0] != destination[0] && operador.Battery.BatteryActual > 0 && operador.Movement.speedActual > 0 ||
                           operador.Movement.location[1] != destination[1] && operador.Battery.BatteryActual > 0 && speedActual > 0)
                    {
                        MoverOperadorHorizontal(operador, destination, map, ref seMovio);
                        if (operador.OperatorState != "BATERIA PERFORADA")
                        {
                            operador.Battery.BatteryActual = ReduccionBateria(operador, distance);
                        }
                        else
                        {
                            operador.Battery.BatteryActual = ReduccionBateria500(operador, distance);
                        }
                        VerificarLocacion(operador, map, seMovio);
                        if (!seMovio)
                        {
                            MoverOperadorVertical(operador, destination, map, ref seMovio);
                            if (operador.OperatorState != "BATERIA PERFORADA")
                            {
                                operador.Battery.BatteryActual = ReduccionBateria(operador, distance);
                            }
                            else
                            {
                                operador.Battery.BatteryActual = ReduccionBateria500(operador, distance);
                            }
                            VerificarLocacion(operador, map, seMovio);
                        }
                    }
                }
                catch (Exception cantMove)
                {
                    Console.WriteLine($"Error en el movimiento del operador: {cantMove.Message}\n" +
                                      $"El operador permanecera en su locacion original.");
                    operador.Movement.location = originalLocation;
                    operador.Battery.BatteryActual = originalBattery;
                }
            }
            else if (isM8 && !map.IsLago(operador.Movement.location) && operador.Movement.location != destination)
            {
                try
                {
                    while (operador.Movement.location[0] != destination[0] && operador.Battery.BatteryActual > 0 && speedActual > 0 ||
                           operador.Movement.location[1] != destination[1] && operador.Battery.BatteryActual > 0 && speedActual > 0)
                    {
                        MoverOperadorHorizontal(operador, destination, map, ref seMovio);
                        if (operador.OperatorState != "BATERIA PERFORADA")
                        {
                            operador.Battery.BatteryActual = ReduccionBateria(operador, distance);
                        }
                        else
                        {
                            operador.Battery.BatteryActual = ReduccionBateria500(operador, distance);
                        }
                        VerificarLocacion(operador, map, seMovio);
                        if (!seMovio)
                        {
                            MoverOperadorVertical(operador, destination, map, ref seMovio);
                            if (operador.OperatorState != "BATERIA PERFORADA")
                            {
                                operador.Battery.BatteryActual = ReduccionBateria(operador, distance);
                            }
                            else
                            {
                                operador.Battery.BatteryActual = ReduccionBateria500(operador, distance);
                            }
                            VerificarLocacion(operador, map, seMovio);
                        }
                    }
                }
                catch (Exception cantMove)
                {
                    Console.WriteLine($"Error en el movimiento del operador: {cantMove.Message}\n" +
                                      $"El operador permanecera en su locacion original.");
                    operador.Movement.location = originalLocation;
                    operador.Battery.BatteryActual = originalBattery;
                }
            }


            else if (isUAV && operador.Movement.location != destination)
                try
                {
                    while (operador.Movement.location[0] != destination[0] && operador.Battery.BatteryActual > 0 && speedActual > 0||
                           operador.Movement.location[1] != destination[1] && operador.Battery.BatteryActual > 0 && speedActual > 0)
                    {
                        MoverOperadorHorizontal(operador, destination, map, ref seMovio);
                        if (operador.OperatorState != "BATERIA PERFORADA")
                        {
                            operador.Battery.BatteryActual = ReduccionBateria(operador, distance);
                        }
                        else
                        {
                            operador.Battery.BatteryActual = ReduccionBateria500(operador, distance);
                        }
                        VerificarLocacion(operador, map, seMovio);
                        if (!seMovio)
                        {
                            MoverOperadorVertical(operador, destination, map, ref seMovio);
                            if (operador.OperatorState != "BATERIA PERFORADA")
                            {
                                operador.Battery.BatteryActual = ReduccionBateria(operador, distance);
                            }
                            else
                            {
                                operador.Battery.BatteryActual = ReduccionBateria500(operador, distance);
                            }
                            VerificarLocacion(operador, map, seMovio);
                        }
                    }
                }
                catch (Exception cantMove)
                {
                    Console.WriteLine($"Error en el movimiento del operador: {cantMove.Message}\n" +
                                      $"El operador permanecera en su locacion original.");
                    operador.Movement.location = originalLocation;
                    operador.Battery.BatteryActual = originalBattery;
                }
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
        public static int ReduccionBateria500(Operador operador, int[] distance)
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
                    operador.Battery.BatteryActual -= (int)(operador.Battery.BatteryActual * 0.5); // Resta el 50% de la batería
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
                    operador.Battery.BatteryActual -= (int)(operador.Battery.BatteryActual * 0.5); // Resta el 50% de la batería
                    distanciaBateria = 0; // Reiniciar distanciaBateria
                }
            }

            return operador.Battery.BatteryActual;
            //Nicolas Barbero
        }

        public static double VelocidadPorBateria(Operador operador)
        {
            for (int i = 0; i < (operador.Battery.GastoBateria(operador.Battery.BatteryMax, operador.Battery.BatteryActual / 10)); i++)
            {
                operador.Movement.speedActual = operador.Movement.speedActual * 0.05;
            }
            return operador.Movement.speedActual;
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

        private void MoverOperadorVertical(Operador operador, int[] destination, Map map, ref bool seMovio)
        {
            int[] originalLocation;
            originalLocation = operador.Movement.location;
            if (operador.Movement.location[0] < destination[0])
            {
                int[] nextLocation = new int[] { operador.Movement.location[0] + 1, operador.Movement.location[1] };

                if (!map.IsLago(nextLocation))
                {
                    operador.Movement.location[0]++;
                }
            }
            else if (operador.Movement.location[0] > destination[0])
            {
                int[] nextLocation = new int[] { operador.Movement.location[0] - 1, operador.Movement.location[1] };

                if (!map.IsLago(nextLocation))
                {
                    operador.Movement.location[0]--;
                }
            }
            if (operador.Movement.location != originalLocation)
            {
                seMovio = true;
            }
        }
        private void MoverOperadorHorizontal(Operador operador, int[] destination, Map map, ref bool seMovio)
        {
            int[] originalLocation;
            originalLocation = operador.Movement.location;

                if (operador.Movement.location[1] < destination[1])
            {
                // Mover hacia la derecha
                int[] nextLocation = new int[] { operador.Movement.location[0], operador.Movement.location[1] + 1 };

                if (!map.IsLago(nextLocation))
                {
                    operador.Movement.location[1]++;
                }
            }
            else if (operador.Movement.location[1] > destination[1])
            {
                // Mover hacia la izquierda
                int[] nextLocation = new int[] { operador.Movement.location[0], operador.Movement.location[1] - 1 };

                if (!map.IsLago(nextLocation))
                {
                    operador.Movement.location[1]--;
                }
            }
            if (operador.Movement.location != originalLocation)
            {
                seMovio = true;
            }
        }
        public void VerificarLocacion(Operador operador, Map map, bool seMovio)
        {
            VerificarVertedero(operador, map, seMovio);
            VerificarReciclaje(operador, map, seMovio);
            VerificarVertederoElectronico(operador, map, seMovio);
        }
        private void VerificarVertedero(Operador operador, Map map, bool seMovio)
        {
            if (seMovio && map.IsVertedero(operador.Movement.location))
            {
                operador.OperatorState = map.VertederoEfectoTerreno(operador);
            }
        }
        private void VerificarVertederoElectronico(Operador operador, Map map, bool seMovio)
        {
            if (seMovio && map.IsVertedero(operador.Movement.location))
            {
                operador.OperatorState = map.VertederoElectronicoEfectoTerreno(operador);
            }
        }
        private void VerificarReciclaje(Operador operador, Map map, bool seMovio)
        {
            if (seMovio && map.IsVertedero(operador.Movement.location))
            {
                operador.OperatorState = map.VertederoEfectoTerreno(operador);
            }
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
