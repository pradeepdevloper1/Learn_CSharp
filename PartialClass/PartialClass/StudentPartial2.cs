﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
  public partial  class StudentPartial
    {
        public string getFullName()
        {
            return _firstName + " " + _lastName;

        }
    }
}
