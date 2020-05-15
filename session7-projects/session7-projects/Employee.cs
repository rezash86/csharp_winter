using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session7_projects
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Employee(int iD, string name, string city)
        {
            this.ID = iD;
            this.Name = name;
            this.City = city;
        }

        public override string ToString()
        {
            return $"ID= {this.ID} and name={this.Name} and city={this.City}";
            
        }
    }
}
