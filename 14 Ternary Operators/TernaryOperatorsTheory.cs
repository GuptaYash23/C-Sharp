/* Ternary Operators

In C#, the term "ternary operator" typically refers to the conditional operator (?:), which is the only ternary operator in the language. However, it’s important to clarify that while there is only one ternary operator, there are other related operators that can be used in conjunction with it or in similar contexts. Below, I will explain the conditional (ternary) operator in detail and mention other related operators.

1. Conditional (Ternary) Operator (?:)

The conditional operator is used to evaluate a boolean expression and return one of two values based on whether the expression is true or false.

Syntax:

--------------------------------------------------------
condition ? valueIfTrue : valueIfFalse;
--------------------------------------------------------

Example:

--------------------------------------------------------
int a = 10;
int b = 20;
int max = (a > b) ? a : b; // max will be 20
--------------------------------------------------------

2. Null Coalescing Operator (??)

While not a ternary operator, the null coalescing operator is often used in similar contexts to provide a default value when dealing with nullable types or reference types.

Syntax:

--------------------------------------------------------
value ?? defaultValue;
--------------------------------------------------------

Example:

--------------------------------------------------------
string name = null;
string displayName = name ?? "Guest"; // displayName will be "Guest"
--------------------------------------------------------

3. Null Coalescing Assignment Operator (??=)

This operator assigns the right-hand operand to the left-hand operand only if the left-hand operand is null.

Syntax:

--------------------------------------------------------
variable ??= value;
--------------------------------------------------------

Example:

--------------------------------------------------------
string name = null;
name ??= "Default Name"; // name will be "Default Name"
--------------------------------------------------------

4. Other Related Operators

While they are not ternary operators, the following operators can be used in conditional expressions:

Logical AND (&&): Used to combine two boolean expressions. If both expressions are true, the result is true.

Logical OR (||): Used to combine two boolean expressions. If at least one expression is true, the result is true.

Bitwise AND (&): Can be used in conditional expressions but operates on the bits of the operands.

Bitwise OR (|): Similar to bitwise AND but performs a bitwise OR operation.

Summary

In summary, the primary ternary operator in C# is the conditional operator (?:), which allows for concise conditional evaluations. Additionally, the null coalescing operator (??) and the null coalescing assignment operator (??=) provide useful functionality for handling null values. While other logical and bitwise operators can be used in conditional expressions, they are not classified as ternary operators.

*/