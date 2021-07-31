using System;

namespace TryCatchWithFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            //try {
            //    int a = 10;
            //    int b = 0;
            //    int c = a / b;
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Block is executed");
            //}



            Console.WriteLine("EnterAge");
            int Age = int.Parse(Console.ReadLine());
            try
            {
                if (Age >= 18)
                {
                    Console.WriteLine("You are eligible to Vote");
                }
                else
                {
                    throw new Exception("You are not eligible to vote");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(  ex.Message);


            }
        }
    }
}
