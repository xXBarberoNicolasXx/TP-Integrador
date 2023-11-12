using integrador.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Locations
{
    internal class Map

    {   
        public Map()
        {
            List<Locations> locations = new List<Locations>();
            CreateMap(locations);
        }
                  
        private void CreateMap(List<Locations> locations)
            {
                Random randy = new Random();
            HashSet<(int, int)> usedCoordinates = new HashSet<(int, int)>();

            for (int i = 0; i < 1000; i++)
            {
                int[] coordinates = new int[2];

                do
                {
                    coordinates[0] = randy.Next(0, 100);
                    coordinates[1] = randy.Next(0, 100);
                } while (!usedCoordinates.Add((coordinates[0], coordinates[1])));

                    Cuartel cuartel = new Cuartel(coordinates[0], coordinates[1]);
                    locations.Add(cuartel);

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Bosque(coordinates[0], coordinates[1]));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Baldio(coordinates[0], coordinates[1]));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Planicie(coordinates[0], coordinates[1]));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Reciclaje(coordinates[0], coordinates[1]));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Urbano(coordinates[0], coordinates[1]));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Vertedero(coordinates[0], coordinates[1]));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new VertederoElectronico(coordinates[0], coordinates[1]));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Lago(coordinates[0], coordinates[1]));
                    }
                }
        }
    }
    
}
