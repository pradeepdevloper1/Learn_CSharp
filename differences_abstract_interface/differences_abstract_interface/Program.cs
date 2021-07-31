using System;

namespace differences_abstract_interface
{
    class example
    {

    }

    interface i1
    {

    }

    interface i2
    {

    }

    interface myinterface : i1, i2
    {
        void show()
        {

        }
    }

    abstract class myabstract :example,i1,i2
    {
        public abstract void show2();

        public myabstract()
        {
            Console.WriteLine("This is constructor  of abstract class");

        }

        ~myabstract()
        {
            Console.WriteLine("This is destructor  of abstract class");
        }


    }

    class myClass1 : myabstract,myinterface
    {
        public override void show2()
        {
            Console.WriteLine("This is method of abstract class");

        }

        public void show()
        {
            Console.WriteLine("This is method of interface class");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass1 obj = new myClass1();
            
        }
    }
}
