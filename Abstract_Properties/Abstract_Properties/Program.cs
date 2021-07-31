using System;

namespace Abstract_Properties
{
    abstract class person
    {
        public abstract int  ID{ get; set; }
        public abstract string Name { get; set; }
    }
    class student : person
    {
        private int studentID;
        private string studentName;
        public override int ID
        {
            set => this.studentID = value;
            get { return this.studentID; } 
            
        }
        public override string Name
        {
            set => this.studentName = value;
            get { return this.studentName; }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student st = new student();
            st.ID = 1001;
            st.Name = "Pradeep Kumar";
            Console.WriteLine(st.ID);
            Console.WriteLine(st.Name);
        }
    }
}
