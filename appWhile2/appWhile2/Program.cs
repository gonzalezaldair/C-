using System;

namespace appWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,x=1;
            Console.Write("Ingrese valor:");
            num = int.Parse(Console.ReadLine());
            if(num> 0)
            {
                while(x<=num)
                {
                    Console.Write(x);
                    Console.Write("-");
                    x += 1;
                }
            }
            else
            {
                Console.Write("El valor debe ser positivo");
            }
        }
    }
}
