using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.DayOne
{
    internal class Calculator
    {
        public static int Add(int n1 , int n2){ return n1+n2 ; }
        public static int Subtract(int n1 , int n2) { return n1-n2; }
        public static int Divide(int n1, int n2)
        {
            try
            {
                int num = n1 / n2;
                return num; 
            }
            catch (Exception e) { Console.WriteLine("you can not divide number with zero"); }
            return 0; 
        }
        public static int Modulo(int n1, int n2) {  return n1%n2; }
        public static int Multiply(int n1, int n2) { return n1*n2; }
    }
}
