using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        public string FirstName
        {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }

        public string LastName 
        { 
            get => _lastName; 
            set => _lastName = value;
        }

        public string getFullName()
        {
            return _firstName + " "  +_lastName;

        }

    }
}
