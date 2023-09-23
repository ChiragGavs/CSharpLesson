
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.lambda
{
    public class DemoThread
    {
        public static void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine($"Thread id  : {id}");
            Console.WriteLine($"IsAlive    : {t1.IsAlive}");
            Console.WriteLine($"Priority   : {t1.Priority}");
            Console.WriteLine($"ThreadState: {t1.ThreadState}");
            Console.WriteLine($"currCulture: {t1.CurrentCulture}");
            t1.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Console.WriteLine($"currCulture: {t1.CurrentCulture}");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            Console.WriteLine($"currCulture: {t1.CurrentCulture}");
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }

        public static void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("Mainth id "+ id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);
            t1.Start();
            Console.WriteLine("---------------------END OF demo -------------------------------");
        }
    }
}
