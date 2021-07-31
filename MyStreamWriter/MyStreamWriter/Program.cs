using System;
using System.IO;
using System.Text;

namespace MyStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
           // string path = @"D:\Pradeep_WFX\myStreamWriter2.txt";
            //using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            //{
            //    using (StreamWriter writer = new StreamWriter(file,Encoding.UTF8))
            //    {
            //        writer.WriteLine("Statement No. 3");
            //        writer.WriteLine("Statement No. 4");
            //        writer.WriteLine("Statement No. 5");
            //    }
            //}
            //    using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            //    {
            //        using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))
            //        {
            //            int[] arr1 = { 11, 22, 33, 44, 55, 66, 77 };
            //            foreach (var item in arr1)
            //            {
            //                writer.Write(item + " ");
            //            }

            //            char[] arr2 = { 'A', 'B', 'C', 'D', 'E', 'F' };
            //            foreach (var item in arr2)
            //            {
            //                writer.Write(item + " ");
            //            }
            //        }
            //    }

            string path = @"D:\Pradeep_WFX\myStreamReader3.txt";
            using (FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    //string line = reader.ReadLine();
                    //Console.WriteLine(line);


                    //string line = "";
                    //while ((line = reader.ReadLine()) != null)
                    //{
                    //    Console.WriteLine(line);
                    //}

                    //foreach (var item in reader.ReadLine())
                    //{
                    //    Console.WriteLine(item);
                    //}


                    //string[] names = new string[5];
                    //for (int i = 0; i < names.Length; i++)
                    //{
                    //    names[i] = reader.ReadLine();
                    //}

                    //foreach (var name in names)
                    //{
                    //    Console.WriteLine(name);
                    //}


                    //string data = reader.ReadToEnd();
                    //Console.WriteLine(data);


                    if (reader.Peek()>0)
                    {
                        Console.WriteLine("true");
                    }

                    else
                    {
                        Console.WriteLine("false");
                    }


                }
                
            }

        }
    }
}
