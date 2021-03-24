using System;
using System.Collections.Generic;
using System.Text;

//THIS APLICATION ADDS A RANGE OF NUMBERS DIFINED IN THE METHOD  
namespace Recursion
{
    public class AddRange
    {
        public static void Main1(String[] args)
        {
            int add = 0;
            int range = 0; 
            //CALL THE METHOD ADD1 AND SEND YOU THE RANGE TO BE ADDED
            Console.WriteLine("YOU WANT TO ADD THE NUMBERS FROM 1 TO: ");
            range = Convert.ToInt16(Console.ReadLine());
            add = add1(range);
            Console.WriteLine("THE SUMMARY OF THE RANGE OF NUMBERS FROM 1 TO 5 IS: " + add);
            Console.ReadLine();
        }

        //METHOD FOR CALCULATING THE SUM BY RECUSION
        public static int add1(int range)
        {
            int r = 0;
            //INDUCTIVE CASE
            if (range > 1)
            {
                r = range + add1(range - 1);
            }
            //BASE CASE
            if (range == 1)
                r = 1;

            return r;
        }
    }
}