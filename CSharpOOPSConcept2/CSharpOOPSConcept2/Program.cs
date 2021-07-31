using System;

namespace CSharpOOPSConcept2
{
    ////inheritance
    //class VisitingEmployees: Employees
    //{
    //    public int VisitingSalary;
    //    public int VisitingHours;

    //}
    //class PermanentEmployees: Employees
    //{
    //    public int PermanentSalary;
    //    public int PermanentHours;

    //}

    //class Employees
    //{
    //    public int EmpID;
    //    public String EmpName;
    //    public int EmpAge;
    //    public int EmpContactNo;
    //}


   

    class Program
    {
        static void Main(string[] args)
        {

            ////inheritance
            //PermanentEmployees pe = new PermanentEmployees();
            //pe.EmpID = 101;

            //VisitingEmployees ve = new VisitingEmployees();
            //ve.EmpID = 102;

            //Console.WriteLine(pe.EmpID);
            //Console.WriteLine(ve.EmpID);



            ////single Inheritance

            DerivedClass1 dc1 = new DerivedClass1();
            dc1.show1();
            dc1.show2();
            DerivedClass2 dc2 = new DerivedClass2();
            dc2.show3();
            dc2.show2();

        }
    }
}
