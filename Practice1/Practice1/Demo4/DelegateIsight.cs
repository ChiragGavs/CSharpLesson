using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Demo4
{
    public delegate void MethodHandlerA();
    public delegate int MethodHandlerB(int x, int y);

    public class MathCalculator
    {
        public void DoTask()
        {
            Console.WriteLine("Doing....");
        }
        public int Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y}");
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y}");
            return x - y;

        }
        public int Multiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y}");
            return x * y;
        }
        public double Divide(double x, double y)
        {
            Console.WriteLine($"{x} / {y} ");
            return x / y;
        }
        public string GetModel()
        {
            return "X500";
        }
    }

    public class DelegateDemo
    {
        public static void TestOne()
        {
            MathCalculator mc = new MathCalculator();
            MethodHandlerA methodHandlerA = mc.DoTask;//new MethodHandlerA(mc.DoTask);
            MethodHandlerB methodHandlerB = mc.Add;// new MethodHandlerB(mc.Add);
            methodHandlerB += mc.Subtract;//new MethodHandlerB(mc.Subtract);
            methodHandlerB += mc.Multiply;// new MethodHandlerB(mc.Multiply);
            //MethodHandlerB methodHandlerB3 = new MethodHandlerB(mc.Divide);
            methodHandlerA();
            int addres = methodHandlerB(100, 230);
            Console.WriteLine(addres);
            methodHandlerB(100, 40);
        }
    }

}
