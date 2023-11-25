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
    public abstract class Movimiento
    {
         double CrearVelocidadActual(double speedMax, double speedActual, int Bateria.ReduccionBateria(int batteryMax, int batteryActual))
        {
            double speedActual = speedMax;
            double porcentajeVelocidad;
            porcentajeVelocidad = (reduccionBateria / 10.0) * 5.0;
            speedActual -= (speedActual * porcentajeVelocidad / 100.0);
            return speedActual;
            //Nicolas Barbero
        }
    }
}