using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class MonthlyPayment
    {
        public static void CalculatePayment()
        {
            double n, r;
            double payment;
            Console.WriteLine("enter year that you would have to make over Y years:");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter principle loan for monthly payment:");
            int P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter interest compounded monthly:");
            int R = Convert.ToInt32(Console.ReadLine());
            n = 12 * Y;
            r = R / (12 * 100);
            payment = (P * R / 1 - (Math.Pow(1 + r, -n)));
            Console.WriteLine("Monthly payment: " + payment);
        }
    }
}
