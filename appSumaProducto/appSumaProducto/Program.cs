using System;

namespace appSumaProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, producto;
            Console.Write("Ingresar 4 numeros, sumar los dos primeros y multiplicar los dos ultimos");
            Console.Write("\n Ingrese primer valor:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Segundo valor:");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Tercero valor:");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Cuarto valor:");
            num4 = int.Parse(Console.ReadLine());

            suma = num1 + num2;
            producto = num3 * num4;

            Console.Write("La suma de los dos valores es:");
            Console.WriteLine(suma);
            Console.Write("El producto de los dos valores es:");
            Console.WriteLine(producto);

        }
    }
}
