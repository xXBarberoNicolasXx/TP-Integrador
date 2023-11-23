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
    abstract class Locations
    {   public Locations() { }
        protected void CreateLocationEffect (int falla, string efectoTerreno) 
        {
            this.falla = falla;
            this.efectoTerreno = efectoTerreno;
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
                    efectoTerreno= "MOTOR COMPROMETIDO";
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

        } 
       

       


    }    
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

        }