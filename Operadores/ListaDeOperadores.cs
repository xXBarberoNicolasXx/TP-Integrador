using integrador.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Operadores
{
    internal class ListaDeOperadores
    {
        Random randy = new Random();
        public ListaDeOperadores() 
        {
            List<Operador> operadores = new List<Operador>();
            CrearOperadoresRandom(operadores);
            //Ivan Imperiale
            /*List<Operador> operadoresEnBaldio;
            List<Operador> operadoresEnBosque;
            List<Operador> operadoresEnCuartel;
            List<Operador> operadoresEnLago;
            List<Operador> operadoresEnPlanicie;
            List<Operador> operadoresEnReciclaje;
            List<Operador> operadoresEnUrbano;
            List<Operador> operadoresEnVertedero;
            List<Operador> operadoresEnVertederoElectronico;
            //Nicolas Barbero*/ 
            // esto no estaba haciendo nah'
        }
        public void CrearOperadoresRandom (List<Operador> operadores)
        {
            int[] filler = new int[2];
            Bateria bateriaUAV = new Bateria(4000, 4000);
            Bateria bateriaK9 = new Bateria(6500, 6500);
            Bateria bateriaM8 = new Bateria(12250, 12250);
            Movimiento movementUAV = new Movimiento(10, 0, filler);
            Movimiento movementM8 = new Movimiento(2, 0, filler);
            Movimiento movementK9 = new Movimiento(8, 0, filler);

            for (int j = 0; j < randy.Next(20, 50); j++)
            {
                UAV uAV = new(bateriaUAV, "Idle", "OK", 5, 1, movementUAV);
                operadores.Add(uAV);
            }

            for (int j = 0; j < randy.Next(20, 50); j++)
            {
                K9 k9 = new(bateriaK9, "Idle", "OK", 40, 1, movementK9);
                operadores.Add(k9);
            }

            for (int j = 0; j < randy.Next(20, 50); j++)
            {
                M8 m8 = new(bateriaM8, "Idle", "OK", 250, 1, movementM8);
                operadores.Add(m8);
            }
                //Ivan Imperiale
           
        }

       /* public void OperadoresPorUbicacion(List<Operador> operadores, int[] location)
        {
            List<Operador> operadoresEnBaldio = new List<Operador>();
            List<Operador> operadoresEnBosque = new List<Operador>();
            List<Operador> operadoresEnCuartel = new List<Operador>();
            List<Operador> operadoresEnLago = new List<Operador>();
            List<Operador> operadoresEnPlanicie = new List<Operador>();
            List<Operador> operadoresEnReciclaje = new List<Operador>();
            List<Operador> operadoresEnUrbano = new List<Operador>();
            List<Operador> operadoresEnVertedero = new List<Operador>();
            List<Operador> operadoresEnVertederoElectronico = new List<Operador>();

            foreach (Operador operador in operadores)
            {
                if (location[operador.ID] is Baldio)
                {
                    operadoresEnBaldio.Add(operador);
                }
                else if (location[operador.ID] == Bosque)
                {
                    operadoresEnBosque.Add(operador);
                }
                else if (location[operador.ID] == Cuartel)
                {
                    operadoresEnCuartel.Add(operador);
                }
                else if (location[operador.ID] == Lago)
                {
                    operadoresEnLago.Add(operador);
                }
                else if (location[operador.ID] == Planicie)
                {
                    operadoresEnPlanicie.Add(operador);
                }
                else if (location[operador.ID] == Reciclaje)
                {
                    operadoresEnReciclaje.Add(operador);
                }
                else if (location[operador.ID] == Urbano)
                {
                    operadoresEnUrbano.Add(operador);
                }
                else if (location[operador.ID] == Vertedero)
                {
                    operadoresEnVertedero.Add(operador);
                }
                else if (location[operador.ID] == VertederoElectronico)
                {
                    operadoresEnVertederoElectronico.Add(operador);
                }
                //Nicolas Barbero // se inicializan las listas, pero se usa el ID ocmo un INT, habria que googlear o chatgptear como hacer para que tome el ID y lo compare en base a eso
            }
        }*/
    }
}
