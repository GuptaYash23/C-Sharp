using System;

namespace Generic_Class
{
    public class Pair<T1, T2>    // T1, T2 are type parameters/placeholders
{
    public T1 First { get; set; }
    public T2 Second { get; set; }

    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }
}

// Usage
class Program
{
    static void Main()
    {
        var intStringPair = new Pair<int, string>(1, "One");
        Console.WriteLine($"First: {intStringPair.First}, Second: {intStringPair.Second}");

        var doubleBoolPair = new Pair<double, bool>(3.14, true);
        Console.WriteLine($"First: {doubleBoolPair.First}, Second: {doubleBoolPair.Second}");
    }
}

}