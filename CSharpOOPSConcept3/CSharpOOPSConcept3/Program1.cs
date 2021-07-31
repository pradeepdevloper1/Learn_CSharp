using System;

namespace CSharpOOPSConcept3
{
    public class class1
    {
        
        public void show1()
        {
            Console.WriteLine(" this is public method");
        }
        public void show2()
        {
            class1 c1 = new class1();
            c1.show1();
        }
    }
    class Program1:class1
    {
       
        static void Main(string[] args)
        {
            //class1 c1 = new class1();
            //c1.show1();
            //Console.ReadLine();

            Program1 p1 = new Program1();
            p1.show1();
            Console.ReadLine();
        }
    }
}
