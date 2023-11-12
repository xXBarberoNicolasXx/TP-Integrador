using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Locations
{
    abstract class Locations
    {   protected Locations(int x, int y) { }

        public abstract void LocationEffect();
    }

    
}

