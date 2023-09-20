using System;

namespace ExtraE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            while(n >= 0)
            {
                
                Console.WriteLine("Ingresa un número");
                n = int.Parse(Console.ReadLine());
                int cn = 0;
                while(n > 0)
                {
                    cn++;
                    Console.WriteLine("Ingresa otro número");
                    n = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("En esta lista había: " + cn + " números");
            }

            Console.WriteLine("Fin del programa");
        }
    }
}
