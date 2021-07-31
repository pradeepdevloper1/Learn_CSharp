using System;

namespace tryWithMultipleCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                //int a = 10;
                //int b = 0;
                //int c = a / b;

                string name = null;
                Console.WriteLine(name.Length);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
