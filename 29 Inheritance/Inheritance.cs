using System;

namespace ConsoleApp
{

    // Base Class
    public class Employees
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public string EmpContactNo;

        public void show()
        {
            Console.WriteLine("Base Class Function called ");

        }
    }

    // Derived Class
    public class VisitingEmployees : Employees
    {
        public int visitingSalary;
        public int visitingHours;
    }

    // Derived Class

    public class PermanentEmployees : Employees
    {
        public int PermanentSalary;
        public int PermanentHours;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            PermanentEmployees Yash = new PermanentEmployees();
            
            Yash.EmpName = "Yash";
            Yash.EmpId = 2301;
            Yash.EmpAge = 22;
            Yash.EmpContactNo = "011 25532553";  // C# can't have leading 0's
            Console.WriteLine($"Yash's name: {Yash.EmpName},\nYash's ID: {Yash.EmpId},\nYash's Age: {Yash.EmpAge},\nYash's Contact No: {Yash.EmpContactNo}");

            Yash.show();

            VisitingEmployees Syed = new VisitingEmployees();

            Syed.EmpId = 10;
            Syed.show();

        }
    }
}