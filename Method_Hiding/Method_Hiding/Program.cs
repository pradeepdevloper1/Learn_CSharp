using System;

namespace Method_Hiding
{ 
    class Parent
    {
        public void show()
        {
            Console.WriteLine(  "Parent Class");
        }
    }
    class Child: Parent
    {
        public new void show()
        {
            base.show();
            //Console.WriteLine("Child Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Child c = new Child();
            //c.show();
            //((Parent)c).show();
            Parent p = new Child();
            p.show();
        }
    }
}
