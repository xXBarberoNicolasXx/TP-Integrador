using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Operadores
{
    internal class K9 : Operador
    {
        public K9( Bateria battery, string generalState, string operatorState, int cargaMax, int cargaActual, Movimiento movement)
        {
            this.ID = CreateId(ID);
            this.Battery = battery;
            this.GeneralState = generalState;
            this.OperatorState = operatorState;
            this.CargaMax = cargaMax;
            this.CargaActual = CrearCargaActual();
            this.Movement = movement;
            //Ivan Imperiale
        }
        public override string CreateId(string id)
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
    }
}
