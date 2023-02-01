using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class VendingMachine
    {
        public static void VendingMachineCalculate()
        {
            int total = 0;
            int i = 0;
            int[] notes = { 1, 2, 5, 10, 500, 1000 };
            Console.WriteLine("Enter the amount: ");
            int money = Convert.ToInt32(Console.ReadLine());
            //public static int calculate(int money, int[] notes)

            int rem;
            if (money == 0)
            {
                Console.WriteLine("No amount put");
            }
            else
            {
                if (money >= notes[i])
                {
                    int calnotes = money / notes[i];
                    rem = money % notes[i];
                    money = rem;
                    total += calnotes;
                    Console.WriteLine(notes[i] + " Notes--> " + calnotes);
                }
                i++;

            }
        }
    }
}
