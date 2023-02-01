using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class DecimalToBinary
    {
        public static void DecimalConversion()
        {
            Console.WriteLine("Conversion of decimal to binary number \n ");
            Console.Write("Enter the Decimal Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }
            Console.ReadKey();
        }
    }
}
