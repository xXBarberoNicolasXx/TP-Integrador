using integrador.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Locations
{
    internal class Vertedero : Locations
    {
        public Vertedero()
        {
        }
        protected static int CreateFalla(int falla)
        {
            Random random = new Random();
            int probabilidad = random.Next(0, 100);
            if (probabilidad < 5)
            {
                falla = probabilidad;
                return falla;
            }
        }
        public static string CreateEfectoTerreno(int falla, string efectoTerreno)
        {
            switch (falla)
            {
                case 1:
                    efectoTerreno = "MOTOR COMPROMETIDO";
                    break;
                case 2:
                    efectoTerreno = "SERVO ATASCADO";
                    break;
                case 3:
                    efectoTerreno = "BATERIA PERFORADA";
                    break;
                case 4:
                    efectoTerreno = "PUERTO BATERIA DESCONECTADO";
                    break;
                case 5:
                    efectoTerreno = "PINTURA RAYADA";
                    break;

                default:
                    efectoTerreno = "NINGUNO";
                    break;
            }
            return efectoTerreno;
            //Nicolas Barbero
        }
    }
}
