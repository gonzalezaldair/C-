using System;

namespace appDoWhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,suma=0;
            do
            {
                Console.WriteLine("Ingrese valor:");
                num = int.Parse(Console.ReadLine());
                if(num != 9999)
                {
                    suma += num;
                }
            } while (num != 9999);
            Console.WriteLine("La suma es: "+ suma);
            if (suma < 0)
            {
                Console.WriteLine("Menor a Cero");
            }
            else if(suma == 0)
            {
                Console.WriteLine("Igual a 0");
            }
            else if(suma > 0)
            {
                Console.WriteLine("Mayor a Cero");
            }
        }
    }
}
