using System;

namespace multiple_inheritance
{
    class person
    {
        public void show()
        {
            Console.WriteLine("this is method of person Class ");
        }

    }

    interface Employee
    {
        void show();
    }

    interface Employee1
    {
        void show();
    }
    class Teacher : person, Employee,Employee1
    {
         void Employee.show()
        {
            Console.WriteLine("this is method of Employee Interface ");
        }
        void Employee1.show()
        {
            Console.WriteLine("this is method of Employee1 Interface ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher tc = new Teacher();
            tc.show();

            Employee emp = new Teacher();
            emp.show();

            Employee1 emp1 = new Teacher();
            emp1.show();
        }
    }
}
