using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    public class TestClass //public => Access Modifier
    {
        public string myField = string.Empty; //field

        //Default Constructor
        public TestClass()
        {

        }

        //parametrized constructor
        public TestClass(int param)
        {
            myPropertVar = param;
        }

        //Ctrl + K and then Ctrl + C => to comment
        //Ctrl + K and then Ctrl + U => to uncomment
        public void DoSomething() //Method\function
        {
            Console.WriteLine("first program");
        }

        public void DoSomethingWithParameter(int param1, int param2) //Method\function
        {
            Console.WriteLine("first parameter {0} , second parameter {1}", param1, param2);
        }

        public int MyPropertyAutoImplemented { get; set; } //Auto-implemented property
                                                           //For creating by short key can type "prop" and then double 
                                                           //Tab

        //Encapsulation => property
        private int myPropertVar;

        public int MyProperty
        {
            get { return myPropertVar; }
            set { myPropertVar = value; }
        }
    }

}
