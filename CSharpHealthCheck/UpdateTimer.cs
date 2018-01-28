using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHealthCheck
{
    class UpdateTimer
    {
        public void update(string node)
        {

            SQLCmd cmdrun = new SQLCmd();

            string test = "";
            string year = Convert.ToString(System.DateTime.UtcNow.Year);
            string month = Convert.ToString(System.DateTime.UtcNow.Month);
            string date = Convert.ToString(System.DateTime.UtcNow.Day);

            string cal = year + "-" + month + "-" + date;



            string hours = Convert.ToString(System.DateTime.UtcNow.Hour);
            string minutes = Convert.ToString(System.DateTime.UtcNow.Minute);
            string seconds = Convert.ToString(System.DateTime.UtcNow.Second);


            string time = hours + ":" + minutes + ":" + seconds;

            //Console.WriteLine(cal);
            //Console.WriteLine(time);

            test = cal + " " + time;
     
            cmdrun.comrun("UPDATE mon_nodes SET LastUpdate = '" + test + "' WHERE Name = '" + node   +"'; ");


        }


    }
}
