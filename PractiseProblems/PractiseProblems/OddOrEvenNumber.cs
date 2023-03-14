using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    public class OddOrEvenNumber
    {
        public static void EvenOddNumbers()
        {
            Console.WriteLine("Enter a Number To check Odd or Even");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Given Number is Even Number");
            }
            else
            {
                Console.WriteLine("Given Number is Odd Number");
            }
        }
    }
}
