    using System;
using System.IO;
using System.Text;

namespace FileStream_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Pradeep_WFX\myFileStream.txt";
            using (FileStream file = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
            {
                file.WriteByte(65); //A
                file.WriteByte(66); //B
                file.WriteByte(67); //C
                file.WriteByte(68); //D
                Console.WriteLine("File Created");
            }

            FileStream file = new FileStream(path, FileMode.Create);
            Console.WriteLine("File Created");
            file.Close();
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                file.WriteByte(65); //A
                Console.WriteLine("File Created");
            }

            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                file.WriteByte(65); //A
                file.WriteByte(66); //B
                file.WriteByte(67); //C
                file.WriteByte(68); //D
                Console.WriteLine("File Created");
            }
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Write))
            {
                file.WriteByte(65); //A
                file.WriteByte(66); //B
                file.WriteByte(67); //C
                file.WriteByte(68); //D
                Console.WriteLine("File Created");
            }
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                file.WriteByte(68); //D

                Console.WriteLine("File Created");
            }
            using (FileStream file = new FileStream(path, FileMode.Truncate, FileAccess.Write))
            {

                Console.WriteLine("File Truncate Successfully");
            }


            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                string Data = "My Name is Pradeep";
                byte[] write_data = Encoding.UTF8.GetBytes(Data);
                file.Write(write_data, 0, Data.Length);

                Console.WriteLine("Data written Successfully");
            }



        }
    }
}
