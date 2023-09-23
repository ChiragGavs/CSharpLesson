using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.lambda
{
    internal class Lambdafunc
    {
        static void DemoA()
        {
            Func<int, int, int> foo = (x, y) => (x + y) / 2;
            int i = 100;
            int j = 40; 
            int result = foo(i, j);   
            Console.WriteLine(result);  
        }
    }
}
