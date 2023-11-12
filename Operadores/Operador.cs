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
        protected string state;
        protected int batteryMax;
        protected int batteryActual;
        protected int cargaMax;
        protected int cargaActual;
        protected double speedMax;
        protected double speedActual;
        public static Random randy = new Random();

        public Operador()
        {
        }

        protected void CreateOperador(int batteryMax,int batteryActual, string state, int cargaMax, int cargaActual, double speedMax, double speedActual)
        {
            this.batteryMax = batteryMax;
            this.batteryActual = batteryActual;
            this.state = state;
            this.cargaMax = cargaMax;
            this.cargaActual = cargaActual;
            this.speedMax = speedMax;
            this.speedActual = speedActual;
            //Ivan Imperiale
        }

        protected static string CreateId()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] id = new char[6];
            for (int i = 0; i < id.Length; i++)
            {
                int charPosition = randy.Next(0, chars.Length - 1);
                id[i] = chars[charPosition];
            }
            return new string(id);
            //Ivan Imperiale
        }

        protected int CrearCargaActual()
        {
            int cargaActual = randy.Next(0, cargaMax);
            return cargaActual;
            //Ivan Imperiale
        }

        protected double CrearVelocidadActual()
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
            //Nicolas Barbero
        }
    }
}
