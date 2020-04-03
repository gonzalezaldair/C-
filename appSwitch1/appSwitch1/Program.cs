using System;

namespace appSwitch1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese valor:");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Write("UNO");
                    break;
                case 2:
                    Console.Write("DOS");
                    break;
                case 3:
                    Console.Write("TRES");
                    break;
                case 4:
                    Console.Write("CUATRO");
                    break;
                case 5:
                    Console.Write("CINCO");
                    break;
                default:
                    Console.Write("VALOR NO VALIDO, SOLO INGRESAR NUMERO");
                    break;
            }
        }
    }
}
