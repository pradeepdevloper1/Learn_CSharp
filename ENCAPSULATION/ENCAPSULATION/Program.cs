using System;

namespace ENCAPSULATION
{
    class person {
        private string Name;
        private int Age;

        public void setName(string Name)
        {
            if (String.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is Required");
            }
            else
            {
                this.Name = Name;
            }
        }

        public void getName()
        {
            if (String.IsNullOrEmpty(Name) == true)
            {
               
            }
            else
            {
                Console.WriteLine("Your Name is: "+this.Name);
            }

        }
        public void setAge(int Age)
        {
            if (Age<=0)
            {
                Console.WriteLine("Age Should Not be Negative or Zero");
            }
            else
            {
                this.Age = Age;
            }
        }

        public void getAge()
        {
            if (Age<=0)
            {

            }
            else
            {
                Console.WriteLine("Your Age is: " + this.Age);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            p1.setName("pradeep");
            p1.getName();
            p1.setAge(24);
            p1.getAge();
            Console.ReadLine();
        }
    }
}
