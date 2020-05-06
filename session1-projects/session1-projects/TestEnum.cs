using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    enum WeekDays
    {
        MONDAY = 1,
        TUESDAY = 2,
        WEDNESDAY = 3,
        THURSDAY
    }

    enum Gender
    {
        MALE = 0,
        FEMALE = 1
    }

    class Test
    {
       int data_member = 0;

        public Test()
        {

        }
       public void testEnum()
        {
            int start_day = 0;
            
            if(start_day == (int)WeekDays.WEDNESDAY)
            {

            }
            Console.WriteLine(WeekDays.MONDAY);
        }

    }

    interface ITest
    {
        void testInterfaceMethod();
    }

    delegate int myDelegate();
}
