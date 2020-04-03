using System;

namespace appWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            while(x <= 100)
            {
                Console.Write(x);
                Console.Write(" - ");
                x = x + 1;
            }
        }
    }
}
