using System;

namespace appIF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nota: Verificar la configuracion regional, en algunos funcona coma y en otros punto \n ");
            float num1, num2, num3, suma;
            float promedio;
            Console.Write("Ingrese primer Nota:");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese Segunda Nota:");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese Tercera Nota :");
            num3 = float.Parse(Console.ReadLine());
            suma = num1 + num2 + num3;
            promedio = suma / 3;
            if (promedio >= 7)
            {
                Console.Write("Promocionado :)");
            }
            else
            {
                Console.Write("No Promocionado  :'(");
            }
        }
    }
}
