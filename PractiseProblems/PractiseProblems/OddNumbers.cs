using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    public class OddNumbers
    {
        public static void ChekingOddNumbers()
        {
            Console.WriteLine("Enter Lower Range To Check Odd Numbers");
            int startnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Upper Range To Check Odd Numbers");
            int endingnumber = Convert.ToInt32(Console.ReadLine());
            for (int i = startnumber; i <= endingnumber; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(" {0} ", i);

                }
            }

        }
    }
}