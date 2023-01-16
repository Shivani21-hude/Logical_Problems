using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class PrimeNumber
    {
        public static void PrimeNum()
        {
            Console.WriteLine("Enter a number for to find prime numbers");
            int n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers are : ");
            for(int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i +" ");
                }
               
            }  
        }
    }
}
