using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_projects.model
{
    class Manager : Employee
    {
        public void CalculateSalary()
        {
            bool exists = EmployeeExistanceCheck();
        }
    }
}
