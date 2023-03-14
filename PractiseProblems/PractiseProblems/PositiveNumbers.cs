using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    public class PositiveNumbers
        {
            public static void PositiveOrNot()
            {
                Console.WriteLine("Enter A Number To Check Positive Or Not");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0)
                    Console.WriteLine("Given Number Is Positive ", number);
                else
                    Console.WriteLine("Given Number IS Negative ");
            }
        }
    }
