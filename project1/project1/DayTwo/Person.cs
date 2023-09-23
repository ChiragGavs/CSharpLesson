using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace project1.DayTwo
{
    internal class Person
    {
        public int ID { get; set; }
        public String Name { get; set; } = String.Empty;
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String Title { get; set; } = String.Empty;
        public String Address { get; set; } = string.Empty;
        public String City { get; set; } = string.Empty;
        public String Region { get; set; } = string.Empty;
        public String PostalCode { get; set; } = string.Empty;
        public String Country { get; set; } = string.Empty;
        public long Phone { get; set; }

        public override string ToString()
        {
            return $"ID : {this.ID}, Name:{Title}+{FirstName}+{LastName}\n" +
                   $"phone: {Phone}, Address: {Address}, City: {City},country: {Country}, Region: {Region}, PostalCode: {PostalCode}";
        }
    }
     internal class TestPerson 
    {     
        public static void TestOne()
        {
            Person firstPerson = new Person();
            firstPerson.ID = 1;
            firstPerson.FirstName = "Chirag";
            firstPerson.LastName = "Rohilla";
            firstPerson.Title = "Mr.";
            firstPerson.Address = "WestDelhi";
            firstPerson.City = "Delhi";
            firstPerson.Country = "India";
            firstPerson.Region = "Uttam Nagar";
            firstPerson.Phone = 9999999999;
            firstPerson.PostalCode = "110059";
            string value=firstPerson.ToString();
            Console.WriteLine(value);

        }
    }
}
