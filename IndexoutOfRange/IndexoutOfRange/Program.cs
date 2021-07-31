using System;

namespace IndexoutOfRange
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[3];
                arr[0] = 11;
                arr[1] = 22;
                arr[2] = 33;
                arr[3] = 44;

                foreach (int item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of Range");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
