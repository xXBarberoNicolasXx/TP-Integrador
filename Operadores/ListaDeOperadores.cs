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
            List<Operador> operadoresEnBaldio;
            List<Operador> operadoresEnBosque;
            List<Operador> operadoresEnCuartel;
            List<Operador> operadoresEnLago;
            List<Operador> operadoresEnPlanicie;
            List<Operador> operadoresEnReciclaje;
            List<Operador> operadoresEnUrbano;
            List<Operador> operadoresEnVertedero;
            List<Operador> operadoresEnVertederoElectronico;
            //Nicolas Barbero
        }
        public void CrearOperadoresRandom (List<Operador> operadores)
        {
            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < randy.Next(0, 10); j++);
                UAV uAV = new UAV();
                operadores.Add(uAV);
                for (int j = 0; j < randy.Next(0, 10); j++) ;
                K9 k9 = new K9();
                operadores.Add(k9);
                for (int j = 0; j < randy.Next(0, 10); j++) ;
                M8 m8 = new M8();
                operadores.Add(m8);
                //Ivan Imperiale
            }
        }

        public void OperadoresPorUbicacion(List<Operador> operadores, int[] location)
        {
            List<Operador> operadoresEnBaldio = new List<Operador>();
            List<Operador> operadoresEnBosque = new List<Operador>();
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
                if (location[operador.ID] == Baldio)
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
                //Nicolas Barbero
            }
        }
    }
}
