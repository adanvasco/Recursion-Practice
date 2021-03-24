using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_Practice
{
    class NumberPrime
    {
        static void Main3(string[] args)
        {
            int numbEval = 0;
            Console.WriteLine("ENTER THE NUMBER TO BE EVALUATED:");
            numbEval = int.Parse(Console.ReadLine());
            // I CALL THE RECURSIVE METHOD
            if (isPrime (numbEval, 2))
                Console.WriteLine("THE NUMBER IS PRIME");
            else
                Console.WriteLine("THE NUMBER IS NOT PRIME");

            Console.ReadKey(); 
        }
        //METHOD TO CALCULATE THE PRIME NUMBER
        static bool isPrime(int numbEval, int count)
        {
            //INDUCTIVE CASE
            if (numbEval % count == 0 && numbEval != 2)
                return false;
            //BASE CASE 
            else if (count > numbEval / 2)
                return true;
            else
                //RECURSIVE CALL
                return isPrime(numbEval, count + 1);
        }

    }
}
