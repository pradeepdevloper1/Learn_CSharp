using System;

namespace IntroductionToCSHARP
{
    class Program
    {
        ////non static method
        //public void show()
        //{
        //    Console.WriteLine("welcome to non static method ofc#");
        //    Console.WriteLine("this is Pradeep");
        //}

        ////static method
        //public static void show1()
        //{
        //    Console.WriteLine("welcome to static method of c#");
        //    Console.WriteLine("this is Pradeep kumar");
        //}

        //public static void add(int a, int b)
        //{
        //    int result = a + b;
        //    Console.WriteLine("Addition result is"+ result);
        //}



        //optional argument
        //public static void showAge(int age=18) {
        //    Console.WriteLine("Your age is:" + age);
        //}


        //named argument
        public static void show_NameAge(String Name,int age)
        {
            Console.WriteLine("Your Name is:" + Name);
            Console.WriteLine("Your age is:" + age);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your FirstName");
            //String fName=Console.ReadLine();
            //Console.WriteLine("Enter your LastName");
            //String lName = Console.ReadLine();
            //Console.WriteLine("Your Name is :"+fName+" "+lName); // concatenation
            ////Console.WriteLine("Your Name is :{0} {1}" , fName,lName); //placeholder


            //Console.WriteLine("Enter first No.");
            //int firstNo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second No.");
            //int secondNo = int.Parse(Console.ReadLine());
            //int sum = firstNo + secondNo;
            //Console.WriteLine("Sum is {0}", sum);
            //Console.ReadLine();


            ////precision  sum of digit before or after decimal
            //float a = 1234.1234f; //7precision 1234.123
            //double b = 123456789.123456789d; //16 precision 123456789.1234567
            //decimal c = 123456789123456789.1234567891234567m; //29 precision
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);



            ////escape sequence character   and verbatim literals
            //char c = 'a';
            //string str = "welcome to cSharp";
            //string estr = "one\ntwo\nthree";
            //string v = @"D:\amgularapp\angapp";
            //Console.WriteLine(c);
            //Console.WriteLine(str);
            //Console.WriteLine(estr);
            //Console.WriteLine(v);
            //Console.WriteLine();



            ////arrays
            //Console.WriteLine("int Arrays in c#");
            //int[] ar1 = new int[3];
            //ar1[0] = 1;
            //ar1[1] = 2;
            //ar1[2] = 3;
            //Console.WriteLine(ar1[0]);
            //Console.WriteLine(ar1[1]);
            //Console.WriteLine(ar1[2]);
            //Console.ReadLine();

            // ////String array
            // Console.WriteLine("string Arrays in c#");
            //// string[] ar1 = new string[3] { "raj","ram","anuj"};
            // string[] ar1 = { "raj", "ram", "anuj" };
            // Console.WriteLine(ar1[0]);
            // Console.WriteLine(ar1[1]);
            // Console.WriteLine(ar1[2]);
            // Console.ReadLine();



            //////String array
            //Console.WriteLine("For Each Loop in c#");
            //// string[] ar1 = new string[3] { "raj","ram","anuj"};
            //string[] ar1 = { "raj", "ram", "anuj" };
            //foreach(string item in ar1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();


            //    Console.WriteLine("Multi dimensional array in c#");
            //    int[,] ar1 =new int[3,4] { {1,2,3,11}, { 4, 5, 6,12 }, { 7, 8, 9,13 } };
            //    foreach (int item in ar1)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("---------------");
            //    Console.WriteLine(ar1.GetLength(0));
            //    Console.WriteLine(ar1.GetLength(1));
            //    Console.WriteLine(ar1.Rank);
            //    Console.WriteLine("---------------");
            //    for (int i=0;i<3;i++) {
            //        for (int j = 0; j < 4; i++) {
            //            Console.Write(ar1[i,j]+" ");

            //        }
            //        Console.WriteLine();
            //    }

            //    Console.ReadLine();         ////Multi dimensional array





            ////jagged array
            //Console.WriteLine("---------------jagged array");
            //int[][] my_array = new int[3][];
            //my_array[0] = new[] {11,12,13,14 };
            //my_array[1] = new[] { 15,16,17,18,19,20 };
            //my_array[2] = new[] { 21,22,23,24,25,26,27,28,29 };
            //foreach (int[] item in my_array)
            //{
            //    foreach (int i in item)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.ReadLine();




            ////array
            //Console.WriteLine("How many number of items you want to enter?");
            //int num = int.Parse(Console.ReadLine());
            //int[] numbers = new int[num];
            //for(int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("enter number ");
            //    int data = int.Parse(Console.ReadLine());
            //    numbers[i] = data;
            //}
            //foreach(int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();






            //////non static methods
            //Program p1 = new Program();
            //p1.show();
            //Program.show1();


            ////paremeterized method
            //Program.add(10, 11);
            //Program.add(20, 30);


            //optionalparameter
            //Program.showAge();
            //Program.showAge(22);




            ////name argument
            //Program.show_NameAge("Pradeep", 24);
            //Console.WriteLine("-------------");
            //Program.show_NameAge(age:24,Name:"Pradeep");
            //Console.ReadLine();


            //value type
            //Employee e = new Employee();
            //e.Salary = 798770;
            //e.age = 26;

            //Employee e1 = e;
            //Employee e2 = e;
            //e.age = 28;

            //Console.WriteLine("value type object ");
            //Console.WriteLine("value of e age"+e.age);
            //Console.WriteLine("value of e1 age" + e1.age);
            //Console.WriteLine("value of e2 age" + e2.age);
            //Console.WriteLine();



            ////Reference type
            //Employee e = new Employee();
            //e.Salary = 798770;
            //e.age = 26;

            //Employee e1 = e;
            //Employee e2 = e;
            //e.age = 28;

            //Console.WriteLine("Reference type object ");
            //Console.WriteLine("value of e age" + e.age);
            //Console.WriteLine("value of e1 age" + e1.age);
            //Console.WriteLine("value of e2 age" + e2.age);
            //Console.WriteLine();


            ////Passby Value
            //int value = 5;
            //Clsmethods.passByValueMethod(value);
            //Console.WriteLine("pass by value method : {0}", value);


            ////Passby reference
            //int value = 5;
            //Clsmethods.passByReferenceMethod(ref value);
            //Console.WriteLine("pass by reference method : {0}", value);
            //Console.ReadLine();



            ////Passby out
            //int value ;
            //Clsmethods.passByOutMethod(out value);
            //Console.WriteLine("pass by out method : {0}", value);
            //Console.ReadLine();



            ////dynamic type
            //Console.WriteLine(Clsmethods.dynamicTypeMethod(55));
            //Console.WriteLine(Clsmethods.dynamicTypeMethod("Pradeep"));
            //Console.WriteLine(Clsmethods.dynamicTypeMethod(true));
            //Console.WriteLine(Clsmethods.dynamicTypeMethod(24.889f));
            //Console.ReadLine();





        }
    }
}
