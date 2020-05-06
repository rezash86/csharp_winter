using System;


namespace session1_projects //Namespace is the same as package
{
    class Program  //class name
    {
        static void Main(string[] args) //Method name
        {
            //Write my c# Code !!!!
            //System.out.printLn("some thing")
            //CTRL + F5 => run without debug
            //F5 => runs with debug
            Console.WriteLine("this is the first project");
            Console.WriteLine("this is the first project- second line");

            //IntelliSense => to do the auto complete
            //MVC and spring

            //For calling another method in another class
            TestClass testClass = new TestClass();
            testClass.DoSomething();

            //C# Keywords
            // Modifier Keywords => abstract , new, sealed , partial
            // Access Modifier keywords => public, private, internal, protected
            // statement keywords => if else switch case do for while foreach try catch finally return
            // Methods parametr keywords => ref out
            // namespace keywords => using 
            // Type keywords => bool, byte, char, decimal, class, enum, float, long

            string message = "My first app";

            Console.WriteLine(message);

            //you can have access to both public classes
            SalaryCalculate salaryCalculate = new SalaryCalculate();
            salaryCalculate.Calc();


            Student student1 = new Student(1, "TOTO", "A");
            Student student2 = new Student(2, "POPO", "B");

            float a = 10f / 3;
            Console.WriteLine(a);
            double b = 10d / 3;
            Console.WriteLine(b);
            decimal c = 10m / 3;
            Console.WriteLine(c);


            Test test = new Test();
            test.testEnum();


            //call by value and call by reference

            //calling by value does not change the original after return

            Console.WriteLine("-----------------Call by value -------------");
            int x = 100;
            Console.WriteLine("before calling the method the value of x {0}", x);
            ChangeValue(x);
            Console.WriteLine("after calling the method the value of x {0}", x);

            //Call by reference
            Console.WriteLine("call by reference");
            x = 100;//imagine the address of x is 0x60000
            Console.WriteLine("before calling the method the value of x {0}", x);
            ChangeValueByRef(ref x);//I will pass &0x60000 => it means the address of x
            Console.WriteLine("after calling the method the value of x {0}", x);



            //Classes are using call by reference
            Stud std1 = new Stud();
            std1.name = "John";
            ChangeName(std1);//I passed the reference
            Console.WriteLine(std1.name);

            //casting
            double doubleNumber = 123.7;
            int intNumber;

            int g = 123456;
            //implicit casting
            long l = g;
            //explicit casting
            intNumber = (int)doubleNumber;
            Console.WriteLine(intNumber);

            //Casting of classes
            Monkey monkey = new Monkey();
            
            //Implicit conversion to base type is safe!
            Animal animal = monkey;
            
            //animal.sound() is not acceptable

            // Explicit Conversion is required to
            // cast back to the derived type            
            Monkey monkey2 = (Monkey)animal;

            Elephant elephant = new Elephant();
            Animal animal2 = elephant;
            //I don't have any compile time error
            //this casting can throw exception
            //at run-time if the right side
            //is not a monkey in fact!!!
            //this code will be throws invalid cast exception
            //Monkey monkey3 = (Monkey)animal2;




            //this code is safe because it does type checking
            if (animal2 is Monkey)
            {
                Monkey monkey3 = (Monkey)animal2;
            }
            else if (animal2 is Elephant)
            {
                Elephant elephant2 = (Elephant)animal2;
            }



        }

        static void ChangeName(Stud c)
        {
            //It will change the original data
            c.name = "Bill";
        }

        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine("in the method the value of x {0}", x);
        }

        static void ChangeValueByRef(ref int x)
        {
            x = 200;
            Console.WriteLine("in the method the value of x {0}", x);
        }
    }

    class Stud
    {
        public string name;
    }
}
