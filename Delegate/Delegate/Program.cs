using System;

namespace Delegate
{
    public delegate void Calculation(int a, int b);
    public delegate void Show_Delegate();
    public delegate void Calculation2(int a);
    class Program
    {
        public static void show()
        {
            Console.WriteLine("This is show method");
        }
        public static void square(int a)
        {
            int result = a * a;
            Console.WriteLine("square of {0}  is  {1} ",a,result);
        }

        public static void cube(int a)
        {
            int result = a * a*a;
            Console.WriteLine("cube of {0}  is  {1} ", a, result);
        }
        public static void Addition(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("Addition Result is :{0}",result);
        }

        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Substraction Result is :{0}", result);
        }

        public static void Mutiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Mutiplication Result is :{0}", result);
        }

        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division Result is :{0}", result);
        }
        static void Main(string[] args)
        {
            

            Calculation obj = new Calculation(Program.Addition);
            obj(10, 2);

            Calculation obj2 = new Calculation(Program.Substraction);
            obj2(30,10);

            Calculation obj3 = new Calculation(Program.Mutiplication);
            obj3(30, 4);

            Calculation obj4 = new Calculation(Program.Division);
            obj4(20, 4);

            Calculation obj5 = new Calculation(Program.Addition);
            obj5.Invoke(10, 2);

            Show_Delegate obj6 = new Show_Delegate(Program.show);
            obj6.Invoke();

            Calculation2 obj7 = new Calculation2(Program.square);
            obj7.Invoke(2);

            Calculation2 obj8 = new Calculation2(Program.cube);
            obj8.Invoke(3);



            Calculation obj9 = new Calculation(Program.Addition);
            obj9 += Substraction;
            obj9 += Mutiplication;
            obj9 += Division;
            obj9.Invoke(150, 100);
        }
    }
}
