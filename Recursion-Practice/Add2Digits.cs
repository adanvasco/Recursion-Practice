using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_Practice
{
    //THIS APPLICATION ADDS THE DIGITS OF A NUMBER ENTERED BY CONSOLE
    public class Add2Digits
    {        
        public static void Main2(String[] args)
        {            
            int digits = 0;
            int result = 0;
            Console.WriteLine("ENTER THE NUMBER, TO WHICH YOUR DIGITS WILL BE ADDED: ");
            //A VALUE IS CAPTURED FROM THE CONSOLE
            digits = Convert.ToInt32(Console.ReadLine());
            
            //CALL TO THE METHOD
            result = Add(digits);
            Console.WriteLine("THE SUMMARY OF ITS DIGITS IS: " + result);
            Console.ReadLine();
        }

        //METHOD THAT CALCULATES THE SUM
        public static int Add(int digits)
        {
            int add = 0;
            //BASE CASE
            if (digits == 0)
                return add;

            //INDUCTIVE CASE
            add = ((digits % 10) + Add(digits / 10));            
            return add;            
        }
    }
}
