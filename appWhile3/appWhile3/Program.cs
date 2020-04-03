using System;

namespace appWhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,suma=0,x=0;
            while(x<10)
            {

                Console.Write("Ingrese valor:");
                num = int.Parse(Console.ReadLine());
                suma += num;
                x += 1;
            }

            Console.Write("la suma es: "+ suma);
        }
    }
}
