using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Create a list of employees
            var employees = new List<Employee>();
            employees.Add(new Employee("Eric", "Lavesson", "821202-1234", 0));
            employees.Add(new Employee("ABC", "123", "12345834-1223", 1 ));

            foreach (var employee in employees)
            {
                Console.WriteLine("Name: {0} {1}"
                    , employee.FirstName, employee.LastName);
            }
        }
    }
}