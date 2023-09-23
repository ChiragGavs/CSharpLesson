using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace project1.DayOne
{
    internal class Statements
    {
        public static void TestOne()
        {
            Console.WriteLine("Enter your Age :");
            String ageAsString = Console.ReadLine();
            if (!IsNumeric(ageAsString))
            {
                return;
            }
            int age = int.Parse(ageAsString);
            if (age < 18)
            {
                Console.WriteLine("sorry you can not drive .");
            }
            else
            {
                Console.WriteLine("yes! you can drive.");
            }
        }
        public static bool IsNumeric(String Pvalue) {
            bool result = false;
            if (Pvalue == null)
            {
                Console.WriteLine("NULL not allowed!!!");
                return result;
            }
            char[] data= Pvalue.ToCharArray();
            int length= data.Length;
            for(int i = 0; i < length; i++) { 
                char c = data[i];
                int ascii = (int)c;
                if (ascii < 48 || ascii > 57) {
                    Console.WriteLine("not a number");
                    return false; }
            }
            return true;
        }
    }
}
