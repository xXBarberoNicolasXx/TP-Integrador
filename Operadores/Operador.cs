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
    public abstract class Operador
    {
        public string ID { get; set; }
        protected string GeneralState { get; set; }
        protected string OperatorState { get; set; }
        protected int CargaMax { get; set; }
        protected int CargaActual { get; set; }
        protected Bateria Battery { get; set; }
        protected Movimiento Movement { get; set; }

        protected static Random randy = new Random();

        protected Operador()
        {
        }

        /*protected void CreateOperador(string id,  int batteryMax,int batteryActual, string generalState, string operatorState, int cargaMax, int cargaActual, double speedMax, double speedActual, int[] location)
        {
            this.id = CreateId(id);
            this.batteryMax = batteryMax;
            this.batteryActual = batteryActual;
            this.generalState = generalState;
            this.operatorState = operatorState;
            this.cargaMax = cargaMax;
            this.cargaActual = cargaActual;
            this.speedMax = speedMax;
            this.speedActual = speedActual;
            this.location = location;          
            //Ivan Imperiale
        }*/

        public abstract string CreateId(string id);
        

        protected int CrearCargaActual()
        {
            int cargaActual = randy.Next(0, CargaMax);
            return cargaActual;
            //Ivan Imperiale
        }

        /*protected double CrearVelocidadActual(double speedMax)
        {
            double speedActual = speedMax;
            int porcentajeBateria;
            int A;
            double porcentajeVelocidad;
            porcentajeBateria = (cargaActual * 100) / cargaMax; // si cargaMax es el 100% de la bateria, cargaActual = porcentajeBateria 
            A = 100 - porcentajeBateria; // la diferencia entre 100 (cargaMax) y porcentajeBateria es cuanto se redujo la carga 
            porcentajeVelocidad = (A / 10.0) * 5.0;
            speedActual -= (speedActual * porcentajeVelocidad / 100.0);
            return speedActual;
            //Nicolas Barbero //esto ahora esta en movimiento
        }*/

        protected int[] CrearLocacionDeOperador(int[] location)
        {
            location[0] = randy.Next(0, 100);
            location[1] = randy.Next(0, 100);
            return location;
        }

        /*protected string CreateOpState(int falla, string opState)
        {
            string efectoTerreno = Locations.Locations.CreateEfectoTerreno(falla, opState);
            opState = efectoTerreno;
            return opState;
            //Nicolas Barbero
        // No recibe ni pega ne ningun operador, y las variables estan con nombres distintos
        }*/
    }
}
