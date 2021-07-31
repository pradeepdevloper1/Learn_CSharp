using System;

namespace Interface_abstract_similarity
{
    interface i1
    {
        void print1();
    }

    abstract class abs
    {
        public abstract void print2();
    }
    class example : abs,i1 
    {
        public void print1()
        {
            Console.WriteLine("this is method of interface i1");
        } 

        public override void print2()
        {
            Console.WriteLine("this is method of abstract class");
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            example obj = new example();
            obj.print1();
            obj.print2();

        }
    }
}
