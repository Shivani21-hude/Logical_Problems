using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class DayofWeek
    {
        public static void DayWeek()
        {
            Console.WriteLine("Enter a day : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            int m = month;
            int y = year;
            int d = day;
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("The Day of week is : ", d0);

            switch (d0)
            {
                case 0:
                    Console.WriteLine("Saturday");
                    break;

                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

            }
        }
    }
}

