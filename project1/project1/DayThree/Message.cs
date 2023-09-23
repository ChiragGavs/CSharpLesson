using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.DayThree
{
    internal interface IMessage
    {
        public void Send(string message);
       public void Receive(string message);
    }
}
// multiple inheritance is not supported by java and C#
