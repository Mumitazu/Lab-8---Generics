using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8___Generics
{
    public class Employee
    {   //Accessable proprties.
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return $" {EmpID} - {Name} - {Gender} - {Salary}";
        }

    }

 
}
