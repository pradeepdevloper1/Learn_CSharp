using System;
using System.Text;
using System.Diagnostics;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            string s1 = "Pradeep";
            sw1.Start();
            for (int i = 0; i < 100000; i++)
            {
                s1 = s1 + 1;
            }
            sw1.Stop();


            StringBuilder sb = new StringBuilder("Pradeep2");
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("Time Taken by String :{0}",sw1.ElapsedMilliseconds);
            Console.WriteLine("Time Taken by StringBuilder :{0}", sw2.ElapsedMilliseconds);
        }
    }
}
