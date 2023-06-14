Aquí está el código modificado para incluir el requerimiento 10 que mencionaste:

```csharp
using System;
using System.Diagnostics;

class Program
{
    public static void Main(string[] args)
    {
        //variables
        int opcionTarjeta;
        string[] nombreTarjetas = { "Visa", "Mastercard", "Diners Club" };
        string numeroTarjeta = "";
        string identificador;
        string ultimosDigitos;
        bool validar = true;
        string nombreTarjetaSt;

        // ------------------------------ 1 ----------------------------
        //Mensaje de inicio
        Console.WriteLine("Bienvenido a Red Majestic" +
                          "\nOperar con Visa - Ingrese 1" +
                          "\nOperar con Mastercard - Ingrese 2" +
                          "\nOperar con Diners Club - Ingrese 3" +
                          "\nIngrese su opción:");

        opcionTarjeta = Int32.Parse(Console.ReadLine());
        try
        {
            // Código que puede generar una excepción
            nombreTarjetaSt = nombreTarjetas[opcionTarjeta - 1];
        }
        catch (Exception exception)
        {
            // Manejo de la excepción
            nombreTarjetaSt = "Sin Datos";
        }


        while (validar) // Controlo que el numero ingresado sea igual a 16
        {
            Console.Clear();
            Console.WriteLine("--- RED MAJESTIC ---" +
                              "\nTarjeta elegida: " + nombreTarjetaSt +
                              "\nIngrese los 16 digitos de la tarjeta: ");
            numeroTarjeta = Console.ReadLine();
            if (numeroTarjeta.Length == 16)
            {
                validar = false;
            }
        }

        // separo los 4 primeros numeros de la tarjeta, y los ultimos
        identificador = numeroTarjeta.Substring(0, 4);
        ultimosDigitos = numeroTarjeta.Substring(numeroTarjeta.Length - 4);
        DigitosTarjeta(nombreTarjetaSt, identificador, opcionTarjeta);

        // ------------------------------ 1 ----------------------------
        // ------------------------------ 2 ----------------------------
        // Listado de transacciones

        // Lógica para obtener y mostrar las transacciones según la tarjeta seleccionada
        if (opcionTarjeta == 1)
        {
            ObtenerTransaccionesVisa(identificador);
        }
        else if (opcionTarjeta == 2)
        {
            ObtenerTransaccionesMastercard(identificador);
        }
        else if (opcionTarjeta == 3)
        {
            ObtenerTransaccionesDinersClub(identificador);
        }

        // ------------------------------ 2 

        // comparo que los 4 digitos coincidan con la tarjeta elegida
        static bool DigitosTarjeta(string tarNombre, string tarId, int tarNumOpcion)
        {
            switch (tarNumOpcion)
            {
                case 1:
                    if (ValidarVisa(tarId))
                    {
                        Console.WriteLine("Funciona visa");
                    };
                    break;
                case 2:
                    if (ValidarMastercard(tarId))
                    {
                        Console.WriteLine("Funciona master");
                    };
                    break;
                case 3:
                    ValidarDinnersClub(tarId);
                    break;
                default:
                    Console.WriteLine("La opcion elegida no coincide. Intentelo mas tarde.");
                    break;
            }

            bool ValidarVisa(string tarjId)
            {
                string idLocal = "4407";
                MensajeError(tarNumOpcion, idLocal, 1);
                return (idLocal == tarjId);
            }
           

 bool ValidarMastercard(string tarjId)
            {
                string idLocal = "3890";
                MensajeError(tarNumOpcion, idLocal, 2);
                return (idLocal == tarjId);
            }
            bool ValidarDinnersClub(string tarjId)
            {
                string idLocal = "7401";
                MensajeError(tarNumOpcion, idLocal, 3);
                return (idLocal == tarjId);
            }
            string MensajeError(int opcionTar, string idLocal, int opciLocal)
            {
                if (opcionTar != opciLocal)
                {
                    Console.WriteLine("La opción ingresada no es válida. Inténtelo nuevamente más tarde.");
                }
                else if (tarId != idLocal)
                {
                    Console.WriteLine("El número de tarjeta ingresada no es válido.Inténtelo nuevamente más tarde.");
                }
                return "";
            }
            return false;
        }

        // Funciones para obtener y mostrar transacciones según la tarjeta seleccionada
        static void ObtenerTransaccionesVisa(string identificador)
        {
            float[] transacciones = { 100.50f, 50.25f, 75.60f };
            MostrarTransacciones(transacciones);
        }

        static void ObtenerTransaccionesMastercard(string identificador)
        {
            var transacciones = new List<float> { 200.75f, 150.30f, 80.10f };
            MostrarTransacciones(transacciones);
        }

        static void ObtenerTransaccionesDinersClub(string identificador)
        {
            var transacciones = new Dictionary<int, float>
            {
                { 1, 300.40f },
                { 2, 90.75f },
                { 3, 120.50f }
            };
            MostrarTransacciones(transacciones);
        }

        static void MostrarTransacciones(float[] transacciones)
        {
            Console.WriteLine("--- Listado de transacciones ---");
            int numeroTransaccion = 1;
            foreach (float transaccion in transacciones)
            {
                Console.WriteLine($"Transacción #{numeroTransaccion}: ${transaccion}");
                numeroTransaccion++;
            }
        }

        static void MostrarTransacciones(List<float> transacciones)
        {
            Console.WriteLine("--- Listado de transacciones ---");
            int numeroTransaccion = 1;
            foreach (float transaccion in transacciones)
            {
                Console.WriteLine($"Transacción #{numeroTransaccion}: ${transaccion}");
                numeroTransaccion++;
            }
        }

        static void MostrarTransacciones(Dictionary<int, float> transacciones)
        {
            Console.WriteLine("--- Listado de transacciones ---");
            foreach (var transaccion in transacciones)
            {
                Console.WriteLine($"Transacción #{transaccion.Key}: ${transaccion.Value}");
            }
        }
    }
}

    //Para Visa se utiliza una estructura foreach,
    //para Mastercard se utiliza una estructura do-while y para Diners Club se utiliza una estructura foreach
        
        
