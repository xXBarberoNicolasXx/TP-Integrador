using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

using System;

namespace integrador.Operadores
{
    public class Carga 
    {
        protected int CargaMax { get; set; }
        protected int CargaActual { get; set; }

        private Random randy = new Random();

        public Carga(int CargaMax, int CargaActual) 
        {
            this.CargaMax = CargaMax;
            this.CargaActual = CrearCargaActual();
        }
       
        /*double LevantamientoCarga(Operador operador, string opState, int cargaMax, int cargaActual)
        {
            if (opState != "SERVO ATASCADO")
            {
                if (cargaActual != cargaMax) { cargaActual = cargaMax}
                else { Console.WriteLine("El operador llego a su maximo de carga")}
            }
            else {Console.WriteLine("SERVO ATASCADO, no se puede realizar acciones")}
        } //Nicolas Barbero

        double TranspasoCarga(Operador operador, int cargaMax, int cargaActual)
        {
            Console.WriteLine("A cual operador desea transpasar la carga: ");
            Operador operadorRecibeCarga = Console.ReadLine();
            Console.WriteLine("A cual operador desea dar la carga: ");
            Operador operadorDonaCarga = Console.ReadLine();
            if (operadorRecibeCarga.cargaActual + operadorDonaCarga.cargaActual <= operadorRecibeCarga.cargaMax)
            {
                operadorRecibeCarga.cargaActual = operadorRecibeCarga.cargaActual + operadorDonaCarga.cargaActual;
            }
            else { Console.WriteLine("el peso supera la capacidad de carga del operador seleccionado"); }
        }//Nicolas Barbero*/

        public int DepositarCarga(int cargaActual) 
        {
            Console.WriteLine("¿Desa depositar la carga actual?: SI/NO");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta == "si")
            {
                cargaActual = 0;
                Console.WriteLine("Se a depositado la carga");
                return cargaActual;
            }
            else if (respuesta == "no") { Console.WriteLine("No se depositara la carga"); return cargaActual; }
            else { Console.WriteLine("Respues no valida"); return cargaActual; }
        }
        protected int CrearCargaActual()
        {
            int cargaActual = randy.Next(0, CargaMax);
            return cargaActual;
            //Ivan Imperiale
        }





    }
}