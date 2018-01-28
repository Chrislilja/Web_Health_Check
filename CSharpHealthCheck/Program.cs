using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CSharpHealthCheck
{
    class Program
    {
        static void Main(string[] args)
        {


            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 30000;
            aTimer.Enabled = true;

            Console.WriteLine("Press q to quit! This is the monitoring for the front end, so please only do so if required");
            while (Console.Read() != 'q') ;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
                CheckPages check = new CheckPages();
        
              check.chk("Frontend TV", "http://www.waazon.com/tv");
            check.chk("Frontend Web", "http://www.waazon.com/web");
        }
    }
}
