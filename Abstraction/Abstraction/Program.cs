using System;

namespace Abstraction
{
    class Employee
    {
        public int EmpID;
        public string EmpName;
        public double GrossPay;
        double TaxDeduction = 0.1;
        double netSalary;
        public Employee(int EID,string EName,double EGrossPay) {
            this.EmpID = EID;
            this.EmpName = EName;
            this.GrossPay = EGrossPay;
        }
        private void CalculateSalary()
        {
            if (GrossPay >= 40000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your Salary is: {0}",netSalary);
            }
            else
            {
                netSalary = GrossPay;
                Console.WriteLine("Your Salary is: {0}", netSalary);
            }
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee ID is :{0}",this.EmpID);
            Console.WriteLine("Employee Name is :{0}", this.EmpName);
            this.CalculateSalary();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(100,"Pradeep",35000);
            emp.ShowEmployeeDetails();
        }
    }
}
