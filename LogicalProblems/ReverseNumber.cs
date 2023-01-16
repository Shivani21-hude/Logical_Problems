using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class ReverseNumber
    {
        public static void ReverseNum()
        {
            Console.WriteLine("Enter a number to reverse it");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("after reversing :");
            while (n > 0)
            {

                int r = n % 10;
                Console.Write(r);
                n /= 10;
            }
        }
    }
}
