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

        //Mensaje de inicio
        Console.WriteLine("Bienvenido a Red Majestic" +
                          "\nOperar con Visa - Ingrese 1" +
                          "\nOperar con Mastercard - Ingrese 2" +
                          "\nOperar con Diners Club -Ingrese 3" +
                          "\nIngrese su opción:");

        opcionTarjeta = Int32.Parse(Console.ReadLine());


        while (validar) // Controlo que el numero ingresado sea igual a 16
        {
            Console.Clear();
            Console.WriteLine("RED MAJESTIC" +
                              "\nTarjeta elegida: " + nombreTarjetas[opcionTarjeta - 1] +
                              "\nIngrese los 16 digitos de la tarjeta: ");
            digitosTarjeta = Console.ReadLine();
            if (digitosTarjeta.Length == 16)
            {
               validar = false;
            }
        }
        Console.WriteLine(digitosTarjeta);

        // separo los 4 primeros numeros de la tarjeta
        identificador = digitosTarjeta.Substring(0, 4);
        

        // siguiente: 



        //funcion para validar la tarjeta
        static string ValidarTarjeta(int tarjeta, int id)
        {




            return "as";
        }
    }
}
