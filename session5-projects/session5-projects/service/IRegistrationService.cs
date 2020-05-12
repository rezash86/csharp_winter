using session5_projects.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5_projects.service
{
    interface IRegistrationService
    {
        void RegisterEmployee(Employee employee);

        Employee GetEmployee(string firstName);
    }
}
