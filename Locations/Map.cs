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
        public Locations[][] mapLocations = new Locations[100][];

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
            locations.Add(R);
        }

        public Locations[][] SetupMap(Locations[][] mapLocations)
        {
            for (int i = 0; i < mapX; i++)
            {
                mapLocations[i] = new Locations[100];
                for (int j = 0; j < mapY; j++)
                {
                      int assignArea = randy.Next(1, locations.Count);
                      mapLocations[i][j] =  locations[assignArea];
                }
            }
            for (int k = 0; k < cuartelMax; k++)
            {
                int a = randy.Next(0, mapX);
                int b = randy.Next(0, mapY);
                mapLocations[a][b] = locations[0];
            }
            return mapLocations;
        }



        public string PrintMap(Locations[][] mapLocations)
        {
            string output = "";
            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    if (mapLocations[i][j] is Cuartel)
                    {
                        output += "© ";
                    }
                    else if (mapLocations[i][j] is Baldio)
                    {
                        output += "Ø ";
                    }
                    else if (mapLocations[i][j] is Lago)
                    {
                        output += "≈ ";
                    }
                    else if (mapLocations[i][j] is Planicie)
                    {
                        output += "░ ";
                    }
                    else if (mapLocations[i][j] is Reciclaje)
                    {
                        output += "$ ";
                    }
                    else if (mapLocations[i][j] is Urbano)
                    {
                        output += "╬ ";
                    }
                    else if (mapLocations[i][j] is Vertedero)
                    {
                        output += "Ω ";
                    }
                    else if (mapLocations[i][j] is VertederoElectronico)
                    {
                        output += "£ ";
                    }
                    else if (mapLocations[i][j] is Bosque)
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
