using System;

namespace Sealed_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //int[] a = new int[30]; // Array Declaration in C#  
            int[] a = new int[7] { 10, 9, 11, 12, 7, 10, 11 };
            int n = a.Length-1;
            
            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.Write("Ascending Sort : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            int minmarks = a[0];
            for (i = 1; i <= n; i++)
            {
                if (  a[i]< minmarks)
                {
                    minmarks = a[i]; 
                }
            }
            Console.WriteLine("");

            Console.WriteLine(minmarks);
            int candies = 0,totalcandies=0;
            for (i = 1; i <= n; i++)
            {
                if (a[i] == minmarks)
                {
                    candies = 1;
                }
                if ((a[i] > minmarks) & (a[i] != a[i-1]))
                {
                    candies += 1;
                }
                totalcandies += candies;
            }

            Console.WriteLine(totalcandies);
        }
    }
}