using System;
using System.Collections.Generic;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("active", "ready to engage in physically activity");
            myDict.Add("amazing", "causing great surprise");
            myDict.Add("honest", "free of deceit, truthful");
            myDict.Add("patriotic", "expressing devotion");
            myDict.Add("quarintine", "place of isolation");

            string value1;
            Console.WriteLine("Tryget Value---");
            myDict.TryGetValue("honest", out value1);
            Console.WriteLine(value1);


            Console.WriteLine(myDict["active"]);

            foreach (KeyValuePair<string, string> item in myDict)
            {
                Console.WriteLine("Key is :" + item.Key + " Value is :" + item.Value);

            }


            foreach (string key in myDict.Keys)
            {
                Console.WriteLine(key);

            }

            foreach (string value in myDict.Values)
            {
                Console.WriteLine(value);

            }

            //Console.WriteLine("Count -----------");
            //Console.WriteLine(myDict.Count);

            //   Employee emp1 = new Employee()
            //   {   id=101,
            //       name = "Pradeep",
            //       designation = "CTO",
            //       salary = 8928822
            //   };

            //   Employee emp2= new Employee()
            //   {   id=102,
            //       name = "sanjay",
            //       designation = "dev",
            //       salary = 982662
            //   };

            //   Employee emp3 = new Employee()
            //   {   id=103,
            //       name = "raj",
            //       designation = "senior dev",
            //       salary = 425522
            //   };

            //   Employee emp4 = new Employee()
            //   {   id=104,
            //       name = "Akriti",
            //       designation = "Manager",
            //       salary = 62772772
            //   };

            //   Dictionary<int, Employee> myEmployees = new Dictionary<int, Employee>();
            //   myEmployees.Add(emp1.id, emp1);
            //   myEmployees.Add(emp2.id, emp2);
            //   myEmployees.Add(emp3.id, emp3);
            //   myEmployees.Add(emp4.id, emp4);


            //   Console.WriteLine("Count--------");
            ////   Console.WriteLine( myEmployees.Count(emp=>emp.Value.name.StartsWith("P")) );
            //   foreach (var item in myEmployees)
            //   {
            //       Console.WriteLine("employeeID:{0},name:{1},designation:{2},salary{3}",item.Key,item.Value.name, item.Value.designation, item.Value.salary);
            //   }

        }
    }
}
