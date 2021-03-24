using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_Practice
{
    class Spiderman
    {
        static void Main(string[] args)
        {
            int res = 0;
            int skip = 0;

            Console.WriteLine("ENTER THE NUMBER OF BUILDINGS TO SKIP:");
            skip = int.Parse(Console.ReadLine());
            res = Mover(skip);
            Console.WriteLine("USTED PUEDE REALIZAR LOS SIGUIENTES MOVIMIENTOS: " + res);
            //res = Mover(n, aux);
            Console.ReadLine();
        }

        public static int Mover(int skip)
        {
            int count = 0;
            int count1 = 0;
            int count3 = 0;
            int aux1 = 0;
            int aux2 = 0;

            if (skip == 1)
                return 0;                
            else
            {
                count = aux1 + 1 + Mover(skip - 1);        
                count1 = aux2 + Mover(skip - 1);
                count3 = count + count1;
            }

            return count3;
           
        }
    }
}
