using System;

namespace NullReferenceException
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                string name = null;

                Console.WriteLine(name.Length);
            }
            catch (Exception ex) {
                Console.WriteLine( ex.Message );
            }
          
        }
    }
}
