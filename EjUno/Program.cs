using System;

namespace ExtraTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, conp = 0;

            for(int x = 0; x < 10; x++)
            {
                int con = 0;
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());

                for(int y = 1; y <= n; y++)
                {
                    if((n % y) == 0)
                        con++;
                }

                if(con == 2)
                    conp++;
            }
            Console.WriteLine("La cantidad de números primos es de: " + conp);
        }
    }
}
