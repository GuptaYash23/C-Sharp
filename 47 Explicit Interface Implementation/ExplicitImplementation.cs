using System;

namespace ExplicitImplementation
{
    interface i1
    {
        void show();
    }

    interface i2
    {
        void show();
    }

    class MyClass : i1, i2
    {
        // Explicit implementation of i1
        void i1.show()
        {
            Console.WriteLine($"This is a method of i1 interface");
        }

        // Explicit implementation of i2
        void i2.show()
        {
            Console.WriteLine($"This is a method of i2 interface");
        }

        // Implicit implementation of i3
        public void show() // This will be an implicit implementation
        {
            Console.WriteLine($"This is a method of the implicit show()");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            // Explicit implementation
            // Calls the explicitly implemented method of i1 interface
            ((i1)obj).show();     // This is a method of i1 interface

            // Calls the explicitly implemented method of i2 interface
            ((i2)obj).show();     // This is a method of i2 interface   

            // Using interface references to call explicitly implemented methods
            i1 obj1 = new MyClass();
            // Calls the explicitly implemented method of i1 interface
            obj1.show();          // This is a method of i1 interface     

            i2 obj2 = new MyClass();
            // Calls the explicitly implemented method of i2 interface
            obj2.show();          // This is a method of i2 interface

            // Implicit implementation
            // Calls the implicitly implemented method (if defined) in MyClass
            obj.show();           // This is a method of the implicit show()

        }
    }
}


/* Example

Explicit Interface Implementation

Explicit Interface Method Calls:

When you cast obj to i1 or i2 and then call show(), you are using explicit interface implementation.

---------------------------------------------------------------------------
((i1)obj).show(); // Calls the explicit implementation of i1.show()
((i2)obj).show(); // Calls the explicit implementation of i2.show()
---------------------------------------------------------------------------

In this case, the show() method is called through the interface type, and it can only be accessed this way because it is implemented explicitly in MyClass. This means that the method is not directly accessible through the MyClass instance.

Implicit Interface Implementation

Implicit Interface Method Calls:

When you create an instance of MyClass and assign it to a variable of type i1 or i2, and then call show(), you are using implicit interface implementation.

---------------------------------------------------------------------------
i1 obj1 = new MyClass();
obj1.show(); // Calls the explicit implementation of i1.show()

i2 obj2 = new MyClass();
obj2.show(); // Calls the explicit implementation of i2.show()
---------------------------------------------------------------------------

In this case, even though the show() method is implemented explicitly, it is being called through a variable of the interface type. The method is still accessible because the variable is of the interface type, which allows you to call the method defined in that interface.

Summary

Explicit Implementation:

Accessed through the interface type only.

Example: ((i1)obj).show(); or ((i2)obj).show();
The method is not accessible directly through the class instance.

Implicit Implementation:

Accessed through a variable of the interface type.
Example: i1 obj1 = new MyClass(); obj1.show();
The method is still called through the interface type, but the variable is declared as the interface type.

In your specific example, both the explicit and implicit implementations are calling the same methods, but the way they are accessed differs based on whether you are casting the object or using an interface variable.

*/