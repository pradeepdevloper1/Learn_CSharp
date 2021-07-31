using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("ID", 1453);
            ht.Add("Name", "Pradeep");
            ht.Add("Salary", 25000);
            ht.Add("Designation", "ERP Developer");
            ht.Add("IsMarried", false);
           // Console.WriteLine(ht["ID"]);


            Hashtable ht2 = new Hashtable()
            {
                { "ID", 1453 },
                { "Name", "Pradeep"},
                { "Salary", 250000 },
                { "Designation", "ERP Developer" },
                { "IsMarried", false }
            };

            // Console.WriteLine(ht2["Salary"]);

            foreach (Object Key in ht.Keys  )
            {
                Console.WriteLine(Key);
            }

            Console.WriteLine("----------------------");

            foreach (Object Value in ht.Values)
            {
                Console.WriteLine(Value);
            }

            Console.WriteLine("----------------------");

            foreach (Object key in ht.Keys)
            {
                Console.WriteLine(key +" "+ ht[key]);
            }


            Console.WriteLine("-------------------");
            Console.WriteLine(ht.Contains("Name"));
            Console.WriteLine(ht.ContainsKey("Name"));
            Console.WriteLine(ht.ContainsValue("Pradeep"));

            Console.WriteLine("-------------------");
            ht.Remove("Salary");
            foreach (Object key in ht.Keys)
            {
                Console.WriteLine(key + " " + ht[key]);
            }



            Console.WriteLine("-------------------");
            Console.WriteLine(ht["Name"].GetHashCode());
            Console.WriteLine(ht.Count);
          
        }


    }
    }

