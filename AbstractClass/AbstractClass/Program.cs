using System;

namespace AbstractClass
{
    abstract class person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public long PhoneNumber;

        public abstract void printDetails();
    }
    class student:person
    {
        public int RollNo;
        public int Fees;

        public override void printDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Student Name is : {0}",name);
            Console.WriteLine("Student Age is : {0}", this.Age);
            Console.WriteLine("Student PhoneNumber is : {0}", this.PhoneNumber);
            Console.WriteLine("Student RollNo is : {0}", this.RollNo);
            Console.WriteLine("Student Fees is : {0}", this.Fees);

        }
    }
    class teacher:person
    {
        public string qualification;
        public int salary;

        public override void printDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Teacher Name is : {0}", name);
            Console.WriteLine("Teacher Age is : {0}", this.Age);
            Console.WriteLine("Teacher PhoneNumber is : {0}", this.PhoneNumber);
            Console.WriteLine("Teacher qualification is : {0}", this.qualification);
            Console.WriteLine("Teacher salary is : {0}", this.salary);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student st = new student();
            st.FirstName = "Pradeep";
            st.LastName = "Kumar";
            st.Age = 24;
            st.PhoneNumber = 6968698696;
            st.RollNo = 1009;
            st.Fees = 090970;
            st.printDetails();

            Console.WriteLine("---------------------------------");

            teacher tc = new teacher();
            tc.FirstName = "rajesh";
            tc.LastName = "Roshan";
            tc.Age = 40;
            tc.PhoneNumber = 99979767667;
            tc.qualification = "MCA";
            tc.salary = 787880;
            tc.printDetails();
        }
    }
}
