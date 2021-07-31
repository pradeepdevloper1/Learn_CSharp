using System;
using System.Collections.Generic;

namespace GenericList2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> myName = new List<string>();
            //myName.Add("Pradeep");
            //myName.Add("Arjun");
            //myName.Add("Ram");
            //myName.Add("Alok");
            //myName.Add("");
            //myName.Add("Pradeep");
            //myName.Add(null);

            //foreach (string item in myName)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("--------------Add,AddRange,Insert , InsertRange,-----");

            //List<int> myNumbers = new List<int>();
            //myNumbers.Add(21);
            //myNumbers.Add(11);
            //myNumbers.Add(88);
            //myNumbers.Add(9);
            //myNumbers.Add(78);
            //myNumbers.Add(99);


            //foreach (int item in myNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //myNumbers.Sort();
            //Console.WriteLine("List After Sort---------");
            //foreach (int item in myNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("List AddRange---------");
            //myNumbers.AddRange(myNumbers);
            //foreach (int item in myNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Insert--------------");
            //myNumbers.Insert(2, 8);
            //foreach (int item in myNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Insert Range---------------");
            //myNumbers.InsertRange(1, myNumbers);
            //foreach (int item in myNumbers)
            //{
            //    Console.WriteLine(item);
            //}



            //List<int> myNumbers = new List<int>();
            //myNumbers.Add(21);
            //myNumbers.Add(11);
            //myNumbers.Add(88);
            //myNumbers.Add(9);
            //myNumbers.Add(78);
            //myNumbers.Add(99);

            //Console.WriteLine("Contains---------");
            //Console.WriteLine( myNumbers.Contains(88) );


            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee()
            {
                Name = "Pradeep",
                age = 26,
                Designation = "CTO"
            };
            Employee emp2 = new Employee()
            {
                Name = "Raj",
                age = 29,
                Designation = "Product Manager"
            };
            Employee emp3 = new Employee()
            {
                Name = "Anuj",
                age=28,
                Designation="Senior developer"
            };

            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);

            foreach(Employee emp in empList)
            {
                Console.WriteLine("Employee Name :{0} , age:{1},Designation:{2}",emp.Name,emp.age,emp.Designation);

            }

            Console.WriteLine("Remove  all----------");
            empList.RemoveAll(emp => emp.age > 26);
            foreach (Employee emp in empList)
            {
                Console.WriteLine("Employee Name :{0} , age:{1},Designation:{2}", emp.Name, emp.age, emp.Designation);

            }

        }
    }
}
