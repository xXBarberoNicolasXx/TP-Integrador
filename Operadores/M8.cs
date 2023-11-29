using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador.Operadores
{
   /* internal class M8 : Operador
    {
        public M8(Bateria battery, string generalState, string operatorState, Carga carga, Movimiento movement)
        {
            this.ID = CreateId(ID);
            this.Battery = battery;
            this.GeneralState = generalState;
            this.OperatorState = operatorState;
            this.Carga = carga;
            this.Movement = movement;
            //Ivan Imperiale
            movement.speedActual = CrearVelocidadActual(movement.speedActual, battery.BatteryMax, battery.BatteryActual);
        }
        public override string CreateID(string id)
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
    }*/
}
