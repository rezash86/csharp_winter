using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_projects.model
{
    class Student
    {
        private int id;
        private string name;
       
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int ID
        {
            get { return id; }
            //set { id = value; }
        }

        public override string ToString()
        {
            return $"id = {id} and name = {name}";
        }
    }
}
