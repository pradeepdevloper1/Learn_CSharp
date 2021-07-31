using System;

namespace formatException1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            string number = Console.ReadLine();
            try {
                int num = int.Parse(number);
                Console.WriteLine("Number is : " + num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(" String Format is invalid");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
