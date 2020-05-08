using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_projects
{
    //public class => this member(class, field, method)
    // can be accessed by any other code in the same
    //namespace or other namespace (everywhere)
    public class Employee
    {
        //protected method
        //this member can be accessed only by the same
        //code and also by the classes that is derived 
        //from that class
        protected bool EmployeeExistanceCheck()
        {
            int empAge = this.age;
            return true;
        }

        //private
        //It can be accessed only by the code in the
        //same class or struct
        private int age = 18;

        //protected interal property
        //It can be accessed by any code 
        public int Age
        {
            get { return age; }
        }
    }
}
