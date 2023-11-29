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
    public class Operador
    {
        public string ID { get; set; }
        public string GeneralState { get; set; }
        public string OperatorState { get; set; }
        public Carga Carga { get; set; }
        public Bateria Battery { get; set; }
        public Movimiento Movement { get; set; }

        public static Random randy = new Random();

        public Operador(Bateria battery, string generalState, string operatorState, Carga carga, Movimiento movement)
        {
            this.ID = CreateID();
            this.Battery = battery;
            this.GeneralState = generalState;
            this.OperatorState = operatorState;
            this.Carga = carga;
            this.Movement = movement;
            //Ivan Imperiale
            movement.speedActual = CrearVelocidadActual(movement.speedActual, battery.BatteryMax, battery.BatteryActual);
        }

        private string CreateID()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] idChar = new char[6];
            for (int i = 0; i < idChar.Length; i++)
            {
                int charPosition = randy.Next(0, chars.Length - 1);
                idChar[i] = chars[charPosition];
            }
            return new string(idChar);
            //Ivan Imperiale
        }
        private double CrearVelocidadActual(double speedActual, int batteryMax, int batteryActual)
        {
            double porcentajeVelocidad = Bateria.ReduccionBateria(batteryMax, batteryActual) / 10.0 * 5.0;
            speedActual -= (speedActual * porcentajeVelocidad / 100.0);
            return speedActual;
            //Nicolas Barbero
        }

        public static int[] CrearLocacionDeOperador()
        {
            int[] location = new int[2];
            location[0] = randy.Next(0, 100);
            location[1] = randy.Next(0, 100);
            return location;
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
            this.location[][] = location[][] ;          
            //Ivan Imperiale
        }*/





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
