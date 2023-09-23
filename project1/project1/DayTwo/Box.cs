using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.DayTwo
{
    internal class Box
    {
        public static int height; 
        public int width;
    }
    internal class TestBox
    {
        public static void TestOne()
        {
            Console.WriteLine(Box.height);
            // static members of a class can be accessed without an objec reffernc
        }
    }
}
