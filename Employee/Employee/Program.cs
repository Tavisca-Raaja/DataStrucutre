using System;
using System.Collections.Generic;

namespace Employee
{
    class Program
    {
        static List<EmployeeDetails> arr = new List<EmployeeDetails>();
        static void Main(string[] args)
        {
            Console.WriteLine("Do You Want to Add Employees");
            string choice = Console.ReadLine();
            while(choice!="Exit")
            {
               EmployeeDetails emp = new EmployeeDetails();
                emp.EName = Console.ReadLine();
                emp.
                arr.Add(emp);

            }
           foreach(EmployeeDetails em in arr)
            {
                Console.WriteLine(em.EName);
            }

        }
    }
}
