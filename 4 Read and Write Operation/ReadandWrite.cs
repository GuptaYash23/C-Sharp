using System;

namespace ReadandWriteProgram
{
    class ReadandWrite
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");       // Enter your first name:
            string fname = Console.ReadLine();
            
            Console.WriteLine("Enter your last name: ");       // Enter your last name: 
            string lname = Console.ReadLine();

            // Using Concatenation
            Console.WriteLine("Hi " + fname + " " + lname + " !");   // Hi fname lname !

            // Using Placeholder 
            Console.WriteLine("Hi {0} {1} !", fname, lname);   // Hi fname lname !

            Console.WriteLine("What's your age ?");       // What's your age ?

            // Type casting string to int
            // int age = Convert.ToInt32(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("You are {0} years old",age);  // You are 22 years old
        }
    }

}

// To comment a highlighted code use Ctrl + K and then Ctrl + C
// To uncomment a highlighted comment use Ctrl + K and then Ctrl + U