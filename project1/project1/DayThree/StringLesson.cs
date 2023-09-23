using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace project1.DayThree
{
    internal class StringLesson
    {
        public static void Demo()
        {
            string firstString = "hello";
            char[] data = { 'H', 'e', 'l', 'l', 'o' };
            String secondString = new String(data);
            Console.WriteLine(firstString+" "+secondString);
            String thirdString = String.Empty;
            int x = 0;
        }
        public static void DemoB() {
            string s1 = "Tom and Jerry are good friends";
            Console.WriteLine($"length {s1.Length}");
            Char[] data = s1.ToCharArray();
            foreach(Char c1 in data)
            {
                Console.WriteLine(c1);
            }
        }
        public static void DemoC()
        {
            String s2 = " tom and jerry are good friends";
            string[] words = s2.Split(' ');
            Console.WriteLine($"Word Count: {words.Count()}");
            foreach(var item in words)
            {
               Console.WriteLine(item);
            }
        }
    }
}
