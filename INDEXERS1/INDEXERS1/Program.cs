using System;

namespace INDEXERS1
{
    class Employee
    {
        private int[] Age = new int[3];

         
        public int this[int index]
        {
            set {
                if(index>=0 && index < Age.Length)
                {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Value is Invalid");
                    }
                }
                else
                {
                    Console.WriteLine("indexer in invalid");
                }
                

            }
            get {
                return Age[index];
            }
        }

        public int this[int index,int i ]
        {
            
            set {
                Age[index] = value + i;
            }
            get {
                return Age[index];
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Employee emp=new Employee();
            //emp[2] = 3;
            //Console.WriteLine( emp[2] );

            emp[0, 1] = 5;
            Console.WriteLine(emp[0]);
        }
    }
}
