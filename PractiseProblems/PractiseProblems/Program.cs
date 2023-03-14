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
                    "2:Check Odd Numbers In Given Range");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        OddOrEvenNumber.EvenOddNumbers();
                        break;
                    case 2:
                        OddNumbers.ChekingOddNumbers();
                        break;
                    default:
                        Console.WriteLine("Choose a valid Options");
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}