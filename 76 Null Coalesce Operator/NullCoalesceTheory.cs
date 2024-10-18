/* Null Coalescing Operator (??)

The null coalescing operator (??) is used to provide a default value in case a given operand is null. It checks whether the left-hand operand is null, and if so, it returns the right-hand operand (the default value). If the left-hand operand is not null, it simply returns that value.

It’s often used to handle scenarios where you want to avoid NullReferenceException or provide a fallback when a nullable type or reference type might be null.

Syntax:

---------------------------------------------------------------------------------------------------------------------
result = variable ?? defaultValue;
---------------------------------------------------------------------------------------------------------------------

variable: The value to be checked for null.

defaultValue: The value to be return if variable is null.

Simple Example:

---------------------------------------------------------------------------------------------------------------------
using System;

class Program
{
    static void Main()
    {
        // Nullable string
        string name = null;

        // Using the null coalescing operator to provide a default value
        string displayName = name ?? "Default Name";

        Console.WriteLine(displayName);  // Output: Default Name
    }
}
---------------------------------------------------------------------------------------------------------------------

Explanation:

In this example, name is null. The null coalescing operator checks the value of name, and since it’s null, it returns "Default Name", which is printed as the output.

If name had been assigned a non-null value, it would have returned that instead.

Another Example:

---------------------------------------------------------------------------------------------------------------------
using System;

class Program
{
    static void Main()
    {
        // Nullable integer
        int? num = null;

        // Using null coalescing to provide a default value for a nullable type
        int result = num ?? -1;

        Console.WriteLine(result);  // Output: -1

        // Now assigning a value to num
        num = 42;

        // Using null coalescing again
        result = num ?? -1;

        Console.WriteLine(result);  // Output: 42
    }
}
---------------------------------------------------------------------------------------------------------------------

Explanation:

num is initially null, so the operator returns -1 as the default value.

After assigning num = 42, the operator returns 42, as the value is no longer null.

Use Cases:

Providing a fallback or default value when working with nullable types or potentially null reference types.

Preventing NullReferenceException by ensuring you always have a valid value.

The null coalescing operator simplifies code by avoiding explicit if checks for null and providing a clean, concise syntax for default values.
*/
