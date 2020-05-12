using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5_projects.domain
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public string tel;
        

        public Employee(string firstName, string lastName, string tel)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.tel = tel;
        }
    }
}
