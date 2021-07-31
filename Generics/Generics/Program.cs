using System;

namespace Generics
{
    class Example
    {
        //public static void showArray(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}
        //public static void showArray(string[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        public static void showArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


    }

    class Example2
    {
        public static bool check<T>(T a,T b)
        {
            bool c = a.Equals(b);
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 11, 22, 33, 44, 55 };

            //string[] names = { "Pradeep", "anuj", "raj", "tarun" };

            //double[] points = {1.2,7.99,62.77,926,77.772 };

            //Example.showArray(numbers);
            //Example.showArray(names);
            //Example.showArray(points);


            Console.WriteLine(Example2.check(10, 10));
            Console.WriteLine(Example2.check("Pradeep", "Pradeep"));
            Console.WriteLine(Example2.check(true, true)); 
            



        }
    }
}
