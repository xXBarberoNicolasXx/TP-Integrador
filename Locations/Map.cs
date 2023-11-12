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
                int x, y;

                do
                {
                    x = randy.Next(0, 100);
                    y = randy.Next(0, 100);
                } while (!usedCoordinates.Add((x, y)));

                    Cuartel cuartel = new Cuartel(x, y);
                    locations.Add(cuartel);

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Bosque(x, y));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Baldio(x, y));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Planicie(x, y));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Reciclaje(x, y));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Urbano(x, y));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Vertedero(x, y));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new VertederoElectronico(x, y));
                    }

                    for (int j = 0; j < randy.Next(0, 10); j++)
                    {
                        locations.Add(new Lago(x, y));
                    }
                }
        }
    }
    
}
