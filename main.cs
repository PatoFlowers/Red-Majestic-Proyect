using System;
class Program
{
    public static void Main(string[] args)
    {
        //variables
        int opcionTarjeta;
        string[] nombreTarjetas = { "Visa", "Mastercard", "Diners Club" };
        string identificador;
        string digitosTarjeta = "";
        bool validar = true;
        string nombreTarjetaSt;

        //Mensaje de inicio
        Console.WriteLine("Bienvenido a Red Majestic" +
                          "\nOperar con Visa - Ingrese 1" +
                          "\nOperar con Mastercard - Ingrese 2" +
                          "\nOperar con Diners Club -Ingrese 3" +
                          "\nIngrese su opción:");

        opcionTarjeta = Int32.Parse(Console.ReadLine());
        nombreTarjetaSt = nombreTarjetas[opcionTarjeta];

        while (validar) // Controlo que el numero ingresado sea igual a 16
        {
            Console.Clear();
            Console.WriteLine("--- RED MAJESTIC ---" +
                              "\nTarjeta elegida: " + nombreTarjetas[opcionTarjeta - 1] +
                              "\nIngrese los 16 digitos de la tarjeta: ");
            digitosTarjeta = Console.ReadLine();
            if (digitosTarjeta.Length == 16)
            {
                validar = false;
            }
        }

        // separo los 4 primeros numeros de la tarjeta
        identificador = digitosTarjeta.Substring(0, 4);
        DigitosTarjeta(nombreTarjetaSt,identificador);


        //funcion para validar la tarjeta
        static string ValidarTarjeta(int tarjeta, int id)
        {

            return "as";
        }
        // Muestro la tarjeta segun el codigo de 4 digitos -- Filtrar por la opcion de la tarjeta elegida
        static string DigitosTarjeta(string tarjeta, string digitos)
        {
            switch (digitos)
            {
                case "4407":
                    Console.WriteLine($"--- {tarjeta} ---");
                    CuatroDigitos();
                    break;
                case "3890":
                    Console.WriteLine($"--- {tarjeta} ---");
                    CuatroDigitos();
                    break;
                case "7401":
                    Console.WriteLine($"--- {tarjeta} ---");
                    CuatroDigitos();
                    break;
                default:
                    Console.WriteLine("Los 4 primeros digitos de la tarjeta no coinciden");
                    break;
            }

            string CuatroDigitos()
            {
                Console.WriteLine("Presione Enter para volver al menú principal");
                Console.ReadLine();
                Console.Clear(); // Limpiar la pantalla
                return "";

                // siguiente: Mostrar transacciones de la tarjeta
            }
            return"";
        }
    }
    
}
