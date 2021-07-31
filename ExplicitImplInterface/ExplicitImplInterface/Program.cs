using System;

namespace ExplicitImplInterface
{ 
    interface i1
    {
        void show();
    }
    interface i2
    {
        void show();
    }
    class myClass : i1,i2
    {
        void i1.show()
        {
            Console.WriteLine("this is implementation method of interface 1");
        }
        void i2.show()
        {
            Console.WriteLine("this is implementation method of interface 2");
        }
            }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            ((i1)obj).show();
            ((i2)obj).show();

            Console.WriteLine("---------------------------");

            i1 obj1 = new myClass();
            obj1.show();

            i2 obj2 = new myClass();
            obj2.show();

        }
    }
}
