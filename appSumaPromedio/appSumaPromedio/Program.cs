using System;

namespace appSumaPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma;
            Console.Write("Ingresar 4 numeros, sumarlos y hallar su promedio");
            Console.Write("\n Ingrese primer valor:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Segundo valor:");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Tercero valor:");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Cuarto valor:");
            num4 = int.Parse(Console.ReadLine());

            suma = num1 + num2 + num3 + num4;
            double promedio = suma / 4;

            Console.Write("La suma de los dos valores es:");
            Console.WriteLine(suma);
            Console.Write("El promedio de los dos valores es:");
            Console.WriteLine(promedio);
        }
    }
}
