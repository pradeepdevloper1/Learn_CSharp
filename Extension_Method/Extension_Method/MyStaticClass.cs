using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    static class MyStaticClass
    {
        public static void Func3(this Program p)
        {
            Console.WriteLine("This is Function3");
        }
        public static void Func4(this Program p,int i)
        {
            Console.WriteLine("This is Function4:"+i);
        }
        public static Boolean isGreaterThan(this int i,int value)
        {
            return i > value;
        }
    }
}
