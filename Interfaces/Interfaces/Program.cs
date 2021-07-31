using System;

namespace Interfaces
{
    class Program
    {
        interface IEmployee
        {
            void show();
        }
        class PartTimeEmployees : IEmployee
        {
            public void show()
            {
                Console.WriteLine("this is show method of interface ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
