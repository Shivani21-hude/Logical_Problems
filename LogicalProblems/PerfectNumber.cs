using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class PerfectNumber
    {
        public static void PerfectNum()
        {
            Console.WriteLine("Enter a number to check as perfet number or not");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            Console.WriteLine("{0} that divisible by :", n);
            for (int i = 1; i < n; i++)
            {

                if (n % i == 0)
                {
                    Console.Write(i + " + ");
                    sum = sum + i;

                }

            }
            Console.WriteLine("\n the sum of divisible numbers : " + sum);
            if (sum == n)
            {

                Console.WriteLine("{0} is a perfect number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a pefect number", n);
            }
        }
    }
}
