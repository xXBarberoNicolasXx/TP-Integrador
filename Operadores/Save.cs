using System;

namespace integrador.Save
{
    /*  internal class ListaGuardado
      {


          string jsonData = JsonConvert.SerializeObject(saveList);
          string filePath = @"Save\save.json";
          File.WriteAllText(filePath, jsonData);

      // aca nose, no le gusto nada al compilador ajja
      }*/
 
    public static string VertederoEfectoTerreno(Operador operador)
    {
        Random random = new Random();
        int probabilidad = random.Next(0, 100);
        int falla;
        if (probabilidad < 5)
        {
            falla = probabilidad;
        }

        switch (falla)
        {
            case 1:
                operador.opState = "MOTOR COMPROMETIDO";
                break;
            case 2:
                operador.opState = "SERVO ATASCADO";
                break;
            case 3:
                operador.opState = "BATERIA PERFORADA";
                break;
            case 4:
                operador.opState = "PUERTO BATERIA DESCONECTADO";
                break;
            case 5:
                operador.opState = "PINTURA RAYADA";
                break;

            default:
                operador.opState = "Ok";
                break;
        }
        protected static int VertederoElectronicoEfectoTerreno(Operador operador)
        {
            Random random = new Random();
            int probabilidad = random.Next(0, 100);
            if (probabilidad < 20)
            {
                operador.opState = "Bateria dañada, su capacidad maxima se reduce en 20%";
            }
        }


        public void ReciclajeEfectoTerreno(Operador operador)
        {
            operador.Battery.RecargaBateria(operador.batteryMax, operador.batteryActual);
        }




    }
