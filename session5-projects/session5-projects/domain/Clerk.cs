using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5_projects.domain
{
    class Clerk : Employee
    {
        public int clerkNum;
        public Clerk(string firstName,
                      string lastName,
                      string tel,
                      int clerkNum) : base(firstName, lastName, tel)
        {
            this.clerkNum = clerkNum;

        }
    }
}
