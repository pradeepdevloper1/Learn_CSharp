using System;
using System.Collections.Generic;

namespace GenericList3
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> myNumbers = new List<int>();
            //myNumbers.Add(11);
            //myNumbers.Add(88);
            //myNumbers.Add(84);
            //myNumbers.Add(99);
            //myNumbers.Add(29);
            //myNumbers.Add(46);
            //myNumbers.Add(11);
            //foreach(int num in myNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("Contains-------");
            //Console.WriteLine( myNumbers.Contains(88) );
            //Console.WriteLine(myNumbers.Contains(33));



            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee()
            {
                Name = "Pradeep",
                Age = 26,
                Designation = "CTO"
            };
            Employee emp2 = new Employee()
            {
                Name = "Raj",
                Age = 29,
                Designation = "Product Manager"
            };
            Employee emp3 = new Employee()
            {
                Name = "Anuj",
                Age = 28,
                Designation = "Senior developer"
            };

            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);

            foreach (Employee emp in empList)
            {
                Console.WriteLine("Employee Name :{0} , age:{1},Designation:{2}", emp.Name, emp.Age, emp.Designation);

            }

            Console.WriteLine(empList.Exists(emp=>emp.Name.StartsWith('A')));



            Console.WriteLine("-----------------ToArray");

            Employee[] emparr = empList.ToArray();
            foreach(Employee emp in emparr)
            {
                Console.WriteLine("Employee Name :{0} , age:{1},Designation:{2}", emp.Name, emp.Age, emp.Designation);
            }

            Console.WriteLine("------------------------ToList");
            List<Employee> emplist1 = emparr.ToList();

            foreach (Employee emp in emplist1)
            {
                Console.WriteLine("Employee Name :{0} , age:{1},Designation:{2}", emp.Name, emp.Age, emp.Designation);

            }


        }
    }
}
