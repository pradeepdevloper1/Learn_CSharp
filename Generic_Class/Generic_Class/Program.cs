using System;

namespace Generic_Class
{

    class Example<T>
    {
        T box;
        public T Box {
            get { return this.box; }
            set { this.box = value; } 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example<int> obj = new Example<int>();
            obj.Box = 20;
            Console.WriteLine( obj.Box );

            Example<string> obj2 = new Example<string>();
            obj2.Box = "Pradeep";
            Console.WriteLine(obj2.Box);



        }
    }
}
