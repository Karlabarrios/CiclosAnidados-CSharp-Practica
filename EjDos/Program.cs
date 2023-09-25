using System;

namespace ExtraCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, gmp = 0, pm = 0;
            int tn, ni, p = 0;
            int gord = 0, m;
            bool bOrd;

            for( int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingresa un número, lindi");
                n = int.Parse(Console.ReadLine());
                tn = 0;
                ni = 0;
                // Ejercicio pt b
                m = n;
                bOrd = true;

                while(n != 0)
                {
                    tn++;
                    if((n % 2) != 0)
                        ni++;
                    
                    //EJERCICIO SIDE B
                    if(n <= m)
                        m = n;
                    else
                        bOrd = false;

                    Console.WriteLine("Ingresa un número d nuevo");
                    n = int.Parse(Console.ReadLine());
                }
                p = (ni * 100) / tn;

                if(x == 0)
                {
                    pm = p;
                    gmp = 1;
                }
                else if(p >= pm)
                {
                    pm = p;
                    gmp = x + 1;
                }

                //EJERCICIO SIDE B
                if(bOrd)
                    gord++;
            }

            Console.WriteLine("El grupo con mayor porcentaje de números impares es: " + gmp + " con " + pm +"%");
            Console.WriteLine("La cantidad de grupos con números ordenados de mayor a menor son: " + gord);
        }
    }
}
