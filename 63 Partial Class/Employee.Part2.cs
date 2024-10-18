namespace PartialClassDemo
{
    public partial class Employee
    {
        public string Designation { get; set; }
        public decimal Salary { get; set; }

        public void PrintSalaryDetails()
        {
            Console.WriteLine($"Designation: {Designation}, Salary: {Salary}");
        }
    }
}
