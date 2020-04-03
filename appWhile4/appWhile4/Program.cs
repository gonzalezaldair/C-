using System;

namespace appWhile4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, x=1,valido=0,novalido=0;
            float num2;
            Console.Write("Ingrese # de perfiles a procesar: ");
            num1 = int.Parse(Console.ReadLine());
            while(x<=num1)
            {
                Console.Write("Ingrese Longitud: ");
                num2 = float.Parse(Console.ReadLine());
                if(num2 >= 1.20 && num2 <= 1.30)
                {
                    valido += 1;
                }
                else
                {
                    novalido += 1;
                }
                x += 1;
            }
            Console.Write("Perfiles Validos: "+ valido);
            Console.Write("\n Perfiles No Validos: " + novalido);

        }
    }
}
