using session3_projects.model;
using System;


namespace session3_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee employee = new Employee();
            //StringCheck();
            //Console.WriteLine(CompareString("HULK", "JOHN WiCK"));
            //Console.WriteLine(ConcatCheck("Batman", "Joker"));
            //Console.WriteLine(ContainStr("Spiderman.marvel", '.'));
            checkStringMethods();
            //console.read
            //console.write
            Console.WriteLine(Task1("wtrtwttt"));


        }

        private static bool Task1(string str)
        {           
            //bool exists = str.Contains("w"); 
            int count = 0;
            for(int i=0; i< str.Length; i++)
            {
                if (str[i].Equals('w'))
                {
                    count++;
                }
            }
            //if(count > 1 && count < 3){
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return count > 1 && count < 3;
        }

        public static void checkStringMethods()
        {
            string str1 = "superman";
            int index = str1.IndexOf("p");

            string str2 = "my garden has tomatoes";
            str2.Remove(5);
            string d = str2.Remove(5, 8);

            Console.WriteLine(str2.Remove(5, 8));
        }

        public static bool equalsString(string str1, string str2)
        {
            object obj1 = new object();
            object obj2 = new object();
            if (obj1.Equals(obj2))
            {

            }
            if(obj1 == obj2)
            {

            }
            string c = "angelina jolie";
            c.ToUpper();

            return str1.Equals(str2);
        }
        private static bool ContainStr(string str, char ch)
        {
            return str.Contains(".");
        }

        private static string ConcatCheck(string v1, string v2)
        {
            return string.Concat(v1, v2);
        }

        public static void StringCheck()
        {
            string s1 = "test string 1";
            char[] charArray = new char[] { 'a', 'b', 'c' };
            string s2 = new string(charArray);
            Console.WriteLine(s2);

            string s3 = s1 + s2;
            //IEnumerable<char> d = s1.Concat(s2);
            Console.WriteLine(s3);

            int X = 1231554;
            String str = X.ToString();

            Student std1 = new Student(1, "toto");
            Console.WriteLine(std1);
            

        }

        public static string CompareString(string str1, string str2)
        {
            //returns the bigger one
            int result =  str1.CompareTo(str2);
            if (result == 0)
            {
                return "equals";
            }
            if (result < 0)
            {
                return str2;
            }
            else
            {
                return str1;
            }

        }

        public static void checkConditions()
        {
            //Data structure Course
            //Sorting, finding in an array
            //For loops and nested loops
            //While loop => while(boolean experession)

            //while (true)
            //{
            //    //Do something
            //}

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("value of i:{0}", i);

                i++;
            }

            //Console.ReadKey();
            Console.WriteLine("J loop");
            //break
            int j = 0;
            while (true)
            {
                Console.WriteLine("value of j:{0}", j);
                j++;
                if (j > 10)
                    break;
            }

            //Do while
            //do
            //{
            //    //your code
            //} while (true); //your boolean expression

            Console.WriteLine("do while loop");
            int k = 0;
            do
            {
                Console.WriteLine("value of k:{0}", k);

                k++;
            } while (k < 10);

            Random random = new Random();
            int num = random.Next(3);

            switch (num)
            {
                case 1:
                    Console.WriteLine("num = 1");
                    switch (num * 4)
                    {
                        case 4:
                            Console.WriteLine("num = 1");
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("num = 2");
                    break;
                case 3:
                    Console.WriteLine("num = 3");
                    break;
            }
        }
    }
}
