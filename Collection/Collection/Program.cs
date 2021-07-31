using System;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = new int[3];
            //Array.Resize(ref myArray, 4);
            //myArray[0] = 10;
            //myArray[1] = 20;
            //myArray[2] = 30;
            //myArray[3] = 40;





            //for (int i = 0; i <myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}


            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add("Pradeep");
            myList.Add(10.88);
            myList.Add(true);
            myList.Add(88.727f);
            Console.WriteLine(myList.Capacity);  //8


            foreach(object obj in myList)
            {
                Console.Write(obj +"  ");
            }

            Console.WriteLine();

            myList.Insert(2,25);
            
            foreach (object obj in myList)
            {
                Console.Write(obj + "  ");
            }

            myList.Remove(25);
            myList.RemoveAt(2);

        }
    }
}
