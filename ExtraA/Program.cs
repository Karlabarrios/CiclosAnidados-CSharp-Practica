using System;

namespace ExtraUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, MaxP = 0, Porc, Gmx = 0;

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                N = int.Parse(Console.ReadLine());
                int Ct = 0, Cip = 0;

                while(N != 0)
                {
                    Ct++;
                    if((N % 2 != 0) && N > 0)
                        Cip++;
                    
                    Console.WriteLine("Ingrese otro número:");
                    N = int.Parse(Console.ReadLine());
                }

                Porc = (Cip * 100)/Ct;

                if(Porc > MaxP)
                {
                    MaxP = Porc;
                    Gmx = x + 1;
                }
            }

            Console.WriteLine("El grupo con mayor porcentaje de números impares es: " + Gmx);

        }
    }
}
