using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class SwapNibblesofBinary
    {
        public static void SwappingOfNibbles()
        {
            Console.WriteLine("Swapping of Binary number into ")
            Console.Write("Enter the Decimal Number : ");
            int i = Convert.ToInt32(Console.ReadLine());

            i = (((i & 0x0F) << 4) | ((i & 0xF0) >> 4));

            Console.Write("Swpping of two nibbles:" + i);
        }
    }
}
