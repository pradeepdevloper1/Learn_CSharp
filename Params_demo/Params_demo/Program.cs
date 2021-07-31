using System;

namespace Params_demo
{
    class Program
    {
        public static int add(int a,  int b)
        {
            int sum = a + b;
            return sum;

        }
        public static int addUsingParam(params int[] num)
        {
            int sum = 0;
            foreach (int  item in num)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //   Console.WriteLine(Program.add(10, 20)) ;
            Console.WriteLine(  Program.addUsingParam(10,20,30,40,50));
        }
    }
}
