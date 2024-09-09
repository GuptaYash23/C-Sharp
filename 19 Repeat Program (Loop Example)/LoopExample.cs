using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Repeating the addition program using do while loop
            string confirm;

            do
            {
                Console.WriteLine("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int add = num1 + num2;
                Console.WriteLine("Addition result: " + add);

                Console.WriteLine("Do you want to repeat the program? Yes/No");
                confirm = Console.ReadLine().ToLower();

            } while (confirm == "yes");

            // Repeating the program using while loop

            // while (true)
            // {
            //     Console.WriteLine("Enter first number: ");
            //     int num1 = int.Parse(Console.ReadLine());

            //     Console.WriteLine("Enter second number: ");
            //     int num2 = int.Parse(Console.ReadLine());

            //     int add = num1 + num2;
            //     Console.WriteLine("Addition result: " + add);

            //     Console.WriteLine("Do you want to repeat the program? Yes/No");
            //     string confirm = Console.ReadLine().ToLower();

            //     if (confirm == "yes")
            //     {
            //         continue;  // Will restart the exectution of the program 
            //     }
            //     else
            //     {
            //         break;
            //     }
            // }
        }
    }
}
