using System;

namespace Structures_Demo1
{
    struct Program
    {
        public void func1()
        {
            Console.WriteLine("This is function 1 ");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.func1();

                }
    }
}
