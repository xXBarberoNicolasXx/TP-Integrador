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
        public int falla;
        falla = 0; 
        public override void LocationEffect()
        {
            Random random = new Random();
            int probabilidad = random.Next(0, 100);
            if (probabilidad < 5)
            {
                
                return falla; 
            }
            else
            {
                
            }
        }
    }
}
