using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class SwapNumbersProgram
    {
        public static void SwapNumbers()
        {
            Console.WriteLine("Enter First Number To Swap");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number To Swap");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = firstnumber;
            firstnumber = secondnumber;
            secondnumber = temp;
            Console.WriteLine("After Swaping First Number :{0}", firstnumber);
            Console.WriteLine("After Swaping Second Number :{0}", secondnumber);
        }
    }
}