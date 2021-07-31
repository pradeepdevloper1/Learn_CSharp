using System;

namespace PROPERTIES
{
    class Student
    {
        private int _StdID;
        private string _Name;
        private string _FName;
        //readonly property
        private int _SubjectTotalMarks = 899;

        public int StdID
        {
            set {
                if (value<=0)
                {
                    Console.WriteLine("StdID cannot be negative or Zero");

                }
                else
                {
                    this._StdID = value;
                }
            }
            get { return this._StdID; }

        }
        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value)==true)
                {
                    Console.WriteLine("Name cannot be Blank");

                }
                else
                {
                    this._Name = value;
                }
            }
            get { return this._Name; }

        }
        public string FName
        {
            set
            {
                if (String.IsNullOrEmpty(value) == true)
                {
                    Console.WriteLine("FName cannot be Blank");

                }
                else
                {
                    this._FName = value;
                }
            }
            get { return this._FName; }

        }
        public int SubjectTotalMarks
        {
            get
            {
                return this._SubjectTotalMarks;
            }
        }
    }

    class Student2 {
        public int ID { get; set; }
        public string Name { get; private set; }
        public string FName{ get; private set; }

        public Student2(string name,string fname) {
            Name = name;
            FName = fname;
        }
    }
    class Program
    {
      

        static void Main(string[] args)
        {


            //Student s = new Student();
            //s.StdID = 111;
            //s.Name = "Pradeep";
            //s.FName = "roosh lal";
            //Console.WriteLine(s.StdID);
            //Console.WriteLine(s.Name);
            //Console.WriteLine(s.FName);
            //Console.WriteLine(s.SubjectTotalMarks);
            //Console.ReadLine();


            Student2 s2 = new Student2("Anuj", "Rakesh");

            Console.WriteLine(s2.Name);
            Console.WriteLine(s2.FName);
            
            Console.ReadLine();
        }
    }
}
