using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session8_winform_projects
{
    class Employee2
    {
        public string Id;
        public string FirstName;
        public string LastName;


        public Employee2(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"emplyoee id={this.Id},firstname = {this.FirstName}, lastName={this.LastName}";


        }
    }

    
}
