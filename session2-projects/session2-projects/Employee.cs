using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    class Employee
    {
        public int id;
        public string name;

        public override string ToString()
        {
            string s = "the name is " + name + " and id =" + id;
            //return s;
            return ($"id is {0} and name is {1}");
        }
    }
}
