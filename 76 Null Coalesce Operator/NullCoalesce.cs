using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
        string fruit1 = "Apple";
        string fruit2 = "Orange";
        string fruit3 = "Mango";

        string result1 = fruit1??fruit2??fruit3;    

        string result2 = null??fruit2??fruit3;

        string result3 = null??null??fruit3;

        Console.WriteLine($"{fruit1}");    // Apple
        Console.WriteLine($"{fruit2}");    // Orange
        Console.WriteLine($"{fruit3}");
             // Mango
        

        }
    }
}