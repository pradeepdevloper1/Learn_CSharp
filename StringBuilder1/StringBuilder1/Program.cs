using System;
using System.Text;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Pradeep");
            sb1.AppendLine("Kumar");
            sb1.AppendLine("Sftware Developer");
            sb1.AppendFormat("{0:C}", 25);
            //sb1.AppendFormat("{0:N}", 25);
            //sb1.AppendFormat("{0:X}", 25);
            Console.WriteLine(sb1);

/
    }
}
