using System;

namespace STATIC_PROPERTY
{
    class university
    {
        private static string UniversityName;
        private static string DepartmentName;

        public static string _UniversityName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("University name cannot be null or empty");
                }
                else
                {
                    UniversityName = value;
                }
            }
            get
            {
                return UniversityName;
            }
        }

        public static string _DepartmentName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Department name cannot be null or empty");
                }
                else
                {
                    DepartmentName = value;
                }
            }
            get
            {
                return DepartmentName;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            university._UniversityName = "AKGEC";
            university._DepartmentName = "Accountant";
            Console.WriteLine(university._UniversityName);
            Console.WriteLine(university._DepartmentName);
        }
    }
}
