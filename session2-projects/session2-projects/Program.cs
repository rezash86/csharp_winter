using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    class Program: Object
    {
        static void Main2(string[] args)
        {
            Employee employee = new Employee();
            employee.id = 1;
            employee.name = "reza";

            Console.WriteLine(employee);
            Console.WriteLine(employee.ToString());

            //immutability => when you have an object
            string s1 = "test  ";
            Console.WriteLine(s1.Length);
            string s2 = s1.Trim();
            Console.WriteLine(s1.Length);
            Console.WriteLine(s2.Length);

            string url = "http:\\bell.com\\{}\\managment";
            int index = url.IndexOf("com");
            
            //url.Format(url, "10.10.10.10");
            Console.WriteLine(url);

            //concat, substring, findanindex, 
            //Task1();
            //CoursePractices();
        }

        public static void CoursePractices()
        {
            //How we can send input to the console
            Console.WriteLine("Please enter something");
            string input = Console.ReadLine();
            //Console.WriteLine("printing the input =>" + input);

            int x = 1231231;
            //implicit casting
            long lo = x;

            //does the explicit casting
            //Console.WriteLine("Enter a number");
            try
            {
                //Console.WriteLine("Please enter something");
                //string input = Console.ReadLine();
                int integerInput = Int32.Parse(Console.ReadLine());
                Console.WriteLine("printing the integer input =>" + integerInput);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Please enter a number");
            }

            //Data types in C#
            string staringVal = "testvalue";
            int intVar = 100;
            float floatVar = 10.2f;
            char charVar = 'A';
            bool boolVar = true;


            Console.WriteLine("min value of sbyte " + sbyte.MinValue);
            Console.WriteLine("max value of sbyte " + sbyte.MaxValue);
            Console.WriteLine("min value of short " + short.MinValue);
            Console.WriteLine("max value of short " + short.MaxValue);
            Console.WriteLine("min value of byte " + byte.MinValue);
            Console.WriteLine("max value of byte " + byte.MaxValue);
            Console.WriteLine("min value of int " + int.MinValue);
            Console.WriteLine("max value of int " + int.MaxValue);
            Console.WriteLine("min value of uint " + uint.MinValue);
            Console.WriteLine("max value of uint " + uint.MaxValue);
            Console.WriteLine("min value of long " + long.MinValue);
            Console.WriteLine("max value of long " + long.MaxValue);
            Console.WriteLine("min value of ulong " + ulong.MinValue);
            Console.WriteLine("max value of ulong " + ulong.MaxValue);

            uint number = uint.MaxValue - 200;
            uint number2 = number * 1000;
            Console.WriteLine(number2);

            int number3 = int.MaxValue;
            int number4 = number3 * 100;
            Console.WriteLine(number4);

            Console.WriteLine("min value of float " + float.MinValue);
            Console.WriteLine("max value of float " + float.MaxValue);
            Console.WriteLine("min value of double " + double.MinValue);
            Console.WriteLine("max value of double " + double.MaxValue);
            Console.WriteLine("min value of decimal " + decimal.MinValue);
            Console.WriteLine("max value of decimal " + decimal.MaxValue);

            float f1 = 1234.5f;
            float f2 = -123123.444f;

            double d1 = 1234.5d;
            double d2 = -123123.44123131231231d;

            decimal de1 = -54545464.343m;
            decimal de2 = 54545464.342342m;

            //Numbers => Integer Types and Floating point types
            //Integer Types => byte(sbyte), short(ushort), int(uint) ,long(ulong)
            //Floating point types => float, double, decimal(biggest!)

            //unsigned cannot accept negative!
            //ushort number1 = -1231;

            //String
            //series of characters
            string ch = "h";
            string word = "hello";
            string text = "this is a string";

            //string or String => alias
            String str1 = "Chao";
            string str2 = "Chao";

            String.IsNullOrEmpty("toto"); //use Capital if you call a method
            string.IsNullOrWhiteSpace("asdfjnas");

            char[] chars = { 'a', 'b', 'c', 'd' };
            str1 = new string(chars);//string as char Array
            String tempStr = new String(chars);


            //It is represented as a checkbox
            bool flag0 = true;
            bool flag1 = false;

            //char
            char c1 = 'g';
            char c2 = '\u0001';
            char c3 = '\n'; //goes to the next line

            string url = "http:\\google.come\\messages";
            string storeName = "Charlie\'s chocolat";
            Console.WriteLine(storeName);
        }
       

        public static void Task1()
        {
            try
            {
                Console.WriteLine("Please enter the first Number");
                int number1 = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second Number");
                int number2 = Int16.Parse(Console.ReadLine());

                Console.WriteLine("The result of " + 
                                    number1 + " and "
                                    + number2 + " is " + 
                                    (number1 + number2));

                Console.WriteLine("The result of {0} and {1} is {2}",
                    number1, number2, (number1 + number2));

                Console.WriteLine($"The result of  {number1} and {number2} " +
                    $"is {(number1 + number2)}");

            }
            catch (FormatException exc)
            {
                Console.WriteLine("The numbers are not in correct format");
            }
            
           
        }
    }
}
