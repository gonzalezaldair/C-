using System;

namespace appCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado,perimetro;
            string linea;
            Console.Write("Ingrese Lado del Cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado * 4;
            Console.Write("El perimetro del cuadrado es: ");
            Console.WriteLine(perimetro);
        }
    }
}
