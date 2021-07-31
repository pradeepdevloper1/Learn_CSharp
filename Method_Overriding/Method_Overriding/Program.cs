using System;

namespace Method_Overriding
{
    class Parent
    {
        public virtual void print() 
        {
            Console.WriteLine("Parent class");
        }
    }
    class Child:Parent
    {
        public override  void print()
        {
            Console.WriteLine("Child class");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Parent  p = new Child();
            p.print();
        }
    }
}
