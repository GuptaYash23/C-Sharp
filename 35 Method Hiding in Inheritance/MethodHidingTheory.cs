/* Method Hiding

In C#, method hiding occurs when a derived class defines a method with the same name and signature as a method in its base class, but without overriding it. Instead of using the override keyword (which would mean the method is intended to replace the base method), the method in the derived class uses the new keyword to hide the base class method. This technique tells the compiler that the method in the derived class is not an override, but a new method that hides the base class version.

Key Points:

Hiding vs Overriding: When you hide a method, the base class method is not replaced but is instead shadowed in the derived class. The hidden method can still be called using the base class reference.

The new keyword: It explicitly tells the compiler that the method in the derived class is hiding a method from the base class. (We can skip the new keyword and program will still run fine)

Example:

-------------------------------------------------------------------------
using System;

class BaseClass
{
    public void Display()
    {
        Console.WriteLine("BaseClass Display method");
    }
}

class DerivedClass : BaseClass
{
    // Method hiding
    public new void Display()
    {
        Console.WriteLine("DerivedClass Display method");
    }
}

class Program
{
    static void Main()
    {
        BaseClass baseClassObj = new BaseClass();
        baseClassObj.Display(); // Calls BaseClass Display

        DerivedClass derivedClassObj = new DerivedClass();
        derivedClassObj.Display(); // Calls DerivedClass Display

        BaseClass baseReference = new DerivedClass();
        baseReference.Display(); // Calls BaseClass Display because it's using a base class reference
    }
}
-------------------------------------------------------------------------


Output:

-------------------------------------------------------------------------
BaseClass Display method
DerivedClass Display method
BaseClass Display method
-------------------------------------------------------------------------

Explanation:

When baseClassObj.Display() is called, the BaseClass method is used.
When derivedClassObj.Display() is called, the hidden Display method from DerivedClass is used.

When baseReference.Display() is called, the BaseClass method is used, because baseReference is of type BaseClass. Even though the actual object is of DerivedClass, method hiding doesn't affect this.

If you were overriding the method, the derived class version would be called even if using a base class reference.

*/

/* Base keyword

In C#, the base keyword is used to access members (methods, properties, constructors, or fields) of the base class from within a derived class. It allows the derived class to invoke the functionality of the base class that it might otherwise override or hide.

Key Use Cases for base:

Calling Base Class Methods: When a derived class overrides a method, it can use the base keyword to call the original implementation from the base class.

Accessing Base Class Properties or Fields: You can use base to access properties or fields defined in the base class.

Calling Base Class Constructors: In a derived class constructor, you can use base to call a specific constructor from the base class to initialize inherited members.

1. Calling Base Class Methods

When a derived class overrides a method, you can use the base keyword to call the method in the base class.

-------------------------------------------------------------------------
using System;

class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("BaseClass Display method");
    }
}

class DerivedClass : BaseClass
{
    public override void Display()
    {
        base.Display(); // Calls BaseClass Display method
        Console.WriteLine("DerivedClass Display method");
    }
}

class Program
{
    static void Main()
    {
        DerivedClass obj = new DerivedClass();
        obj.Display(); // Calls both BaseClass and DerivedClass methods
    }
}
-------------------------------------------------------------------------

Output:

-------------------------------------------------------------------------
BaseClass Display method
DerivedClass Display method
-------------------------------------------------------------------------

2. Accessing Base Class Properties or Fields

The base keyword can also be used to access a property or field defined in the base class.

-------------------------------------------------------------------------
class BaseClass
{
    public int Number = 10;
}

class DerivedClass : BaseClass
{
    public void ShowNumber()
    {
        Console.WriteLine("Base class number: " + base.Number);
    }
}
-------------------------------------------------------------------------

Here, base.Number accesses the Number field from BaseClass.

In C#, the base keyword is used to access members (methods, properties, constructors, or fields) of the base class from within a derived class. It allows the derived class to invoke the functionality of the base class that it might otherwise override or hide.

Key Use Cases for base:

Calling Base Class Methods: When a derived class overrides a method, it can use the base keyword to call the original implementation from the base class.

Accessing Base Class Properties or Fields: You can use base to access properties or fields defined in the base class.

Calling Base Class Constructors: In a derived class constructor, you can use base to call a specific constructor from the base class to initialize inherited members.

1. Calling Base Class Methods
When a derived class overrides a method, you can use the base keyword to call the method in the base class.

-------------------------------------------------------------------------
using System;

class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("BaseClass Display method");
    }
}

class DerivedClass : BaseClass
{
    public override void Display()
    {
        base.Display(); // Calls BaseClass Display method
        Console.WriteLine("DerivedClass Display method");
    }
}

class Program
{
    static void Main()
    {
        DerivedClass obj = new DerivedClass();
        obj.Display(); // Calls both BaseClass and DerivedClass methods
    }
}
-------------------------------------------------------------------------

Output:

-------------------------------------------------------------------------
BaseClass Display method
DerivedClass Display method
-------------------------------------------------------------------------

In this example, the base.Display() inside DerivedClass ensures that the base class's version of Display is invoked before the derived class's own implementation.

2. Accessing Base Class Properties or Fields
The base keyword can also be used to access a property or field defined in the base class.

-------------------------------------------------------------------------
class BaseClass
{
    public int Number = 10;
}

class DerivedClass : BaseClass
{
    public void ShowNumber()
    {
        Console.WriteLine("Base class number: " + base.Number);
    }
}
-------------------------------------------------------------------------

Here, base.Number accesses the Number field from BaseClass.

3. Calling Base Class Constructors

In a derived class constructor, you can use the base keyword to call a constructor of the base class. This is useful for initializing fields or properties of the base class.

-------------------------------------------------------------------------
class BaseClass
{
    public BaseClass(int number)
    {
        Console.WriteLine("Base class constructor called with number: " + number);
    }
}

class DerivedClass : BaseClass
{
    public DerivedClass() : base(42) // Calls the BaseClass constructor with argument 42
    {
        Console.WriteLine("Derived class constructor");
    }
}

class Program
{
    static void Main()
    {
        DerivedClass obj = new DerivedClass();
    }
}
-------------------------------------------------------------------------

Output:

-------------------------------------------------------------------------
Base class constructor called with number: 42
Derived class constructor
-------------------------------------------------------------------------

In this example, the DerivedClass constructor uses base(42) to call the BaseClass constructor with a parameter. This allows the derived class to pass values to the base class constructor during initialization.

Summary:

base.Method(): Calls a base class method from an overridden method.
base.Property or base.Field: Accesses properties or fields from the base class.

base(arguments): Calls the base class constructor from the derived class constructor.

This provides a way for derived classes to extend or modify behavior while still leveraging the base class's implementation.

*/

/* Cast child class type to parent type

In C#, when you cast a child class type to a parent class type, you will only have access to members that are defined in the parent class. If the child class hides members from the parent class (using the new keyword), the hidden members will not be accessible through the parent class reference. However, there are a few ways to access those hidden members.

Steps to Cast Child Type to Parent Type:

Upcasting: Casting a derived (child) class object to its base (parent) class type. This is done implicitly or explicitly, depending on the situation.

Invoking Hidden Members: After upcasting, only the base class members are accessible. If the child class hides members of the base class using the new keyword, those hidden members won't be accessible unless you use the child class reference again.

Example of Casting and Accessing Hidden Members

Consider a scenario where a method in the child class hides a method from the parent class.

Example:

-------------------------------------------------------------------------
using System;

class ParentClass
{
    public void Display()
    {
        Console.WriteLine("ParentClass Display method");
    }
}

class ChildClass : ParentClass
{
    // Hiding the base class method
    public new void Display()
    {
        Console.WriteLine("ChildClass Display method");
    }
}

class Program
{
    static void Main()
    {
        ChildClass child = new ChildClass();
        
        // Upcasting child class to parent class
        ParentClass parent = (ParentClass)child;

        // Invokes ParentClass Display method (hidden by ChildClass)
        parent.Display();  // Output: "ParentClass Display method"
        
        // Calling the hidden method using the child class reference
        child.Display();  // Output: "ChildClass Display method"
    }
}
-------------------------------------------------------------------------

Output:

-------------------------------------------------------------------------
ParentClass Display method
ChildClass Display method
-------------------------------------------------------------------------

Explanation:

Upcasting:

ParentClass parent = (ParentClass)child; casts the ChildClass object child to the ParentClass type.

When you invoke parent.Display(), it calls the ParentClass version of Display, because the new keyword in the ChildClass hides the ParentClass method, and the reference is of type ParentClass.

Invoking Hidden Method:

To invoke the hidden Display method in the ChildClass, you need to use the ChildClass reference (child.Display()).

Key Points:

Upcasting (casting from child to parent) hides the members of the child class that are declared using new.

To invoke the hidden members, you must use a reference of the child type (like child.Display() in this case).

Accessing Hidden Members via Downcasting:

If you upcast the child object to the parent and later want to access the hidden members, you need to downcast the parent reference back to the child class.

Example:

-------------------------------------------------------------------------
class Program
{
    static void Main()
    {
        ChildClass child = new ChildClass();
        
        // Upcasting
        ParentClass parent = (ParentClass)child;
        parent.Display(); // Calls ParentClass Display method

        // Downcasting back to child type to access hidden method
        ChildClass childAgain = (ChildClass)parent;
        childAgain.Display(); // Calls ChildClass Display method
    }
}
-------------------------------------------------------------------------

Output:

-------------------------------------------------------------------------
ParentClass Display method
ChildClass Display method
-------------------------------------------------------------------------

Explanation:

After upcasting, when you call parent.Display(), it will call the ParentClass version of the method.

After downcasting the parent reference back to the ChildClass type (ChildClass childAgain = (ChildClass)parent;), you can access the hidden method (childAgain.Display()).

Summary:

Upcasting hides child class methods that are marked with new.
To invoke hidden methods, you need a reference of the child type.
Downcasting can be used to access the child class methods after the object has been upcast to the parent class type.

*/

/* Parent class pointer to a child class object

In C#, when you use a parent class reference (or pointer, conceptually) to point to a child class object, the behavior depends on whether the method in the child class is overriding or hiding the method from the parent class. This involves the concepts of method overriding and method hiding, both of which affect how method calls are resolved. When we create the object of child class the object of parent class is automatically created.

1. Method Overriding (Polymorphism)

If the child class overrides a method from the parent class (using the override keyword), the child class method will be called, even if the reference is of the parent class type. This is known as runtime polymorphism or dynamic method dispatch.

2. Method Hiding

If the child class hides a method from the parent class (using the new keyword), then the parent class method will be called when the reference is of the parent type. The child class method is hidden and will only be called if the reference is of the child type.

Example: Parent Class Pointer to Child Class Object

Let's demonstrate both method overriding and method hiding

1. Method Overriding Example

-------------------------------------------------------------------------
using System;

class ParentClass
{
    // Virtual method that can be overridden
    public virtual void Display()
    {
        Console.WriteLine("ParentClass Display method");
    }
}

class ChildClass : ParentClass
{
    // Overriding the parent class method
    public override void Display()
    {
        Console.WriteLine("ChildClass Display method");
    }
}

class Program
{
    static void Main()
    {
        ChildClass child = new ChildClass();
        
        // Parent class reference to a child class object
        ParentClass parent = child;

        // Calls the ChildClass Display method due to overriding
        parent.Display();  // Output: "ChildClass Display method"
    }
}
-------------------------------------------------------------------------

Explanation:

ParentClass defines a Display method, which is marked virtual, meaning it can be overridden by derived classes.

ChildClass overrides the Display method.

When ParentClass parent = child; is used, even though the reference (parent) is of type ParentClass, it will call the overridden method in ChildClass due to polymorphism.

The parent.Display() call will invoke the ChildClass version of Display.

Output:

-------------------------------------------------------------------------
ChildClass Display method
-------------------------------------------------------------------------

2. Method Hiding Example

-------------------------------------------------------------------------
using System;

class ParentClass
{
    // Non-virtual method in the parent class
    public void Display()
    {
        Console.WriteLine("ParentClass Display method");
    }
}

class ChildClass : ParentClass
{
    // Hiding the parent class method using 'new'
    public new void Display()
    {
        Console.WriteLine("ChildClass Display method");
    }
}

class Program
{
    static void Main()
    {
        ChildClass child = new ChildClass();
        
        // Parent class reference to a child class object
        ParentClass parent = child;

        // Calls the ParentClass Display method due to method hiding
        parent.Display();  // Output: "ParentClass Display method"
        
        // Child class reference calling its own method
        child.Display();  // Output: "ChildClass Display method"
    }
}
-------------------------------------------------------------------------

Explanation:

ChildClass hides the Display method from ParentClass using the new keyword.

When ParentClass parent = child; is used, the parent.Display() call invokes the ParentClass version of Display, because the method in ChildClass is hidden.

To call the ChildClass version, you need to use a ChildClass reference (child.Display()).

Output:

-------------------------------------------------------------------------
ParentClass Display method
ChildClass Display method
-------------------------------------------------------------------------

Key Points:

Method Overriding (Polymorphism):

The child class method is called if it overrides the base class method, even when the reference is of the parent class type.
The method resolution happens at runtime.

Method Hiding:

The parent class method is called if the method is hidden in the child class (using new) when the reference is of the parent class type.
The method resolution happens at compile time for non-virtual methods.

Summary:

When a parent class reference points to a child class object:
If the method is overridden in the child class (override keyword), the child class method is called (polymorphism).

If the method is hidden in the child class (new keyword), the parent class method is called when the reference is of the parent type.

*/