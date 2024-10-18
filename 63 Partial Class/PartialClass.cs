using System;

namespace PartialClassDemo
{
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee
            {
                Name = "John Doe",
                Age = 30,
                Designation = "Software Developer",
                Salary = 60000
            };

            emp.PrintEmployeeDetails();  // Calls method from Part1
            emp.PrintSalaryDetails();    // Calls method from Part2
        }
    }
}
