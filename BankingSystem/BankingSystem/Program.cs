using System;
using System.Threading;
using BankingSystem.lambda;

public class ThreadExample
{
    public static void ThreadProc()
    {
        ServiceA a1 = new ServiceA();
        Thread t = new Thread(a1.DoTaskA);
        Thread t1 = new Thread(a1.DoTaskA);
        Thread t2 = new Thread(a1.DoTaskA);
        t.Start();
        t1.Start();
        t2.Start();
        t1.Join(7000);
        //if(t1.IsAlive)t1.Abort();
        t2.Join(7000);
        //if(t2.IsAlive)t2.Abort();
        t.Join(7000);
        //if(t.IsAlive)t.Abort();
    }

    
    public static void Main() {
        ThreadProc();
        Console.ReadLine();
    }
}