using System;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine ("Bienvenido a Red Majestic");
    Console.WriteLine ("Operar con Visa - Ingrese 1");
    Console.WriteLine ("Operar con Mastercard - Ingrese 2");
    Console.WriteLine ("Operar con Diners Club - Ingrese 3");
    Console.WriteLine ("Ingrese su opción:");

    string opcion = Console.ReadLine(); //Leer la opción indicada por el usuario
    int identificador = "";
    string empresa = "";

      if (opcion == "1")
            {
                Console.Clear(); // Limpiar la pantalla como pide la consigna

                Console.WriteLine("--- Visa ---");
                Console.Write("Ingrese los 16 dígitos de su tarjeta de crédito sin espacios: ");
                int numeroTarjeta = Console.ReadLine();

                int identificador = numeroTarjeta.Substring(0, 4); // Para obtener los primeros 4 dígitos de la cadena numeroTarjeta

                if (identificador == "4407")
                {
                    Console.WriteLine("Tarjeta Visa seleccionada");
                    // Realizar la validación de la tarjeta y obtener el listado de transacciones de Visa
                }
                else
                {
                    Console.WriteLine("Número de tarjeta inválido");
                }

                Console.WriteLine("Presione Enter para volver al menú principal");
                Console.ReadLine();
                Console.Clear(); // Limpiar la pantalla
            }
            else if (opcion == "2")
            {
                Console.Clear(); // Limpiar la pantalla

                Console.WriteLine("--- Mastercard ---");
                Console.Write("Ingrese los 16 dígitos de su tarjeta de crédito sin los espacios: ");
                int numeroTarjeta = Console.ReadLine();

                int identificador = numeroTarjeta.Substring(0, 4);

                if (identificador == "3890")
                {
                    Console.WriteLine("Tarjeta Mastercard seleccionada");
                    // Realizar la validación de la tarjeta 
                }
                else
                {
                    Console.WriteLine("Número de tarjeta inválido, intente nuevamente");
                }

            }
  }
}




