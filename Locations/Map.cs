using integrador.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Locations
{
    internal class Map
    {
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
        public Locations[] mapLocations = new Locations[100 * 100];

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
    }
    //IvanImperiale

}
