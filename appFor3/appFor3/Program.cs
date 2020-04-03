using System;

namespace appFor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota, mayor=0, menor=0;
            
            for(int i=0;i<10;i++)
            {
                Console.Write("Ingrese Nota:");
                nota = int.Parse(Console.ReadLine());
                if(nota >= 7)
                {
                    mayor += 1;
                }
                else
                {
                    menor += 1;
                }
            }
            Console.Write("Notas Mayores o Iguales a : "+mayor);
            Console.Write("\n Notas Menores: " + menor);
        }
    }
}
