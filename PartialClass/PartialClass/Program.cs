using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentPartial obj = new StudentPartial();
            obj.FirstName = "Pradeep";
            obj.LastName = "Kumar";

            Console.WriteLine("Your Complete name is {0}",obj.getFullName());
        }
    }
}
