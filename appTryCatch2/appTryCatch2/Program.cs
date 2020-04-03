using System;

namespace appTryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               for(int i=1;i <= 50;i++)
                {
                    Console.WriteLine("Tabla del : " + i);
                    for(int j=1;j<=10;j++)
                    {
                        Console.WriteLine("{0} * {1} = {2}",i,j,i * j);
                        Console.WriteLine(" - ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
