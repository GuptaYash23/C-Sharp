/* Access Specifiers

In C#, access specifiers (or access modifiers) are keywords used to define the accessibility of classes, methods, and other members. By default the access specifiers are considered private. They control the visibility of code elements to other parts of the program. C# has five main access specifiers:

1. public

Visibility: Accessible from anywhere within the program.

Use: When you want the class, method, or field to be accessible by any other code in any assembly.

Example:

-------------------------------------------------------------------------
public class MyClass {
    public int MyProperty { get; set; }
}
------------------------------------------------------------------------


2. private

Visibility: Accessible only within the class or struct in which it is declared.

Use: When you want to restrict access to the member so that it is only available within the same class.

Example:

------------------------------------------------------------------------
class MyClass {
    private int MyPrivateField;
}
------------------------------------------------------------------------

3. protected

Visibility: Accessible within the class in which it is declared, and by derived (child) classes.

Use: When you want to make members accessible to derived classes but not from other parts of the program.

Example:

------------------------------------------------------------------------
class MyClass {
    protected int MyProtectedProperty;
}
------------------------------------------------------------------------

4. internal

Visibility: Accessible within the same assembly but not from another assembly.

Use: Useful for allowing access to code only within the same project or compiled output (DLL).

Example:

------------------------------------------------------------------------
internal class MyClass {
    internal int MyInternalProperty { get; set; }
}
------------------------------------------------------------------------

5. protected internal

Visibility: Accessible from derived classes in any assembly and from within the same assembly.

Use: Allows access to members by derived classes in the same or different assemblies, and by any code in the same assembly.

Example:

------------------------------------------------------------------------
class MyClass {
    protected internal int MyProtectedInternalProperty { get; set; }
}
------------------------------------------------------------------------

6.  private protected (C# 7.2 and later)

Visibility: Accessible within the same class or derived classes, but only if they are in the same assembly.

Use: Combines the restrictions of private and protected. It's like protected, but it limits access to the same assembly.

Example:

------------------------------------------------------------------------
class MyClass {
    private protected int MyPrivateProtectedProperty;
}
------------------------------------------------------------------------

These access specifiers help manage encapsulation and ensure that different parts of your codebase interact only in ways that are intended.

*/

// Only public and internal access specifiers are used with the class

// While using reference for a different namespace in a solution first step is to add it to the reference and then add that namespace resource using the 'using' keyword

// To select which namespace/project to start we need to select it from settings in the solution

// Refer - https://youtu.be/iWsDnm1vWro?si=1zC9cXuSJXKCLxPC