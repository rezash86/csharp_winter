using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session8_winform_projects
{
    class Employee
    {
        public string Id;
        public string FirstName;
        public string LastName;
        public EmploymentType employmentType;

        public Employee(string id, string firstName, string lastName, EmploymentType employmentType)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            this.employmentType = employmentType;
        }

        public override string ToString()
        {
            return $"emplyoee id={this.Id},firstname = {this.FirstName}, lastName={this.LastName}," +
                $"employment_type= {this.employmentType.ToString()}";
        }
    }

    public enum EmploymentType
    {
        FULLTIME= 0 ,
        PARTTIME = 1
    }
}
