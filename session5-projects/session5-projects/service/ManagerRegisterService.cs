using session5_projects.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5_projects.service
{
    class ManagerRegisterService : IRegistrationService
    {
        public Employee GetEmployee(string firstName)
        {
            //I need to look into the Managers and send back and employee
            //by first name
            return null;
        }

        public void RegisterEmployee(Employee employee)
        {
            Manager m = employee as Manager;

            //it can have different implementation
        }
    }
}
