﻿using integrador;
using System;

namespace integrador
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool exit = false;
            string empresa = "Robótica Sky.Net";
            Console.WriteLine("Bienvenidos al sistema de gestion de operadores de " + empresa);

            // Llamando a la función CrearOperador para crear un nuevo operador
            // Crear una instancia de la clase base Operador
            Operador operadorBase = new Operador(); // Esto crea una instancia de la clase base Operador
            // Crear una lista de operadores, específicamente de tipo UAV, K9 o M8
            List<Operador> operadores = new List<Operador>();
            // Agregar operadorBase a la lista (si operadorBase es de un tipo derivado)
            operadores.Add(operadorBase);
            int contadorOperadores = operadores.Count;

            List<Operador> operadoresUAV = new List<Operador>();
            List<Operador> operadoresK9 = new List<Operador>();
            List<Operador> operadoresM8 = new List<Operador>();

            for (int i = 0; i < (operadores.Count - 1); i++)
            {
                if (operadorBase.operadorName == "UAV")
                {
                    operadoresUAV.Add(operadorBase);
                }
                else if (operadorBase.operadorName == "K9")
                {
                    operadoresK9.Add(operadorBase);
                }
                else
                {
                    operadoresM8.Add(operadorBase);
                }
            }
            List<string> ubicaciones = new List<string> { "Cuartel", "Zona de recarga", "Deposito", "Zona de trabajo", "Zona de reserva" };
            Dictionary<string, int> Localizaciones = new Dictionary<string, int>();
            Localizaciones["Cuartel"] = 0234234;
            Localizaciones["Zona de recarga"] = 1453346345;
            Localizaciones["Deposito"] = 223423425;
            Localizaciones["Zona de trabajo"] = 024567567;
            Localizaciones["Zona de reserva"] = 98765168;

            List<Operador> operadoresCuartel = new List<Operador>();
            List<Operador> operadoresZonaRecarga = new List<Operador>();
            List<Operador> operadoresDeposito = new List<Operador>();
            List<Operador> operadoresZonaTrabajo = new List<Operador>();
            List<Operador> operadoresZonaReserva = new List<Operador>();

            for (int i = 0; i < (operadores.Count - 1); i++)
            {
                if (operadorBase.location == 0234234)
                {
                    operadoresCuartel.Add(operadorBase);
                }
                else if (operadorBase.location == 1453346345)
                {
                    operadoresZonaRecarga.Add(operadorBase);
                }
                else if (operadorBase.location == 223423425)
                {
                    operadoresDeposito.Add(operadorBase);
                }
                else if (operadorBase.location == 024567567)
                {
                    operadoresZonaTrabajo.Add(operadorBase);
                }
                else
                {
                    operadoresZonaReserva.Add(operadorBase);
                }
            }



            while (exit == false)
            {
                Menu();

                void Menu()
                {
                    while (!exit)
                    {
                        // Mostrar opciones de operación y manejar la entrada del usuario
                        Console.WriteLine("Opciones de operadores:");
                        Console.WriteLine("1. Mover operador");
                        Console.WriteLine("2. Transferir batería");
                        Console.WriteLine("3. Transferir carga física");
                        Console.WriteLine("4. Volver al cuartel y transferir carga");
                        Console.WriteLine("5. Volver al cuartel y cargar batería");
                        Console.WriteLine("6. Salir");
                        Console.Write("Selecciona una opción: ");

                        string opcion = Console.ReadLine();

                        switch (opcion)
                        {
                            case "1":
                                // Implementar la lógica para mover el operador
                                break;
                            case "2":
                                Console.WriteLine("A cual operador desea cargar la bateria:");
                                Operador operadorRecibeBateria = new Operador (Console.ReadLine()) ;
                                Console.WriteLine("A cual operador desea donar su bateria: ");
                                Operador operadorDonaBateria = new Operador(Console.ReadLine());
                                TranspasoBateriaTransferirBateria(operadorRecibeBateria, operadorDonaBateria); ;
                                break;
                            case "3":
                                Console.WriteLine("A cual operador desea transpasar la carga: ");
                                Operador operadorRecibeCarga = new Operador(Console.ReadLine());
                                Console.WriteLine("A cual operador desea dar la carga: ");
                                Operador operadorDonaCarga = new Operador(Console.ReadLine());
                                TranspasoCarga(operadorRecibeBateria, operadorDonaBateria);
                                break;
                            case "4":
                                // Implementar la lógica para volver al cuartel y transferir carga
                                break;
                            case "5":
                                // Implementar la lógica para volver al cuartel y cargar batería
                                break;
                            case "6":
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Opción no válida.");
                                break;
                        }
                    }
                }
            }
            while (exit == false)
                    {
                Menu();
                    void Menu()
                    {
                        while (!exit)
                        {
                            // Mostrar opciones que es posible asumir del cuartel y manejar la entrada del usuario
                            Console.WriteLine("Opciones de cuartel:");
                            Console.WriteLine("1. Ver listado total de los operadores");
                            Console.WriteLine("2. Listar el estado de todos los operadores por localización");
                            Console.WriteLine("3. recall total ");
                            Console.WriteLine("4. Seleccionar un operador en específico ");
                            Console.WriteLine("5. Agregar o remover operadores de la reserva");
                            Console.WriteLine("6. Salir");
                            Console.Write("Selecciona una opción: ");

                            string opcion = Console.ReadLine();

                            switch (opcion)
                            {
                                case "1":
                                    Console.WriteLine(operadores);
                                    break;
                                case "2":
                                    // Implementar la lógica para transferir batería
                                    break;
                                case "3":
                                    // Implementar la lógica para transferir carga física
                                    break;
                                case "4":
                                    while (exit == false)
                                    {
                                        Menu();
                                        void Menu()
                                        {
                                            while (!exit)
                                            {
                                                // Mostrar opciones que es posible asumir del cuartel y manejar la entrada del usuario
                                                Console.WriteLine("Opciones de cuartel:");
                                                Console.WriteLine("1. cambiar ubicacion");
                                                Console.WriteLine("2. volver al cuartel");
                                                Console.WriteLine("3. modo STANDBY");
                                                Console.Write("Selecciona una opción: ");

                                                string opcion = Console.ReadLine();


                                                switch (opcion)
                                                {
                                                    case "1":
                                                        while (exit == false)
                                    {
                                        Menu();
                                        void Menu()
                                        {
                                            while (!exit)
                                            {
                                                // Mostrar opciones que es posible asumir del cuartel y manejar la entrada del usuario
                                                Console.WriteLine("Opciones de cuartel:");
                                                Console.WriteLine("1. cambiar ubicacion");
                                                Console.WriteLine("2. volver al cuartel");
                                                Console.WriteLine("3. modo STANDBY");
                                                Console.Write("Selecciona una opción: ");

                                                string opcion = Console.ReadLine();


                                                switch (opcion)
                                                {
                                                    case "1":
                                                        Console.WriteLine(operadores);
                                                        break;
                                                    case "2":
                                                                            while (exit == false)
                                                                            {
                                                                                Menu();
                                                                                void Menu()
                                                                                {
                                                                                    while (!exit)
                                                                                    {
                                                                                        // Mostrar opciones que es posible asumir del cuartel y manejar la entrada del usuario
                                                                                        Console.WriteLine("¿Que ubicacion desea revisar?:");
                                                                                        Console.WriteLine("1. Cuartel");
                                                                                        Console.WriteLine("2. Zona de recarga");
                                                                                        Console.WriteLine("3. Deposito");
                                                                                        Console.WriteLine("4. Zona de trabajo");
                                                                                        Console.WriteLine("5. Zona de reserva");
                                                                                        Console.Write("Selecciona una opción: ");

                                                                                        string opcion = Console.ReadLine();


                                                                                        switch (opcion)
                                                                                        {
                                                                                            case "1":
                                                                                                Console.WriteLine(operadoresCuartel);
                                                                                                break;
                                                                                            case "2":
                                                                                                Console.WriteLine(operadoresZonaRecarga);
                                                                                                break;
                                                                                            case "3":
                                                                                                Console.WriteLine(operadoresDeposito);
                                                                                                break;
                                                                                            case "4":
                                                                                                Console.WriteLine(operadoresZonaTrabajo);
                                                                                                break;
                                                                                            case "5":
                                                                                                Console.WriteLine(operadoresZonaReserva);
                                                                                                break;
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                            break;

                                                                        case "3":
                                                        Console.WriteLine(operadores);
                                                        break;
                                                }
                                            }
                                        }
                                    }
                                                        break;
                                                    case "2":
                                                        Console.WriteLine(operadores);
                                                        break;
                                                    case "3":
                                                        Console.WriteLine(operadores);
                                                        break;
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case "5":
                                    // Implementar la lógica para volver al cuartel y cargar batería
                                    break;
                                case "6":
                                    exit = true;
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida.");
                                    break;
                            }
                        }

                    }
            }
        }
    }


    static void TransferirBateria(Operador operadorRecibeBateria, Operador operadorDonaBateria)
{
    while (operadorRecibeBateria.OperadorBatery < 100 && operadorDonaBateria.OperadorBatery > 0)
    {
        operadorRecibeBateria.OperadorBatery++;
        operadorDonaBateria.OperadorBatery--;
    }
}

static void TranspasoCarga(Operador operadorRecibeCarga, Operador operadorDonaCarga)
{
    if (operadorRecibeCarga.cargaActual + operadorDonaCarga.cargaActual <= operadorRecibeCarga.cargaMax)
    {
        operadorRecibeCarga.cargaActual = operadorRecibeCarga.cargaActual + operadorDonaCarga.cargaActual;
    }
    else { Console.WriteLine("el peso supera la capacidad de carga del operador seleccionado"); }
}
}
/* static void AgregarNuevaUbicacion(List<string> ubicaciones, Dictionary<string, int> Localizaciones) 
{
    Console.WriteLine("Ingrese el nombre de la nueva ubicacion");
    string nombreNuevaUbicacion = Console.ReadLine();
    Console.WriteLine("Ingrese el codigo de la nueva ubicacion");
    int codigoNuevaUbicacion = int.Parse(Console.ReadLine());
    ubicaciones.Add(nombreNuevaUbicacion);
    Localizaciones["nombreNuevaUbicacion"] = codigoNuevaUbicacion;

} */





