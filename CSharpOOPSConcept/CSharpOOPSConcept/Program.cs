using System;

namespace CSharpOOPSConcept
{

    //Destructors
    class Person {
        public string name;
        public int age;

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;

        }

        public string getName()
        {
            return this.name;
        }

        ~Person()
        {
            Console.WriteLine("destructor is Invoked");
        }

    }

    ////Stacic Class
    //static class Product 
    //{
    //    public static int ProductID;
    //    public static string ProductName;
    //    public static  float ProductPrice;

    //    static Product()
    //    {
    //        ProductID = 199;
    //        ProductName = "Oreao Biscuit";
    //        ProductPrice = 4400;
    //    }

    //    public static void getProductDetails()
    //    {
    //        Console.WriteLine("ProductID is :{0}",ProductID);
    //        Console.WriteLine("ProductName is :{0}", ProductName);
    //        Console.WriteLine("ProductPrice is :{0}", ProductPrice);
    //    }

    //    public static void getDiscount()
    //    {
    //        float d_amt = ProductPrice / 10;

    //        Console.WriteLine("Discount amount  is :{0}", d_amt);
    //        Console.WriteLine("Total cost of Product is :{0}", ProductPrice-d_amt);
    //    }
    //}
    
    ///private constructor
    //class Example
    //{
    //    public static int a;
    //    public string name;
    //    public int age;
    //    private Example()
    //    {

    //    }
    //    public Example(string name,int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }
    //    public static int getIncrement(int a)
    //    {
    //        return ++a;
    //    }
    //    public static void getTime()
    //    {
    //        Console.WriteLine(DateTime.Now);
    //    }
    //}


    ////Copy Constructor 
    //class Example 
    //{
    //    string name;
    //    int age;
    //    public Example(string name,int age )
    //    {
    //        this.name = name;
    //        this.age = age;

    //    }
    //    public Example(Example e)
    //    {
    //        this.name = e.name;
    //        this.age = e.age;

    //    }
    //    public  void getDetails()
    //    {
    //        Console.WriteLine("Person Name is :{0}", name);
    //        Console.WriteLine("Person Age  is :{0}", age);
    //    }
    //}

    //    //static constructor 
    //    class Person{
    //        public static string PersonName;
    //        public static int PersonAge;

    //       public  Person()
    //        {
    //            Console.WriteLine("Default Constructor Invoked ....!");

    //        }
    //        static Person()
    //        {
    //            PersonName = "Pradeep";
    //            PersonAge = 25;
    //            Console.WriteLine("Static Constructor is invoked");   
    //        }
    //        public static void getDetails()
    //        {
    //            Console.WriteLine("Person Name is :{0}",PersonName);
    //            Console.WriteLine("Person Age  is :{0}", PersonAge);
    //        }
    //    }

    //instance member
    //class Student 
    //{
    //    public int rollno;
    //    public string firstname;
    //    public string lastname;
    //    public static string schoolname="Modern School";

    //    public void getFullname()
    //    {
    //        Console.WriteLine("Full name is: {0}", this.firstname + this.lastname);
    //    }

    //    public static int getAnnualFees(int fee)
    //    {
    //        return fee;
    //    }       

    //}
    class Program
    {
        //int rollNo;
        //string name;
        //int age;
        //int standard;

        //public void setRollNo(int rollNo) 
        //{
        //    this.rollNo = rollNo;
        //}
        //public int getRollNo()
        //{
        //    return this.rollNo;
        //}


        //public void setname(string name)
        //{
        //    this.name = name;
        //}
        //public string getname()
        //{
        //    return this.name;
        //}


        //public void setage(int age)
        //{
        //    this.age = age;
        //}
        //public int getage()
        //{
        //    return this.age;
        //}


        //public void setstandard(int standard)
        //{
        //    this.standard = standard;
        //}
        //public int getstandard()
        //{
        //    return this.standard;
        //}

        //public void setstudent(int rollNo,string name,int age,int standard)
        //{
        //    this.rollNo = rollNo;
        //    this.name = name;
        //    this.age = age;
        //    this.standard = standard;
        //}
        //public void getstudent()
        //{
        //    Console.WriteLine(this.rollNo);
        //    Console.WriteLine(this.name);
        //    Console.WriteLine(this.age);
        //    Console.WriteLine(this.standard);
        //}

        ////Default Constructor
        //public Program()
        //{
        //    Console.WriteLine("Default Coonstructor Invoked....");
        //}

        //Parameterized Constructor
        //public Program(string a,int b)
        //{
        //    Console.WriteLine("Parameterized Coonstructor Invoked...."+a+b);
        //}

        ////constructor overloading 
        //public Program()
        //{
        //    Console.WriteLine("Default Coonstructor Invoked....");

        //}
        //public Program(int a , int b)
        //{
        //    Console.WriteLine("parameterized Coonstructor Invoked.... {0}",(a+b));

        //}


        static void Main(string[] args)
        {
            //Console.WriteLine("Classes=--------------");
            //Program obj = new Program();
            //obj.setstudent(15737272,"pradeep",23,12);
            //obj.getstudent();

            //Console.WriteLine("Classes=--------------");
            //Program obj2 = new Program();
            //obj2.setstudent(4323232, "anuj", 28, 12);
            //obj2.getstudent();
            //Console.ReadLine(  );


            ////Default Constructor
            //Program p1 = new Program();
            //Console.ReadLine();

            ////Parameterized Constructor
            //Program p1 = new Program("Pradeep",24);
            //Console.ReadLine();



            ////Constructor Overloading
            //Program p1 = new Program();
            //Program p2= new Program(10, 24);
            //Console.ReadLine();


            ////Instance member
            //Student s1 = new Student();
            //s1.rollno = 11;
            //s1.firstname = "Pradeep";
            //s1.lastname = "Kumar";
            //Console.WriteLine("RollNo is: {0}",s1.rollno);
            //s1.getFullname();

            //Student s2 = new Student();
            //s2.rollno = 21;
            //s2.firstname = "Anuj";
            //s2.lastname = "Panday";
            //Console.WriteLine("RollNo is: {0}", s2.rollno);
            //s2.getFullname();

            //static member
            //Student s1 = new Student();
            //s1.rollno = 11;
            //s1.firstname = "Pradeep";
            //s1.lastname = "Kumar";
            //Console.WriteLine("RollNo is: {0}", s1.rollno);
            //s1.getFullname();
            //Console.WriteLine("School name is: {0}", Student.schoolname);
            //Console.WriteLine("School name is: {0}", Student.getAnnualFees(20000));






            ////static Constructor 
            //Person ps1 = new Person();
            //Person ps2 = new Person();
            //Person.getDetails();




            ////copy Constructor 
            //Example e = new Example("Pradeep", 25);
            //e.getDetails();
            //Example e1 = new Example( e);
            //e1.getDetails();





            ////private constructor
            //Example.getTime();
            //Example.a = 12;
            //Console.WriteLine(Example.getIncrement(Example.a));
            //Example ex = new Example("anuj", 34);
            //Console.WriteLine(ex.name+ex.age);

            ////static class
            //Product.getProductDetails();
            //Product.getDiscount();



            //Destructor
            Person p1 = new Person("Pradeep",24);
            Person p2 = new Person("anuj", 29);

            Console.WriteLine("Name is {0}",p1.getName());
            Console.WriteLine("Name is {0}", p2.getName());

        }

    }
}
