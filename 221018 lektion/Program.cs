using System;
using System.Collections.Generic;
using System.Linq;

namespace _221018_lektion
{
    class Program
    {
        static void Main(string[] args)
        {
            // NIKLAS SENDELBACH NET22
            Employee E1 = new Employee() { EmpId = 1, Name = "Niklas", Gender = "M", Salary = 10000 };
            Employee E2 = new Employee() { EmpId = 2, Name = "Frida", Gender = "F", Salary = 20000 };
            Employee E3 = new Employee() { EmpId = 3, Name = "Belle", Gender = "F", Salary = 30000 };
            Employee E4 = new Employee() { EmpId = 4, Name = "Julian", Gender = "M", Salary = 40000 };
            Employee E5 = new Employee() { EmpId = 5, Name = "Tova", Gender = "F", Salary = 50000 };
            
            Stack<Employee> EmpStack = new Stack<Employee>();
            EmpStack.Push(E1);
            EmpStack.Push(E2);
            EmpStack.Push(E3);
            EmpStack.Push(E4);
            EmpStack.Push(E5);
         
            foreach (Employee item in EmpStack)
            {
                item.PrintInfo();
                Console.WriteLine("Items left in the Stack: " + EmpStack.Count);
            }
            Console.WriteLine("----------------------------------------------------------------------");

            Employee EP1 = EmpStack.Pop();
            E1.PrintInfo();
            Console.WriteLine("Items left in the stack: " + EmpStack.Count);
            Employee EP2 = EmpStack.Pop();
            E2.PrintInfo();
            Console.WriteLine("Items left in the stack: " + EmpStack.Count);
            Employee EP3 = EmpStack.Pop();
            E3.PrintInfo();
            Console.WriteLine("Items left in the stack: " + EmpStack.Count);
            Employee EP4 = EmpStack.Pop();
            E4.PrintInfo();
            Console.WriteLine("Items left in the stack: " + EmpStack.Count);
            Employee EP5 = EmpStack.Pop();
            E5.PrintInfo();
            Console.WriteLine("Items left in the stack: " + EmpStack.Count);

            Console.WriteLine("----------------------------------------------------------------------");

            EmpStack.Push(E1);
            EmpStack.Push(E2);
            EmpStack.Push(E3);
            EmpStack.Push(E4);
            EmpStack.Push(E5);

            Employee EPE1 = EmpStack.Peek();
            EPE1.PrintInfo();
            Console.WriteLine("Items left in the stack: " + EmpStack.Count);
            Employee EPE2 = EmpStack.Peek();
            EPE2.PrintInfo();
            Console.WriteLine("Items left in the stack: " + EmpStack.Count);
            Console.WriteLine("----------------------------------------------------------------------");

            if (EmpStack.Contains(E3))
            {
                Console.WriteLine("E3 is in stack");
            }
            else
            {
                Console.WriteLine("E3 is not in stack");
            }
            Console.WriteLine("----------------------------------------------------------------------");
            
            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(E1);
            EmpList.Add(E2);
            EmpList.Add(E3);
            EmpList.Add(E4);
            EmpList.Add(E5);

            if (EmpList.Contains(E2))
            {
                Console.WriteLine("Employee 2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee 2 object does not exist in the list");
            }
            Console.WriteLine("----------------------------------------------------------------------");

            Employee gender = EmpList.Find(g => g.Gender == "M");
            gender.PrintInfo();
            Console.WriteLine("----------------------------------------------------------------------");

            List<Employee> allMale = EmpList.FindAll(g => g.Gender == "M");
            foreach (Employee item in allMale)
            {
                item.PrintInfo();
            }
        }
    }
}
