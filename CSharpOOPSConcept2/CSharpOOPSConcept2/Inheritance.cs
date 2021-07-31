using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOPSConcept2
{ 
    ////single Inheritance
    class BaseClass
    {
        public void show1()
        {
            Console.WriteLine("this is a method of base class");
        }
    }

    class DerivedClass1 : BaseClass
    {
        public void show2()
        {
            Console.WriteLine("this is a method of Derived1 class");
        }
    }
    class DerivedClass2 : DerivedClass1
    {
        public void show3()
        {
            Console.WriteLine("this is a method of Derived2 class");
        }
    }
    class Inheritance
    {
    }
}
