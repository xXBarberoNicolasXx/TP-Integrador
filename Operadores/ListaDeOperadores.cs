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
            List<Operador> operadoresEnBaldio = new List<Operador>();
            List<Operador> operadoresEnBosque = new List<Operador>();
            List<Operador> operadoresEnCuartel = new List<Operador>();
            List<Operador> operadoresEnLago = new List<Operador>();
            List<Operador> operadoresEnPlanicie = new List<Operador>();
            List<Operador> operadoresEnReciclaje = new List<Operador>();
            List<Operador> operadoresEnUrbano = new List<Operador>();
            List<Operador> operadoresEnVertedero = new List<Operador>();
            List<Operador> operadoresEnVertederoElectronico = new List<Operador>();
            //Nicolas Barbero*/ 
            // esto no estaba haciendo nah'
        }

        public void CrearOperadoresRandom(List<Operador> operadores)
        {
            int[] location = Operador.CrearLocacionDeOperador();
            Bateria bateriaUAV = new (4000, 4000);
            Bateria bateriaK9 = new (6500, 6500);
            Bateria bateriaM8 = new (12250, 12250);
            Carga cargaM8 = new (250, 1);
            Carga cargaK9 = new (40, 1);
            Carga cargaUAV = new (5, 1);
            Movimiento movementUAV = new (10, location);
            Movimiento movementM8 = new (2, location);
            Movimiento movementK9 = new (8, location);
            for (int j = 0; j < randy.Next(20, 50); j++)
            {
                Operador uAV = new(bateriaUAV, "Idle", "OK", cargaUAV, movementUAV);
                operadores.Add(uAV);
            }

            for (int j = 0; j < randy.Next(20, 50); j++)
            {
                Operador k9 = new (bateriaK9, "Idle", "OK", cargaK9, movementK9);
                operadores.Add(k9);
            }

            for (int j = 0; j < randy.Next(20, 50); j++)
            {
                Operador m8 = new (bateriaM8, "Idle", "OK", cargaM8, movementM8);
                operadores.Add(m8);
            }
            //Ivan Imperiale
        }

    

        /*public void CrearOperadoresRandom (List<Operador> operadores)
        {
            int[] filler = new int[2];
            Bateria bateriaUAV = new Bateria(4000, 4000);
            Bateria bateriaK9 = new Bateria(6500, 6500);
            Bateria bateriaM8 = new Bateria(12250, 12250);
            Carga cargaM8 = new Carga(250, 1);
            Carga cargaK9 = new Carga(40, 1);
            Carga cargaUAV = new Carga(5, 1);
            Movimiento movementUAV = new Movimiento(10,  filler);
            Movimiento movementM8 = new Movimiento(2,  filler);
            Movimiento movementK9 = new Movimiento(8,  filler);

            for (int j = 0; j < randy.Next(20, 50); j++)
            {
                UAV uAV = new(bateriaUAV, "Idle", "OK", cargaUAV, movementUAV);
                operadores.Add(uAV);
            }

            for (int j = 0; j < randy.Next(20, 50); j++)
            {
                K9 k9 = new(bateriaK9, "Idle", "OK", cargaK9, movementK9);
                operadores.Add(k9);
            }

            for (int j = 0; j < randy.Next(20, 50); j++)
            {
                M8 m8 = new(bateriaM8, "Idle", "OK", cargaM8, movementM8);
                operadores.Add(m8);
            }
                //Ivan Imperiale
           
        }*/

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
