using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Locations
{
    internal class VertederoElectronico : Locations
    {
        public VertederoElectronico()
        {
        }
        protected static int CreateEfectoTerreno(int falla, string efectoTerreno)
        {
            Random random = new Random();
            int probabilidad = random.Next(0, 100);
            if (probabilidad < 20)
            {
                efectoTerreno = "Bateria dañada, su capacidad maxima se reduce en 20%";
                return efectoTerreno;
            }
        }
    }//Nicolas Barbero
}
