using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Demo
{
    internal class Employee
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string JobTitle { get; set; }
        public enum Designation { MANAGERM, Admn }
    }
}
