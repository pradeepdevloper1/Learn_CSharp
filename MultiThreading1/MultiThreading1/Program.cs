using System;
using System.Threading;
namespace MultiThreading1
{
    class Program
    {
        public static void func1()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Func1="+i);
            }
        }
        public static void func2()
        {
            for (int i = 0; i <=50; i++)
            {
                Console.WriteLine("Func2=" + i);
                if (i == 25)
                {
                    Console.WriteLine("Thread is going to sleep for 8 seconds ");
                    Thread.Sleep(8000);
                }
            }
        }
        public static void func3()
         {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("Func3=" + i);
                }
         }
        
        static void Main(string[] args)
        {
            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            t1.Start();
            t2.Start();
            t3.Start();

            //Program.func1();
            //Program.func2();
            //Program.func3();

            //Thread th = Thread.CurrentThread;
            //th.Name = "Main Thread";
            //Console.WriteLine("Current Executing Thread"+Thread.CurrentThread.Name);

            
        }
    }
}
