using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class LargestOfTwo
    {
        public static void LargestNumber()
        {
            Console.WriteLine("Enter a First Number");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            if (firstnumber > secondnumber)
            {
                Console.WriteLine("First Number Is Larger", firstnumber);
            }
            else { Console.WriteLine("Second Number Is Larger", secondnumber); }
        }
    }
}