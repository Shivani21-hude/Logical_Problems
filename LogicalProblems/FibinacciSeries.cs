using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class FibinacciSeries
    {
        public static void Fibonacci()
        {
            Console.WriteLine("Enter a number for fibonacci series");
            int n=Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1,c;
            for(int i = 2; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
