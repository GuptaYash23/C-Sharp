/* Logical and Conditional Operators C#

I) Logical Operators

Logical operators in C# are used to perform logical operations on Boolean expressions, typically returning a true or false value. These operators are essential when you need to combine multiple conditions or invert them in control flow statements like if, while, and for. Logical Opeators are binary operators. Here are the main logical operators in C#:

1. AND Operator (&&)

Description: The && (AND) operator returns true if both operands are true. If either operand is false, the result is false.

Example:

---------------------------------------------------------------------
bool result = (5 > 3) && (10 > 7);  // true
bool result2 = (5 > 3) && (10 < 7); // false
---------------------------------------------------------------------

2. OR Operator (||)

Description: The || (OR) operator returns true if at least one of the operands is true. It returns false only if both operands are false.

Example:

---------------------------------------------------------------------
bool result = (5 > 3) || (10 < 7);  // true
bool result2 = (5 < 3) || (10 < 7); // false
---------------------------------------------------------------------

3. NOT Operator (!)

Description: The ! (NOT) operator is a unary operator that inverts the Boolean value of its operand. If the operand is true, it returns false; if it's false, it returns true.

Example:

---------------------------------------------------------------------
bool result = !(5 > 3);  // false
bool result2 = !(5 < 3); // true
---------------------------------------------------------------------

4. XOR Operator (^)

Description: The ^ (XOR) operator returns true if exactly one of the operands is true. If both are true or both are false, it returns false.

---------------------------------------------------------------------
bool result = (5 > 3) ^ (10 < 7);  // true
bool result2 = (5 > 3) ^ (10 > 7); // false
---------------------------------------------------------------------

5. Conditional Logical AND (&) and OR (|)

Description: The & and | operators are similar to && and || but are not short-circuiting. This means that both expressions are evaluated regardless of the first operand's result.

Example:

---------------------------------------------------------------------
bool result = (5 > 3) & (10 > 7);  // true
bool result2 = (5 > 3) | (10 < 7); // true
---------------------------------------------------------------------

Short-Circuiting Behavior

Description: The && and || operators are short-circuiting. This means that in an expression using &&, if the first operand is false, the second operand is not evaluated (because the whole expression can't be true). Similarly, in an expression using ||, if the first operand is true, the second operand is not evaluated (because the whole expression is already true).

Example:

---------------------------------------------------------------------
bool result = (false) && (SomeMethod());  // SomeMethod() is not called
bool result2 = (true) || (SomeMethod());  // SomeMethod() is not called
---------------------------------------------------------------------

Practical Example:

---------------------------------------------------------------------
int x = 10;
int y = 20;

if (x > 5 && y < 25)
{
    Console.WriteLine("Both conditions are true");
}

if (x == 10 || y == 15)
{
    Console.WriteLine("At least one condition is true");
}

if (!(x == 10))
{
    Console.WriteLine("x is not equal to 10");
}
---------------------------------------------------------------------

II) Conditional Operators

Conditional operators in C# are used to perform conditional evaluations and make decisions based on certain conditions. The primary conditional operators in C# are the ternary conditional operator and the null-coalescing operator. Here’s a detailed look at each:

1. Ternary Conditional Operator (? :)

Syntax:

---------------------------------------------------------------------
condition ? trueExpression : falseExpression
---------------------------------------------------------------------

Description

The ternary conditional operator evaluates a condition and returns one of two values based on whether the condition is true or false.

condition: A Boolean expression that determines which value to return.

trueExpression: The value returned if the condition is true.

falseExpression: The value returned if the condition is false.

Example:

---------------------------------------------------------------------
int a = 10;
int b = 20;
int max = (a > b) ? a : b;  // max will be assigned the value of b (20), since a is not greater than b
--------------------------------------------------------------------

2. Null-Coalescing Operator (??)

Syntax:

--------------------------------------------------------------------
expression1 ?? expression2
--------------------------------------------------------------------

Description

The null-coalescing operator is used to provide a default value when a nullable expression is null. It evaluates the first expression and, if it is null, it returns the second expression.

expression1: The primary expression to evaluate.

expression2: The value to return if expression1 is null.

Example:

--------------------------------------------------------------------
string name = null;
string defaultName = "Unknown";
string result = name ?? defaultName;  // result will be "Unknown" since name is null
--------------------------------------------------------------------

3. Null-Coalescing Assignment Operator (??=)

Syntax:

--------------------------------------------------------------------
variable ??= value
--------------------------------------------------------------------

Description

The null-coalescing assignment operator is used to assign a value to a variable only if the variable is null.

variable: The variable to check for null.
value: The value to assign if the variable is null.

Example:

--------------------------------------------------------------------
string name = null;
name ??= "Default Name";  // name will be assigned "Default Name" because it was null
--------------------------------------------------------------------

Usage Examples

1. Using Ternary Operator in Conditional Logic:

--------------------------------------------------------------------
int age = 18;
string status = (age >= 18) ? "Adult" : "Minor";
Console.WriteLine(status);  // Outputs "Adult"
--------------------------------------------------------------------

2. Using Null-Coalescing Operator for Default Values:

--------------------------------------------------------------------
string input = null;
string output = input ?? "No input provided";
Console.WriteLine(output);  // Outputs "No input provided"
--------------------------------------------------------------------

3. Using Null-Coalescing Assignment Operator:

--------------------------------------------------------------------
int? number = null;
number ??= 10;
Console.WriteLine(number);  // Outputs "10"
--------------------------------------------------------------------

*/










