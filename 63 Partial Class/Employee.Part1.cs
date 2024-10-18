namespace PartialClassDemo
{
    public partial class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
