using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());
            try
            {
                int result = num1 / num2;
                Console.WriteLine("Division Result is :" + result);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide a numbetr by zero");
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("Remaining Statement 1");
            Console.WriteLine("Remaining Statement 2");
            Console.WriteLine("Remaining Statement 3");
        }
    }
}
