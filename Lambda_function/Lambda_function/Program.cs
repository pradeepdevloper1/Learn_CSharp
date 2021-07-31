using System;

namespace Lambda_function
{
    // public delegate void MyDelegate(int num);

    public delegate int MyDelegate2(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {

            //MyDelegate obj = ( a)=> {
            //    a += 5;
            //    Console.WriteLine(a);
            //};
            //obj.Invoke(5);

            MyDelegate2 obj = (a, b) => a + b;
            int output = obj.Invoke(11,22);
            Console.WriteLine(output);
        }
    }
}
