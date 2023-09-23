using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.DayOne
{
    internal class ThreeFive15
    {
        public static void solve()
        {
            for (int i = 1; i < 101; i++)
            {
                if(i % 15 == 0) { Console.WriteLine("Grapes"); }
                else if(i%3==0) { Console.WriteLine("Apple"); }
                else if(i%5==0) { Console.WriteLine("Orange"); }
                else { Console.WriteLine(i); }
            }
        }

    }
}
