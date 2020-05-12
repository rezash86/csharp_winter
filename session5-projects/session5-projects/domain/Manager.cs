using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5_projects.domain
{
    class Manager : Employee
    {
        public int countOfSupervision;
        public Manager(string firstName, 
                       string lastName, 
                       string tel,
                       int count) : base(firstName, lastName, tel)
        {
            this.countOfSupervision = count;

        }
    }
}
