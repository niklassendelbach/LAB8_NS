using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _221018_lektion
{
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public  void PrintInfo() // method just to make it clean inside main
        {
            Console.WriteLine($"Employee ID: {EmpId} \nName: {Name} \nGender: {Gender} \nSalary: {Salary}"); 
        }
    }
}
