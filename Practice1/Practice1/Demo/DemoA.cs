﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Demo
{
    internal class DemoA
    {
        public static void SecondMethod()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            int year = d1.Year;
            Console.WriteLine("Year OF Dob " + year);
            int month = d1.Month;
            Console.WriteLine("Month OF Dob " + month);
            int day = d1.Day;
            Console.WriteLine("Day OF Dob " + day);
            DateTime d2 = d1.AddMonths(10);
            Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
            DateTime d3 = d1.AddDays(5);
            Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
            DateTime d4 = d1.AddYears(58);
            Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
            DateTime d5 = d1.AddYears(-5);
            Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        }

        public static void FindPersonAge()
        {
            string age = string.Empty;
            Console.WriteLine("enter your date of birth!!!  : (YYYY/MM/DD");
            string DOB = Console.ReadLine();
            DateTime d1 = DateTime.Parse(DOB);
            DateTime d2 = DateTime.Now;
            int month = d2.Month - d1.Month;
            int year = d2.Year - d1.Year;
            if(d2.Day > d1.Day)
            {
                month--;
            }
            if(month < 0) 
            { 
                year--;
                month+=12;
            }
            int days = 0; 
            if (d2.Day-d1.Day >= 0) { days = d2.Day - d1.Day; }
            else
            {
                int maxday = DateTime.DaysInMonth(d1.Year, d1.Month);
                days = d2.Day-d1.Day + maxday;
                
            }
            Console.WriteLine($"you are {year} years, {month} months, {days} Days old");


            String thanks = Console.ReadLine() ;
            Console.WriteLine(thanks);

        }

        public static void RetirementDate()
        {
            Console.WriteLine("date of birth : ");
            string DOB = Console.ReadLine();
            DateTime D1 = DateTime.Parse(DOB);
            int years = D1.Year + 60;

            int day = DateTime.DaysInMonth(years, D1.Month);
            Console.WriteLine( $"date of retirement is {day}/{D1.Month}/{years}");
            String st = Console.ReadLine();
        }
        
    }
}
