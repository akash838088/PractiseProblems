using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programing");
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("1:Check Odd Even Number Program\n" +
                    "2:Check Odd Numbers in Given Range\n" +
                    "3:Check Given Number is positive Or Not\n" +
                    "4:Check Largest Among Two Numbers\n" +
                    "5:Check Swap Numbers ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        OddOrEvenNumber.EvenOddNumbers();
                        break;
                    case 2:
                        OddNumbers.ChekingOddNumbers();
                        break;
                    case 3:
                        PositiveNumbers.PositiveOrNot();
                        break;
                    case 4:
                        LargestOfTwo.LargestNumber();
                        break;
                    case 5:
                        SwapNumbersProgram.SwapNumbers();
                        break;
                    case 6:
                        flag = true;
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}
