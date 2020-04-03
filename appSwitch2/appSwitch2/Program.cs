using System;

namespace appSwitch2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            Console.Write("Ingrese valor:");
            cadena = Console.ReadLine();
            cadena = cadena.ToUpper();
            switch (cadena)
            {
                case "UNO":
                    Console.Write("1");
                    break;
                case "DOS":
                    Console.Write("2");
                    break;
                case "TRES":
                    Console.Write("3");
                    break;
                case "CUATRO":
                    Console.Write("4");
                    break;
                case "CINCO":
                    Console.Write("5");
                    break;
                default:
                    Console.Write("INGRESAR NUMERO EN CASTELLANO");
                    break;
            }
        }
    }
}
