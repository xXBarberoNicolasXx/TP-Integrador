using integrador.Operadores;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Locations
{
    enum Locations
    {
        Cuartel,
        VertederoElectronico,
        Baldio,
        Bosque,        
        Lago,
        Planicie,
        Reciclaje,
        Urbano,
        Vertedero
        
    }
    
    
    
    
    
    /* abstract class Locations
    {   public Locations() { }
       protected void CreateLocationEffect (int falla, string efectoTerreno) 
        {
            this.falla = falla;
            this.efectoTerreno = efectoTerreno;
        } // no encuentra ni media variable :'v
    }  */  
}

/* al final no lo use
 *  protected static Dictionary CreateEfectoLugar(Dictionary EfectoLugar)
        {
            Dictionary<string, int> EfectoLugar = new Dictionary<string, int>();

            EfectoLugar.Add("MOTOR COMPROMETIDO", 1);
            EfectoLugar.Add("SERVO ATASCADO", 2);
            EfectoLugar.Add("BATERIA PERFORADA", 3);
            EfectoLugar.Add("PUERTO BATERIA DESCONECTADO", 4);
            EfectoLugar.Add("PINTURA RAYADA", 5);

        }*/