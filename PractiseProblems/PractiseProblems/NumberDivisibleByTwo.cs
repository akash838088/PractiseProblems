using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class NumberDivisibleByTwo
    {
        public static void NumberCheck()
        {
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number % 2 == 0)
                Console.WriteLine("Number is Divisible By Two");
            else 
            { 
                Console.WriteLine("Number is not Divisible By Two");
            }
        }
    }
}