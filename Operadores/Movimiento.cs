﻿using System;
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
        double CrearVelocidadActual(double speedMax, double speedActual, int batteryMax, int batteryActual)
        {
            double porcentajeVelocidad = (Bateria.ReduccionBateria(batteryMax, batteryActual) / 10.0) * 5.0;
            speedActual -= (speedActual * porcentajeVelocidad / 100.0);
            return speedActual;
            //Nicolas Barbero
        }
    }
}