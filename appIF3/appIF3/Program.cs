using System;

namespace appIF3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Ingrese valor:");
            num1 = int.Parse(Console.ReadLine());

            if(num1 <= 99)
            {
                if(num1 <= 9)
                {
                    Console.Write("El numero es de un digito");
                }
                else
                {
                    Console.Write("El numero es de dos digito");
                }
            }
            else
            {
                Console.Write("el numero debe ser <= 99");
            }
            
        }
    }
}
