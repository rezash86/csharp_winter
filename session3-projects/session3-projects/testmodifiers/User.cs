using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_projects.testmodifiers
{
    //public class
    class User
    {
        public string Name;
        public string Location;

        public void GetUserDetails()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Location {Location}");
        }
    }

    //private members
    class User2
    {
        private string Name;
        private string Location;
        public void GetUserDetails()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Location {Location}");
        }

        private void ChangeAttributes()
        {
            Name = Name + "----";
        }
    }

    //protected members
    class User3
    {
        protected string Name;
        protected string Location;
        protected void GetUserDetails()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Location {Location}");
        }
    }
    class Program : User3
    {
        static void Main2(string[] args)
        {
            User user = new User();
            user.Name = "Reza";
            user.Location = "Montreal";
            user.GetUserDetails();

            User2 user2 = new User2();
            //Compile Error => private
            //user2.Name = "Reza";
            //user2.Location = "Montreal";
            //user2.GetUserDetails();


            User3 user3 = new User3();
            //Compile Error => protected
            //user3.Name = "Reza";
            //user3.Location = "Montreal";
            //user3.GetUserDetails();


            Program p = new Program();
            p.Name = "Brad";
            p.Location = "Los Angles";
            p.GetUserDetails();

            // Internal
            // Protected Internal           
            // private protected
        }
    }

}
