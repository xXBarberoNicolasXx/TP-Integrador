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
            }
        }
    }
}
