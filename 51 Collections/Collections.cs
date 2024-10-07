using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Using List<T>
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");

        Console.WriteLine("Fruits in the list:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit); 
        }

        // Using Dictionary<TKey, TValue>
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(1, "Alice");
        students.Add(2, "Bob");
        students.Add(3, "Charlie");

        Console.WriteLine("\nStudents in the dictionary:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");   
        }
    }
}
