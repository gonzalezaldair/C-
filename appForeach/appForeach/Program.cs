using System;

namespace appForeach
{
    class Program
    {
        private int[] sueldos;

        public void Cargar()
        {
            Console.Write("Ingrese Tamaño del vector: ");
            int tam= int.Parse(Console.ReadLine());
            sueldos = new int[tam];
            for (int f = 0; f < tam; f++)
            {
                Console.Write("Ingrese valor de la componente:");
                String linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            int mayor = 0, menor = 0;
            for (int f = 0; f < 5; f++)
            {
                if(sueldos[f] > 100)
                {
                    mayor += 1;
                }
                else
                {
                    menor += 1;
                }
                //Console.WriteLine(sueldos[f]);
            }
            Console.WriteLine("Mayores a 100: "+ mayor);
            Console.WriteLine("Menores a 100: " + menor);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}
