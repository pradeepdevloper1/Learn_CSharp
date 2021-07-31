using System;

namespace Interface_Inheritance
{
    interface i1
    {
        void print1();
    }
    interface i2
    {
        void print2();
    }
    interface i3:i1,i2
    {
        void print3();
    }

    class Program:i3
    {
        public void print1()
        {
            Console.WriteLine("This is a method of interface 1");
        }
        public void print2()
        {
            Console.WriteLine("This is a method of interface 2");
        }
        public void print3() {
            Console.WriteLine("This is a method of interface 3");
        }
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.print1();
            //p.print2();
            //p.print3();

            i1 myinterface1 = new Program();
            myinterface1.print1();

            i3 myinterface3 = new Program();
            myinterface3.print1();
            myinterface3.print2();
            myinterface3.print3();
        }
    }
}
