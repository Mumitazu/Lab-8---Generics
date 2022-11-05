using System;
using System.Collections.Generic;

namespace Lab_8___Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            //Objecs
            Employee M1 = new Employee() { EmpID = 111, Name = "Miraya", Gender = "Female", Salary = 11000 };
            Employee M2 = new Employee() { EmpID = 222, Name = "Malik", Gender = "Male", Salary = 12000 };
            Employee M3 = new Employee() { EmpID = 333, Name = "Maida", Gender = "Female", Salary = 13000 };
            Employee M4 = new Employee() { EmpID = 444, Name = "Mikael", Gender = "Male", Salary = 14000 };
            Employee M5 = new Employee() { EmpID = 555, Name = "Mona", Gender = "Female", Salary = 15000 };

            //Adding elements to the stack.
            Console.WriteLine("\nRetreiving stack using foreach");
            Console.WriteLine("'''''''''''''''''''''''''''");
            Stack<Employee> EmployeeStack = new Stack<Employee>();
            EmployeeStack.Push(M1);
            EmployeeStack.Push(M2);
            EmployeeStack.Push(M3);
            EmployeeStack.Push(M4);
            EmployeeStack.Push(M5);

            //Prints elements in stack and counts them after every printed element.
            foreach (var items in EmployeeStack)
            {
                Console.WriteLine(items.ToString());
                Console.WriteLine("Items Kvar i stacken: " + EmployeeStack.Count);
            }
            Console.WriteLine("\nRetreiving using pop method");
            Console.WriteLine("'''''''''''''''''''''''''''");

            //Removing elements from the satck by pop-method and counting them after every removal.
            Employee Emp1 = EmployeeStack.Pop();
            Console.WriteLine(Emp1.EmpID + "-" + Emp1.Name + "-" + Emp1.Gender + "-" + Emp1.Salary);
            Console.WriteLine("Items Kvar i stacken: " + EmployeeStack.Count);

            Employee Emp2 = EmployeeStack.Pop();
            Console.WriteLine(Emp2.EmpID + "-" + Emp2.Name + "-" + Emp2.Gender + "-" + Emp2.Salary);
            Console.WriteLine("Items Kvar i stacken: " + EmployeeStack.Count);

            Employee Emp3 = EmployeeStack.Pop();
            Console.WriteLine(Emp3.EmpID + "-" + Emp3.Name + "-" + Emp3.Gender + "-" + Emp3.Salary);
            Console.WriteLine("Items Kvar i stacken: " + EmployeeStack.Count);

            Employee Emp4 = EmployeeStack.Pop();
            Console.WriteLine(Emp4.EmpID + "-" + Emp4.Name + "-" + Emp4.Gender + "-" + Emp4.Salary);
            Console.WriteLine("Items Kvar i stacken: " + EmployeeStack.Count);

            Employee Emp5 = EmployeeStack.Pop();
            Console.WriteLine(Emp5.EmpID + "-" + Emp5.Name + "-" + Emp5.Gender + "-" + Emp5.Salary);
            Console.WriteLine("Items Kvar i stacken: " + EmployeeStack.Count);

            //Re-adding elements to the stack through PUSH again.
            EmployeeStack.Push(M1);
            EmployeeStack.Push(M2);
            EmployeeStack.Push(M3);
            EmployeeStack.Push(M4);
            EmployeeStack.Push(M5);

            Console.WriteLine("\nRetreiving using peek method");
            Console.WriteLine("'''''''''''''''''''''''''''");

            //Printing 2 elements from the stack through PEEk and counting remaining elements.
            Employee PE1 = EmployeeStack.Peek();
            Console.WriteLine($" {PE1.EmpID} - {PE1.Name} - {PE1.Gender} - {PE1.Salary}");
            Console.WriteLine("Items i stacken: " + EmployeeStack.Count);

            Employee PE2 = EmployeeStack.Peek();
            Console.WriteLine($" {PE2.EmpID} - {PE2.Name} - {PE2.Gender} - {PE2.Salary}");
            Console.WriteLine("Items i stacken: " + EmployeeStack.Count);

            Console.WriteLine("\nFinding Element from the stack");
            Console.WriteLine("'''''''''''''''''''''''''''");

            //Checking if EMP3 exists in the stack items.
            if (EmployeeStack.Contains(Emp3))
            {
                Console.WriteLine("Emp3 finns i Stacken.");
            }
            else
            {
                Console.WriteLine("Emp3 finns INTE i Stacken.");
            }

            Console.WriteLine("\nList");
            Console.WriteLine("'''''''''''''''''''''''''''");
            //Creating List-method and adding employee elements.
            List<Employee> EmpList = new List<Employee>();

            EmpList.Add(M1);
            EmpList.Add(M2);
            EmpList.Add(M3);
            EmpList.Add(M4);
            EmpList.Add(M5);

            //Checking if the list contains an element by the name M3.
            if (EmpList.Contains(M3))
            {
                Console.WriteLine(" M3 finns i listan.");
            }
            else
            {
                Console.WriteLine("M3 finns INTE i listan.");
            }

            //Find-method that prints the first male of the list.
            Employee FirstMale = EmpList.Find(x=>x.Gender=="Male");
            Console.WriteLine($"\n{FirstMale}\n");

            //FindAll-method that prints all the male of the list with foreach.
            List<Employee>MaleEmployees = EmpList.FindAll(e => e.Gender == "Male");
           
            foreach (var employee in MaleEmployees)
            {
                Console.WriteLine($" {employee.EmpID} -{employee.Name} -{employee.Gender} -{employee.Salary}");
            }
            
            Console.ReadKey();
        }


    }
}    
       
