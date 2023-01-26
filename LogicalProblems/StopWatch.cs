using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class StopWatch
    {
        DateTime StartTime;

        public void Start()
        {
           
           
            StartTime = DateTime.Now;
            Console.WriteLine("Stopwatch startd");
            Console.WriteLine("Press 2 to stop the watch ");
            Select();
        }
        public void Stop(DateTime StartTime)
        {
            long minutes, seconds;
            double elapsed_secs;
            double Elapsed_Time;
           
            DateTime EndTime = DateTime.Now;

            //calculating elapsed time
            Elapsed_Time = ((TimeSpan)(EndTime - StartTime)).TotalMilliseconds;
          
            minutes = Convert.ToInt64((Elapsed_Time / 1000) / 60);
            elapsed_secs = ((Elapsed_Time / 1000) % 60);
            seconds = Convert.ToInt64(elapsed_secs);
           
           
            Console.WriteLine("Stop watch has been stopped in a duration of :  ");
          
            Console.WriteLine("{0} minutes {1} seconds ",minutes,seconds);
        }
        public void Select()
        {
            
            
            int select=Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Start();
                    break;
                case 2:
                    Stop(StartTime);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
        public void Selection()
        {
            Console.WriteLine(" **** StopWatch ****\n");
            Console.WriteLine("Press one to start the watch");
            Select();

        }
    }
}
