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

namespace integrador
{
    public class Operador
    {
        public string operadorName;
        public string operadorId;
        public int operadorBatery; 
        public string operadorState;
        public int operadorCargaMAx;
        public int operadorCargaActual;
        public double speed;
        public int location;
        private Random randy = new Random();

        public Operador()
        {
            CreateOperador();
        }

        public void CreateOperador()
        {
            operadorName = CreateName();
            operadorId = CreateId();
            operadorBatery = CreateBatery();
            operadorState = CreateGeneralState();
            operadorCargaMAx = CreateCargaMAx();
            operadorCargaActual = CreateCargaActual();
            speed = CreateSpeed();
            location = CreateLocation();
        }

        // Métodos para generar valores aleatorios
        private string CreateName()
        {
            string[] names = { "UAV", "K9", "M8" };
            int index = randy.Next(0, names.Length);
            return names[index];
        }

        private string CreateId()
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

        private int CreateBatery()
        {
            {
                int bateryMAx = 0;

                if (operadorName == "UAV")
                {
                    bateryMAx = 4000;
                }
                else if (operadorName == "K9")
                {
                    bateryMAx = 6500;
                }
                else if (operadorName == "M8")
                {
                    bateryMAx = 12250;
                }
                return bateryMAx;
            }
        }

        private string CreateGeneralState()
        {
            // Implementa la lógica para generar un estado aleatorio
            return "EstadoAleatorio";
        }

        private int CreateCargaMAx() // Cambié el tipo de retorno a string
        {
            int cargaMax = 0;

            if (operadorName == "UAV")
            {
                cargaMax = 5;
            }
            else if (operadorName == "K9")
            {
                cargaMax = 40;
            }
            else if (operadorName == "M8")
            {
                cargaMax = 250;
            }
            return cargaMax;
        }
        private int CreateCargaActual () 
        {
            int carga = 0;
            int cargaActual = 0;
            Console.WriteLine("¿cual es la carga que deberia llevar el operador?: ");
            carga= int.Parse(Console.ReadLine());
            if (carga <= operadorCargaMAx)
                    cargaActual = carga;
            else
            {
                Console.WriteLine("la carga elegida supera el peso maximo que puede manejar el operador");
            }

            return cargaActual;
        }
        private double CreateSpeed()
        {
            // Implementa la lógica para generar una velocidad aleatoria
            return randy.NextDouble() * 100;
        }

        private int CreateLocation()
        {
            List<string> ubicaciones = new List<string> { "Cuartel", "Zona de recarga", "Deposito", "Zona de trabajo", "Zona de reserva" };
            int randal = randy.Next(0, ubicaciones.Count()+1); // Generar un número aleatorio entre 0 y el número de ubicaciones
            string ubicacion = ubicaciones[randal];

            Dictionary<string, int> Localizaciones = new Dictionary<string, int>();
            Localizaciones["Cuartel"] = 234234;
            Localizaciones["Zona de recarga"] = 1453346345;
            Localizaciones["Deposito"] = 223423425;
            Localizaciones["Zona de trabajo"] = 24567567;
            Localizaciones["Zona de reserva"] = 98765168;

            return Localizaciones[ubicacion];
        }
    }
}
