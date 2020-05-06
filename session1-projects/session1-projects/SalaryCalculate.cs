using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    public class SalaryCalculate
    {
        public void Calc()
        {
            Employee e = new Employee("reza");

            int x;

            //Checked => it will have compile time error
            //Unchecked => no compile time error but runtime wrong result
            int tempNum = 25000;
            //Some functions
            unchecked
            {
                x = tempNum + 100;
            }

            int y = unchecked(int.MaxValue + 100);

            try
            {

            }
            //Checked
            catch (Exception exc)
            {
                //x = 2147483647 + 100;
            }


            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }

    public class Employee
    {
        string name;
        public Employee(string name)
        {
            this.name = name;
        }
    }
}
