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

        private Locations[][] CreateMap()
        {
            Locations[][] map = new Locations[100][];

            for (int i = 0; i < mapX; i++)
            {
                map[i] = new Locations[100];
                for (int j = 0; j < mapY; j++)
                {
                    if (map[i][j] == null)
                    {
                        int assignArea = randy.Next(1, locations.Count);
                        map[i][j] = locations[assignArea];
                    }
                }
            }
            for (int k = 0; k < cuartelMax; k++)
            {
                int a = randy.Next(0, mapX);
                int b = randy.Next(0, mapY);
                map[a][b] = locations[0];
            }
            return map;
        }



        public void PrintMap()
        {
            Locations[][] map = CreateMap();
            string output = "";
            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    if (map[i][j] is Cuartel)
                    {
                        output += "© ";
                    }
                    else if (map[i][j] is Baldio)
                    {
                        output += "Ø ";
                    }
                    else if (map[i][j] is Lago)
                    {
                        output += "≈ ";
                    }
                    else if (map[i][j] is Planicie)
                    {
                        output += "░ ";
                    }
                    else if (map[i][j] is Reciclaje)
                    {
                        output += "$ ";
                    }
                    else if (map[i][j] is Urbano)
                    {
                        output += "╬ ";
                    }
                    else if (map[i][j] is Vertedero)
                    {
                        output += "Ω ";
                    }
                    else if (map[i][j] is VertederoElectronico)
                    {
                        output += "£ ";
                    }
                    else if (map[i][j] is Bosque)
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
            Console.WriteLine(output);
        }
    }
//IvanImperiale
    
}
