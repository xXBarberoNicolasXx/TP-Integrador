using integrador.Locations;
using integrador.Operadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Locations
{
    public class Map

    {
        private int mapX = 100;
        private int mapY = 100;
        private int reciclajeMax = 4;
        private Random randy = new Random();
        public Locations[,] mapLocations;

        public Map()
        {
            mapLocations = new Locations[mapX, mapY];
        }

        public void SetupMap()
        {
            int last = GetLastEnumValue();
            int x;
            int y;

            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    mapLocations[i, j] = (Locations)randy.Next(2, last);
                }
            }

            for (int k = 0; k < reciclajeMax; k++)
            {
                x = randy.Next(0, mapX);
                y = randy.Next(0, mapY);
                mapLocations[x, y] = Locations.Reciclaje;
            }
            x = randy.Next(0, mapX);
            y = randy.Next(0, mapY);
            mapLocations[x, y] = Locations.Cuartel;
        }
        static int GetLastEnumValue()
        {
            Array enumLast = Enum.GetValues(typeof(Locations));
            return enumLast.Length - 1;
        }
        public int[] GetCuartelCoordinates()
        {
            int[] coordinates = new int[2];
            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    if (mapLocations[i, j] == Locations.Cuartel)
                    {
                        coordinates[0] = i; coordinates[1] = j;
                        return coordinates;
                    }
                }
            }
            return null;
        }
        public static List<int[]>? GetLagoCoordinates(Locations[,] mapLocations)
        {
            List<int[]> coordinatesList = new List<int[]>();

            int mapX = mapLocations.GetLength(0);
            int mapY = mapLocations.GetLength(1);

            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    if (mapLocations[i, j] == Locations.Lago)
                    {
                        int[] coordinates = { i, j };
                        coordinatesList.Add(coordinates);
                    }
                }
            }

            return coordinatesList.Count > 0 ? coordinatesList : null;
        }
        public static List<int[]>? GetVertederoCoordinates(Locations[,] mapLocations)
        {
            List<int[]> coordinatesList = new List<int[]>();

            int mapX = mapLocations.GetLength(0);
            int mapY = mapLocations.GetLength(1);

            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    if (mapLocations[i, j] == Locations.Vertedero)
                    {
                        int[] coordinates = { i, j };
                        coordinatesList.Add(coordinates);
                    }
                }
            }

            return coordinatesList.Count > 0 ? coordinatesList : null;
        }
        public static List<int[]>? GetVertederoElectronicoCoordinates(Locations[,] mapLocations)
        {
            List<int[]> coordinatesList = new List<int[]>();

            int mapX = mapLocations.GetLength(0);
            int mapY = mapLocations.GetLength(1);

            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    if (mapLocations[i, j] == Locations.VertederoElectronico)
                    {
                        int[] coordinates = { i, j };
                        coordinatesList.Add(coordinates);
                    }
                }
            }

            return coordinatesList.Count > 0 ? coordinatesList : null;
        }
        public static List<int[]>? GetReciclajeCoordinates(Locations[,] mapLocations)
        {
            List<int[]> coordinatesList = new List<int[]>();

            int mapX = mapLocations.GetLength(0);
            int mapY = mapLocations.GetLength(1);

            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    if (mapLocations[i, j] == Locations.Reciclaje)
                    {
                        int[] coordinates = { i, j };
                        coordinatesList.Add(coordinates);
                    }
                }
            }

            return coordinatesList.Count > 0 ? coordinatesList : null;
        }


        public bool IsLago(int[] location)
        {
            List<int[]>? lagoCoordinates = Map.GetLagoCoordinates(mapLocations);

            foreach (var lago in lagoCoordinates)
            {
                int x = lago[0];
                int y = lago[1];

                if (mapLocations[x, y] == Locations.Lago)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsVertedero(int[] location)
        {
            List<int[]>? vertederoCoordinates = Map.GetVertederoCoordinates(mapLocations);

            foreach (var vertedero in vertederoCoordinates)
            {
                int x = vertedero[0];
                int y = vertedero[1];
                if (mapLocations[x, y] == Locations.Vertedero)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsVertederoElectronico(int[] location)
        {
            List<int[]>? vertederoElectronicoCoordinates = Map.GetVertederoElectronicoCoordinates(mapLocations);

            foreach (var vertederoElectronico in vertederoElectronicoCoordinates)
            {
                int x = vertederoElectronico[0];
                int y = vertederoElectronico[1];
                if (mapLocations[x, y] == Locations.Vertedero)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsReciclaje(int[] location)
        {
            List<int[]>? reciclajeCoordinates = Map.GetReciclajeCoordinates(mapLocations);

            foreach (var reciclaje in reciclajeCoordinates)
            {
                int x = reciclaje[0];
                int y = reciclaje[1];
                if (mapLocations[x, y] == Locations.Vertedero)
                {
                    return true;
                }
            }
            return false;
        }

        public string PrintMap()
        {
            string output = "";

            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    Locations location = mapLocations[i, j];

                    if (location is Locations.Cuartel)
                    {
                        output += "© ";
                    }
                    else if (location is Locations.Baldio)
                    {
                        output += "Ø ";
                    }
                    else if (location is Locations.Lago)
                    {
                        output += "≈ ";
                    }
                    else if (location is Locations.Planicie)
                    {
                        output += "░ ";
                    }
                    else if (location is Locations.Reciclaje)
                    {
                        output += "$ ";
                    }
                    else if (location is Locations.Urbano)
                    {
                        output += "╬ ";
                    }
                    else if (location is Locations.Vertedero)
                    {
                        output += "Ω ";
                    }
                    else if (location is Locations.VertederoElectronico)
                    {
                        output += "£ ";
                    }
                    else if (location is Locations.Bosque)
                    {
                        output += "♣ ";
                    }
                    else
                    {
                        output += "   ";
                    }
                }
                output += "\n";
            }
            return output;
        }

        public string VertederoEfectoTerreno(Operador operador)
        {
            Random randy = new Random();
            int probabilidad = randy.Next(0, 100);
            int falla;
            if (probabilidad < 5)
            {
                falla = probabilidad;


                switch (falla)
                {
                    case 1:
                        operador.OperatorState = "MOTOR COMPROMETIDO";
                        return operador.OperatorState;
                    case 2:
                        operador.OperatorState = "SERVO ATASCADO";
                        return operador.OperatorState;
                    case 3:
                        operador.OperatorState = "BATERIA PERFORADA";
                        return operador.OperatorState;
                    case 4:
                        operador.OperatorState = "PUERTO BATERIA DESCONECTADO";
                        return operador.OperatorState;
                    case 5:
                        operador.OperatorState = "PINTURA RAYADA";
                        return operador.OperatorState;

                    default:
                        operador.OperatorState = "OK";
                        return operador.OperatorState;
                }

            }
            return operador.OperatorState;

        }

        public void ReciclajeEfectoTerreno(Operador operador)
        {
            operador.Battery.RecargarBateria(operador.Battery.BatteryMax, operador.Battery.BatteryActual);
        }
        public string VertederoElectronicoEfectoTerreno(Operador operador)
        {
            Random randy = new Random();
            int probabilidad = randy.Next(0, 100);
            if (probabilidad < 15)
            {
                operador.OperatorState = "BATERIA DAÑADA";
            }
            return operador.OperatorState;
        }












        /* {
        private int mapX = 100;
        private int mapY = 100;
        private int cuartelMax = 2;
        private int reciclajeMax = 4;
        private Random randy = new Random();
        public List<Locations> locations = new List<Locations>();
        private Baldio ß = new Baldio();
        private Bosque B = new Bosque();
        private Cuartel C = new Cuartel();
        private Planicie P = new Planicie();
        private Lago L = new Lago();
        private Reciclaje R = new Reciclaje();
        private Urbano U = new Urbano();
        private Vertedero V = new Vertedero();
        private VertederoElectronico E = new VertederoElectronico();
        public Locations[,] mapLocations = new Locations[100, 100];

        public Map()
        {
            locations.Add(C);
            locations.Add(ß);
            locations.Add(B);
            locations.Add(P);
            locations.Add(L);
            locations.Add(U);
            locations.Add(V);
            locations.Add(E);
        }

        
        public Locations[] SetupMap()
        {
            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    int assignArea = randy.Next(1, locations.Count);
                    mapLocations[i * mapX + j] = locations[assignArea];
                }
            }

            for (int k = 0; k < cuartelMax; k++)
            {
                int a = randy.Next(0, mapX);
                int b = randy.Next(0, mapY);
                mapLocations[a * mapX + b] = locations[0];
            }

            for (int k = 0; k < reciclajeMax; k++)
            {
                int a = randy.Next(0, mapX);
                int b = randy.Next(0, mapY);
                mapLocations[a * mapX + b] = locations[0];
            }

            return mapLocations;
        }

        public string PrintMap()
        {
            string output = "";
            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    Locations location = mapLocations[i * mapX + j];

                    if (location is Cuartel)
                    {
                        output += "© ";
                    }
                    else if (location is Baldio)
                    {
                        output += "Ø ";
                    }
                    else if (location is Lago)
                    {
                        output += "≈ ";
                    }
                    else if (location is Planicie)
                    {
                        output += "░ ";
                    }
                    else if (location is Reciclaje)
                    {
                        output += "$ ";
                    }
                    else if (location is Urbano)
                    {
                        output += "╬ ";
                    }
                    else if (location is Vertedero)
                    {
                        output += "Ω ";
                    }
                    else if (location is VertederoElectronico)
                    {
                        output += "£ ";
                    }
                    else if (location is Bosque)
                    {
                        output += "♣ ";
                    }
                    else
                    {
                        output += "   ";
                    }
                }
                output += "\n";
            }
            return output;
        }
    }*/

        //IvanImperiale

    }
}
