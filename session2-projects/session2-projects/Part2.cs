using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    class Part2
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter Number 1");
            //int number1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number 2");
            //int number2 = Int32.Parse(Console.ReadLine());
            //SwapNumbers(number1, number2);
            //checkIfStatements();
            //CheckLoopStatements();
            Console.WriteLine("Enter Number of your rows in the pyramid");
            int count = Int32.Parse(Console.ReadLine());
            Task1(count);
            Task2(count);
            Operator2();

        }

        public static void Operator2()
        {
            Console.WriteLine($"sizeof(int) is {sizeof(int)}");
            Console.WriteLine($"typeof(StreamReader) is {typeof(Employee)}");

            int i = 10;
            //Ternary operator
            bool result = i < 20 ? true: false;

            //is
            Employee employee = new Employee();
            
            if(employee is Employee)
            {
                Console.WriteLine("this is an employee");
            }

            //as
            Object obj = new StreamReader("obj");

            //They can throw exception if the obj is not a real
            //StreamReader==> this is not safe casting
            StreamReader streamReader1 = obj as StreamReader;
            StreamReader streamReader2 = (StreamReader)obj;

            //This casting is safe !!!
            if(obj is StreamReader)
            {
                StreamReader streamReader3 = (StreamReader)obj;
            }

        }

        public static void Operator()
        {
            //&& => means both conditions need to be TRUE
            int a = 25;
            if(a > 10 && a < 60)
            {
                //Do something
            }

            //OR operator means Either one of them or both of them
            //needs to be TRUE
            if (a < 10 || a < 60)
            {
                //Do something
                //A && B => A==FALSE and B==True =>> FALSE
                //A || B => A==FALSE || B==True  =>> TRUE
                // !A => A==True ==> !A is False
                //!(A || B) => A==True and B==False =>> !A && !B => FALSE
            }




            //! Not opertor
            //!(a < 10) && !(a < 60)
            if ( !(a < 10 || a < 60) ){
                
            }
        }

        //using Alt + enter
        private static void Task2(int rowNumber)
        {
            for (int i=rowNumber; i> 0; i--)
            {
                for(int k=0; k<i; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public static void CheckLoopStatements()
        {
            //Loop => For, While, DO-While

            for (int index = 1; index <= 10; index = index+2)
            {
                Console.WriteLine(index);
                //Do your actions
            }
            Console.WriteLine("----------------------");
            for (double d=1.01d; d< 1.10; d+= 0.01d)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("----------------------");
            for (int index = 10; index >= 1; index--)
            {
                Console.WriteLine(index);
                //Do your actions
            }
            Console.WriteLine("----------------------");
            //break!
            for(int i=0;i<10; i++)
            {
                if (i == 6)
                    break;

                Console.WriteLine(i);
            }
            //Nested FOR LOOP
            for (int j=0; j< 5; j++)
            {
                for (int k=0; k<3; k++)
                {
                    Console.WriteLine($"the value of j={j} and the" +
                        $" value of k= {k} ");
                }
            }
            



            //While
        }
        public static void SwapNumbers(int number1, int number2)
        {
            //it will swap the numbers and print them
            //Console.WriteLine("Number 1 => {0}", number1);
            //fancy way!
            Console.WriteLine($"Number 1 {number1}");
            Console.WriteLine("Number 2 => {0}", number2);

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("Afte swap");

            Console.WriteLine("Number 1 => {0}", number1);
            Console.WriteLine("Number 2 => {0}", number2);

        }

        public static void checkIfStatements()
        {
            int x = 12;
            int y = x++;//x + 1


            //x => 2
            x = 12 % 5;


            //Conditionals => if
            if (true)
            {
                //this always happens
            }
            int i = 10, j = 20;
            if (i < j)
            {
                Console.WriteLine("i is smaller than j");
            }
            else if (i > j)
            {
                Console.WriteLine("i is bigger than j");
            }
            //if (i==j)
            //we can have only one else statemen
            //after the if-else statement
            else
            {
                if (j == 5)
                {
                    if (i == 9)
                    {

                    }
                }
                Console.WriteLine("i is equal to j");
            }
            
        }

        public static void Task1(int rowNumber)
        {
            for (int i=0; i<= rowNumber; i++)
            {
                for (int j=0; j<i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
