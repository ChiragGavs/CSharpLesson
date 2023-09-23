using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace project1.DayFour
{
    internal class Demo
    {
        public static void FirstMethod()
        {
            Console.WriteLine(DateTime.Now);
            DateTime d1 = new DateTime(2018, 04, 10);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());
        }
    }
}
