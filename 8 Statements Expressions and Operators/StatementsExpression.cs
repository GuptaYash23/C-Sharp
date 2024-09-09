/*

In C#, these are foundational concepts that form the building blocks of the language:

1. Statements:

A statement in C# is a complete instruction that the compiler can execute. Each statement typically performs an action, such as declaring a variable, assigning a value, or calling a method.

Statements end with a semicolon (;).

Example:

----------------------------------------------------------------------------------
int x = 5;  // Declaration and assignment statement
Console.WriteLine(x);  // Method call statement
----------------------------------------------------------------------------------

2. Expressions:

An expression is a combination of variables, operators, and values that the C# runtime evaluates to produce a single value.

Expressions can be as simple as a single variable or value, or as complex as a series of operations.

Example:

----------------------------------------------------------------------------------
int y = 2 + 3;  // The expression `2 + 3` evaluates to 5
----------------------------------------------------------------------------------

3. Operators:

Operators are symbols that specify the type of operation to be performed on operands in an expression.

C# has several types of operators, including:

Arithmetic Operators: +, -, *, /, %
Comparison Operators: ==, !=, <, >, <=, >=
Logical Operators: &&, ||, !
Assignment Operators: =, +=, -=, etc.

Example:

----------------------------------------------------------------------------------
int result = 10 + 5;  // `+` is an arithmetic operator
----------------------------------------------------------------------------------

They can be further classified as 

Unary Operators

Unary operators operate on a single operand

Examples:

----------------------------------------------------------------------------------
int x = 5;

x++;  // Increment operator: x becomes 6
x--;  // Decrement operator: x becomes 5 again
bool isTrue = !false;  // Logical NOT operator: isTrue becomes true
int y = -x;  // Unary minus operator: y becomes -5
----------------------------------------------------------------------------------

Binary Operators

Binary operators operate on two operands.

----------------------------------------------------------------------------------
int a = 10;
int b = 20;

int sum = a + b;  // Addition operator: sum becomes 30
int difference = a - b;  // Subtraction operator: difference becomes -10
bool isEqual = (a == b);  // Equality operator: isEqual becomes false
bool logicalAnd = (a < b) && (a > 5);  // Logical AND operator: logicalAnd becomes true
----------------------------------------------------------------------------------

Ternary Operators

The ternary operator is the only operator in C# that takes three operands.
It is used for inline conditional expressions and is represented by ? :.

Syntax: condition ? expression1 : expression2

If the condition is true, expression1 is evaluated; if false, expression2 is evaluated.

----------------------------------------------------------------------------------
int number = 10;
string result = (number > 5) ? "Greater than 5" : "Less than or equal to 5";
// result becomes "Greater than 5" because the condition is true
----------------------------------------------------------------------------------

4. Operands:

Operands are the values or variables on which operators act in an expression.
In the expression 10 + 5, both 10 and 5 are operands.

Example:

----------------------------------------------------------------------------------
int a = 3;  // `3` is an operand
int b = 4;  // `4` is an operand
int sum = a + b;  // `a` and `b` are operands for the `+` operator
----------------------------------------------------------------------------------

5. Keywords:

Keywords are reserved words in C# that have special meaning to the compiler. You cannot use them as identifiers (like variable names).

Examples of keywords include int, class, public, return, if, else, for, while, etc.

Example:

----------------------------------------------------------------------------------
int number = 10;  // `int` is a keyword
if (number > 5) {  // `if` is a keyword
    Console.WriteLine("Number is greater than 5.");
}
----------------------------------------------------------------------------------

*/



