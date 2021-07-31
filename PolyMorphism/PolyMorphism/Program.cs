using System;

namespace PolyMorphism
{
    class Program
    {
        public void Add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);

        }
        public void Add(int a,int b)
        {
            
            int c = a + b;
            Console.WriteLine(c);

        }
        public void Add(float a,float b)
        {
           
            float c = a + b;
            Console.WriteLine(c);

        }
        public void Add(string a,string b)
        {
            string c = a +" "+ b;
            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {

            Program p = new Program();
            p.Add();
            p.Add(11,88);
            p.Add(1.5f, 2.5f);
            p.Add("Pradeep", "Kumar");
        }
    }
}
