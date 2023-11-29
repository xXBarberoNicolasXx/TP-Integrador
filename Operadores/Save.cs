using integrador.Operadores;
using System;

namespace integrador.Save
{
    public class ListaGuardado
    {


        /* string jsonData = JsonConvert.SerializeObject(saveList);
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


                switch (falla)
                {
                    case 1:
                        operador.OperatorState = "MOTOR COMPROMETIDO";
                        return operador.OperatorState;
                        
                    case 2:
                        operador.OperatorState = "SERVO ATASCADO";
                        return operador.OperatorState;
                    case 3:
                        operador.OperatorState = "BATERIA PERFORADA";
                        return operador.OperatorState;
                    case 4:
                        operador.OperatorState = "PUERTO BATERIA DESCONECTADO";
                        return operador.OperatorState;
                    case 5:
                        operador.OperatorState = "PINTURA RAYADA";
                        return operador.OperatorState;

                    default:
                        operador.OperatorState = "Ok";
                        return operador.OperatorState;
                }

            }
            return operador.OperatorState;








        }
    }
}
