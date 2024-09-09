/* Relational or Comparison Operators

Relational or comparison operators in C# are used to compare two operands. The result of a comparison is a boolean value: true if the comparison is correct, or false if it is not. These operators are commonly used in conditional statements, loops, and expressions where decision-making is required.

Here’s a breakdown of the relational or comparison operators in C#:

1. Equal To (==)

Purpose: Checks if two operands are equal.

Usage:

Returns true if both operands are equal, otherwise returns false.

Example:

---------------------------------------------------------------------
int a = 5;
int b = 5;
bool isEqual = (a == b);  // isEqual becomes true
---------------------------------------------------------------------

2. . Not Equal To (!=)

Purpose: Checks if two operands are not equal.

Usage:

Returns true if the operands are not equal, otherwise returns false.

Example:

---------------------------------------------------------------------
int a = 5;
int b = 10;
bool isNotEqual = (a != b);  // isNotEqual becomes true
---------------------------------------------------------------------

3. Greater Than (>)

Purpose: Checks if the first operand is greater than the second.

Usage:

Returns true if the first operand is greater than the second, otherwise returns false.

Example:

---------------------------------------------------------------------
int a = 10;
int b = 5;
bool isGreater = (a > b);  // isGreater becomes true
---------------------------------------------------------------------

4.  Less Than (<)

Purpose: Checks if the first operand is less than the second.

Usage:

Returns true if the first operand is less than the second, otherwise returns false.

---------------------------------------------------------------------
int a = 5;
int b = 10;
bool isLess = (a < b);  // isLess becomes true
---------------------------------------------------------------------

5. Greater Than or Equal To (>=)

Purpose: Checks if the first operand is greater than or equal to the second.

Usage:

Returns true if the first operand is greater than or equal to the second, otherwise returns false.

--------------------------------------------------------------------
int a = 10;
int b = 10;
bool isGreaterOrEqual = (a >= b);  // isGreaterOrEqual becomes true
--------------------------------------------------------------------

6. Less Than or Equal To (<=)

Purpose: Checks if the first operand is less than or equal to the second.

Usage:

Returns true if the first operand is less than or equal to the second, otherwise returns false.

Example:

--------------------------------------------------------------------
int a = 5;
int b = 10;
bool isLessOrEqual = (a <= b);  // isLessOrEqual becomes true
--------------------------------------------------------------------

Example of Relational Operators:

--------------------------------------------------------------------
int x = 10;
int y = 20;

bool result1 = (x == y);  // false
bool result2 = (x != y);  // true
bool result3 = (x > y);   // false
bool result4 = (x < y);   // true
bool result5 = (x >= 10); // true
bool result6 = (y <= 15); // false
--------------------------------------------------------------------

*/
