using System;

namespace appTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 10;
                int I = i / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
