using System;

class ParentClass
{
    // Virtual method that can be overridden in derived classes
    public virtual void OverridableMethod()
    {
        Console.WriteLine("ParentClass OverridableMethod");
    }
    
    // Non-virtual method (can be hidden in derived classes)
    public void HiddenMethod()
    {
        Console.WriteLine("ParentClass HiddenMethod");
    }
}

class ChildClass : ParentClass
{
    // Overriding the parent class virtual method
    public override void OverridableMethod()
    {
        Console.WriteLine("ChildClass OverridableMethod");
    }
    
    // Hiding the parent class non-virtual method using 'new'
    public new void HiddenMethod()
    {
        Console.WriteLine("ChildClass HiddenMethod");
    }
}

class Program
{
    static void Main()
    {
        ChildClass child = new ChildClass();
        
        // Upcasting: Parent class reference to a child class object
        ParentClass parent = child;

        // --- Method Overriding ---
        Console.WriteLine("Calling OverridableMethod using parent reference:");
        // Calls the ChildClass's OverridableMethod due to overriding
        parent.OverridableMethod();  // Output: "ChildClass OverridableMethod"

        Console.WriteLine("Calling OverridableMethod using child reference:");
        // Calls the ChildClass's OverridableMethod (directly using child reference)
        child.OverridableMethod();  // Output: "ChildClass OverridableMethod"

        // --- Method Hiding ---
        Console.WriteLine("\nCalling HiddenMethod using parent reference:");
        // Calls the ParentClass's HiddenMethod due to method hiding
        parent.HiddenMethod();  // Output: "ParentClass HiddenMethod"

        Console.WriteLine("Calling HiddenMethod using child reference:");
        // Calls the ChildClass's HiddenMethod (directly using child reference)
        child.HiddenMethod();  // Output: "ChildClass HiddenMethod"
    }
}
