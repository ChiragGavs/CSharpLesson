using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.demo3
{
    internal class Employee
    {
        public int Eno = 0;
        private readonly Address address; 

        public Employee()
        {
            address = new Address(this);
        }
        public Address GetAddress()
        {
            return address;
        }
        // inner class
        public class Address
        {
            public string address1; 
            public string address2;
            private readonly Employee e1;

            internal Address(Employee outerEmployee) {
                if(outerEmployee != null)
                {
                    throw new InvalidOperationException("outer employee is NULL {|:-(| ")
                    {

                    };
                }
                e1 = outerEmployee;
            }
            public override string ToString()
            {
                return address1 + ", " + address2 + " of " + e1.Eno;
            }
        }

    }
}
