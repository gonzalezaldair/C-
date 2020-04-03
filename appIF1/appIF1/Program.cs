using System;

namespace appIF1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma=0, producto=0,resta=0;
            double division=0;
            Console.Write("Ingrese primer valor:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Segundo valor:");
            num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                suma = num1 + num2;
                resta = num1 - num2;
                Console.Write("La suma de los dos valores es:");
                Console.WriteLine(suma);
                Console.Write("El resta de los dos valores es:");
                Console.WriteLine(resta);
            }
            else
            {
                division = num1 / num2;
                producto = num1 * num2;
                Console.Write("La division de los dos valores es:");
                Console.WriteLine(division);
                Console.Write("El producto de los dos valores es:");
                Console.WriteLine(producto);
            }

           
            
        }
    }
}
