using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.DayThree
{
    internal class Box
    {
        public int Height;
        public int Length;
        public int Width;



        public Box()
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }

        public override string ToString()
        {
            return $"Height: {Height}, Width: {Width}, length: {Length}";
        }
    }
    internal class WoodenBox : Box {
            public WoodenBox() { Console.WriteLine("wooden box constructed"); }
    }
    internal class BoxTester
    {
        public static void TestOne()
        {
            WoodenBox box = new WoodenBox();
            box.Open();
            box.Close();
            box.ToString();
            Console.WriteLine(box.ToString());
        }
    }
}
