using System;
using System.IO;


namespace FilHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Pradeep_WFX\csharp_notes2.docx";
            string path2= @"D:\Pradeep_WFX\csharp_notes3.docx";

            if (File.Exists(path) == true)
            {

                Console.WriteLine("Yes , There is a File");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
                File.Copy(path, path2);
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
        }
    }
}
