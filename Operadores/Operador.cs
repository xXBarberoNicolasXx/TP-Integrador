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
        protected int battery;
        protected int cargaMax;
        protected int cargaActual;
        protected double speed;
        public static Random randy = new Random();

        public Operador()
        {
        }

        protected void CreateOperador(int battery, string state, int cargaMax, int cargaActual, double speed)
        {
            this.battery = battery;
            this.state = state;
            this.cargaMax = cargaMax;
            this.cargaActual = cargaActual;
            this.speed = speed;
        }

        // Métodos para generar valores aleatorios

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
        }

        protected int CrearCargaActual()
        {
            int cargaActual = randy.Next(0, cargaMax);
            return cargaActual;
        }
    }
}
