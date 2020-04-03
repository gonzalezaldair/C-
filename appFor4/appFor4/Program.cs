using System;

namespace appFor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,valor, mayor=0, menor=0;
            Console.Write("Ingrese valor de n :");
            n = int.Parse(Console.ReadLine());
            for (int f = 1; f <= n; f++)
            {
                Console.Write("Ingrese valor:");
                valor = int.Parse(Console.ReadLine());
                if(valor >= 1000)
                {
                    mayor += 1;
                }
                else
                {
                    menor += 1;
                }
            }

            Console.Write("Mayores a 1000: "+mayor);
            Console.Write("Menores a 1000 :"+menor);

        }
    }
}
