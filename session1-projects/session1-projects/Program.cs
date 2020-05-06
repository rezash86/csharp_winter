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
        }
    }
}
