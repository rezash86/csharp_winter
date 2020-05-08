using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_projects.service
{
    class EmployeeService
    {
        public double CalculdatSalary()
        {
            Employee emp = new Employee();
            int emp_age = emp.Age;
            //inaccessible
            //emp.EmployeeExistanceCheck();
            return 0;
        }
    }
}
