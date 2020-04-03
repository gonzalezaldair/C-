using System;

namespace appDoWhile1
{
    class Program
    {
        static void Main(string[] args)
        {


            int valor, dig = 0, num;
            do
            {
                Console.Write("Ingrese valor:");
                valor = Convert.ToInt32(Console.ReadLine());
                if(valor>0 && valor <= 999)
                {
                    do
                    {
                        valor = valor / 10;
                        dig += 1;
                    } while (valor > 0);
                    Console.Write("\n Tiene : " + dig);
                    dig = 0;
                }
            } while (valor != 0);

        }
    }
}
