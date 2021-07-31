using System;

namespace AnonymousFunctionDemo
{
    public delegate void myDelegate(int a);
    class Program
    {
        public static void mymethod(myDelegate del, int a)
        {
            a = a + 10;
            del.Invoke(a);
        }

        static void Main(string[] args)
        {
            //myDelegate obj = delegate (int a) {
            //    a += 10;
            //    Console.WriteLine(a);
            //};

            //obj.Invoke(66);



            Program.mymethod(delegate (int b) { b += 10; Console.WriteLine(b); }, 5);
        }
    }
}
