using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Student
    {
        /// <summary>
        /// The student's legal first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The student's legal last name
        /// </summary>
        public string LastName { get; set; }


        public string ToString()
        {
            return LastName + ", " + FirstName;
        }
    }
}
