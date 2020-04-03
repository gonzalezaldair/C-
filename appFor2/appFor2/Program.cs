using System;

namespace appFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, suma=0,promedio ;
            
            for(int i=0;i<10;i++)
            {
                Console.Write("Ingrese valor: ");
                num1 = float.Parse(Console.ReadLine());
                suma += num1;
            }
            promedio = suma / 10;

            Console.Write("La suma es: "+ suma);
            Console.Write("el promedio es: "+promedio);
        }
    }
}
