using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string Designation { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, string designation, decimal salary)
    {
        Name = name;
        Designation = designation;
        Salary = salary;
    }

    // Override ToString() for better printing employee object
    public override string ToString()
    {
        return $"Name: {Name}, Designation: {Designation}, Salary: {Salary}";
    }
}

class Program
{
    static void Main()
    {
        // Create a list of Employee objects
        List<Employee> employees = new List<Employee>();

        // Adding employees to the list
        employees.Add(new Employee("John Doe", "Manager", 75000m));
        employees.Add(new Employee("Jane Smith", "Developer", 55000m));
        employees.Add(new Employee("Emma Brown", "Designer", 50000m));

        // Print original list
        Console.WriteLine("Original List:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }

        // Removing an employee
        employees.Remove(employees[1]); // Removes Jane Smith (Developer)
        Console.WriteLine("\nAfter Removing Jane Smith:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }

        // Sorting by Salary (ascending)
        employees.Sort((e1, e2) => e1.Salary.CompareTo(e2.Salary));
        Console.WriteLine("\nAfter Sorting by Salary:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }

        // Reversing the list
        employees.Reverse();
        Console.WriteLine("\nAfter Reversing the List:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }

        // Checking if an employee exists
        var newEmployee = new Employee("John Doe", "Manager", 75000m);
        bool containsEmployee = employees.Contains(newEmployee);
        Console.WriteLine($"\nContains John Doe? {containsEmployee}");

        // Employee search using a custom condition (finding by name)
        containsEmployee = employees.Exists(e => e.Name == "John Doe");
        Console.WriteLine($"Contains Employee named John Doe? {containsEmployee}");

        // Count of employees in the list
        Console.WriteLine($"\nNumber of employees in the list: {employees.Count}");
    }
}