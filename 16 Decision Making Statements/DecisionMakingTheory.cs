/*

In C#, decision-making statements allow the program to execute different blocks of code based on conditions. These statements evaluate boolean expressions and determine which code to execute based on whether the expression evaluates to true or false.

Here are the primary decision-making statements in C#:

1. if Statement

The if statement executes a block of code if the condition is true.

Syntax:

-------------------------------------------------------------
if (condition)
{
    // Code to be executed if condition is true
}
-------------------------------------------------------------

2. if-else Statement

The if-else statement provides an alternative block of code to execute when the condition is false.

-------------------------------------------------------------
if (condition)
{
    // Code to be executed if condition is true
}
else
{
    // Code to be executed if condition is false
}
-------------------------------------------------------------

3. else if Ladder

The else if ladder allows you to check multiple conditions sequentially. If one condition is true, the corresponding block is executed, and the rest are skipped.

Syntax:

-------------------------------------------------------------
if (condition1)
{
    // Code to be executed if condition1 is true
}
else if (condition2)
{
    // Code to be executed if condition2 is true
}
else
{
    // Code to be executed if none of the conditions are true
}
-------------------------------------------------------------

4. switch Statement

The switch statement is used for multi-way branching, where one of many possible blocks of code is executed depending on the value of an expression.

Syntax:

-------------------------------------------------------------
switch (expression)
{
    case value1:
        // Code to be executed if expression equals value1
        break;
    case value2:
        // Code to be executed if expression equals value2
        break;
    // More cases
    default:
        // Code to be executed if expression doesn't match any case
        break;
}
-------------------------------------------------------------

5. Ternary Operator (?:)

The ternary operator is a shorthand for if-else statements, and it evaluates a condition to return one of two values.


Syntax:

-------------------------------------------------------------
condition ? value_if_true : value_if_false;
-------------------------------------------------------------

Example:

-------------------------------------------------------------
int x = 10;
string result = (x > 5) ? "x is greater than 5" : "x is less than or equal to 5";
Console.WriteLine(result); // Output: "x is greater than 5"
-------------------------------------------------------------

6. null-coalescing Operator (??)

The ?? operator is used to provide a default value when an expression is null.

Syntax:

-------------------------------------------------------------
expression ?? default_value;
-------------------------------------------------------------

Example:

-------------------------------------------------------------
string name = null;
string displayName = name ?? "Guest";
Console.WriteLine(displayName); // Output: "Guest"
-------------------------------------------------------------

7. switch Expression (C# 8.0+)

Starting from C# 8.0, the switch expression provides a more concise syntax for pattern matching and multi-branch expressions.

Syntax:

-------------------------------------------------------------
var result = expression switch
{
    value1 => "Result for value1",
    value2 => "Result for value2",
    _ => "Default result"  // The default case
};
-------------------------------------------------------------

Example:

-------------------------------------------------------------
int day = 3;
string dayName = day switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    _ => "Invalid day"
};
Console.WriteLine(dayName); // Output: "Wednesday"
-------------------------------------------------------------

Summary:

if and if-else allow conditional execution based on boolean expressions.
else if helps check multiple conditions.
switch provides a cleaner way to handle multiple values of a single expression.
The ternary operator is a compact form of if-else.
The null-coalescing operator provides a default value for null expressions.
switch expressions offer a modern, concise way of handling multi-branch logic.

*/
