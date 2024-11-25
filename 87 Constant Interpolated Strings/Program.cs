using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string app = "Visual Studio Code";
            const string str = $"I am using {app}";

            string name = "Yash";
            string language = "C#";
            string tech = ".NET";
            Console.WriteLine("Hi, my name is {0}",name); // Placeholders
            Console.WriteLine("I am learning "+language); // Concatenation 
            Console.WriteLine($"I will be learning {tech}"); // Interpolation Syntax
            Console.WriteLine(str); // Const string interpolation
        }
    }
}