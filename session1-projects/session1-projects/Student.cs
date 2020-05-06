using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    struct Student
    {
        public int StdId;
        public string FirstName;
        public string LastName;

        //Struct cannot have defualt[no parameterized] constructor
        public Student(int stdId, string fname, string lname)
        {
            StdId = stdId;
            FirstName = fname;
            LastName = lname;
        }

        static Student()
        {
            Console.WriteLine("First Object Created");
        }
    
    }
}
