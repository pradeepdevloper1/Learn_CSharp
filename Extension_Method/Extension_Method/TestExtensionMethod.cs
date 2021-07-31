using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    class TestExtensionMethod
    {
        static void Main()
        {
            Program p2 = new Program();
            p2.func1();
            p2.func2();
            p2.Func3();
            p2.Func4(99);
            int i = 20;
            Boolean result = i.isGreaterThan(30);
            Console.WriteLine(result);

        }
    }
}
