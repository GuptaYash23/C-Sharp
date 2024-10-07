/* Operator Precedence

Operator precedence in C# determines the order in which operators are evaluated in expressions. When an expression contains multiple operators, the precedence rules dictate which operators are applied first. Understanding operator precedence is crucial for writing correct and predictable code.

Operator Precedence Levels

C# has a defined order of precedence for its operators. Here’s a list of common operators in C# arranged by their precedence from highest to lowest:

1. Postfix Increment/Decrement: ++, -- (e.g., x++, x--)
2. Unary Plus/Minus: +, - (e.g., +x, -x)
3. Logical NOT: !
4. Bitwise NOT: ~
5. Multiplication/Division/Modulus: *, /, %
6. Addition/Subtraction: +, -
7. Shift Operators: <<, >>
8. Relational Operators: <, >, <=, >=
9. Equality Operators: ==, !=
10. Bitwise AND: &
11. Bitwise XOR: ^
12. Bitwise OR: |
13. Logical AND: &&
14. Logical OR: ||
15. Conditional (Ternary) Operator: ?:
16. Null Coalescing Operator: ??
17. Assignment Operators: =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=
18. Comma Operator: ,

Associativity

In addition to precedence, operators also have associativity, which determines the order of evaluation when operators of the same precedence level appear in an expression. The two types of associativity are:

Left-to-Right: Most operators, such as +, -, *, and &&, are evaluated from left to right.

Right-to-Left: The assignment operators (=, +=, etc.) and the conditional operator (?:) are evaluated from right to left.

Examples

Here are some examples to illustrate operator precedence and associativity:

Example 1: Basic Arithmetic

-------------------------------------------------------------
int result = 5 + 2 * 3; // result is 11, because * has higher precedence than +
-------------------------------------------------------------

Example 2: Parentheses

-------------------------------------------------------------
int result = (5 + 2) * 3; // result is 21, parentheses change the order of evaluation
-------------------------------------------------------------

Example 3: Mixed Operators

-------------------------------------------------------------
int a = 5;
int b = 10;
int c = 15;
int result = a + b * c / 5 - 2; // result is 35
// Evaluated as: a + (b * c / 5) - 2
-------------------------------------------------------------

Example 4: Assignment

-------------------------------------------------------------
int x = 5;
int y = x = 10; // y is 10, x is also 10
// Assignment is right-to-left
-------------------------------------------------------------

Summary

Understanding operator precedence and associativity in C# is essential for writing clear and correct expressions. When in doubt, using parentheses to explicitly define the order of operations can help avoid confusion and ensure that your code behaves as expected. Always refer to the precedence table when dealing with complex expressions to ensure you understand how they will be evaluated.

*/
