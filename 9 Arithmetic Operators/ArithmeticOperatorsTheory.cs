/*

Arithmetic operators in C# are used to perform basic mathematical operations on numerical data types like int, float, double, decimal, etc. These operations include addition, subtraction, multiplication, division, and modulus. Here's an overview of each arithmetic operator:

1. Addition (+)

Purpose: Adds two operands together.

Usage:

Can be used with numbers to perform addition.
Can also be used to concatenate strings.

Example:

---------------------------------------------------------------------
int sum = 10 + 5;  // sum becomes 15
string message = "Hello, " + "World!";  // message becomes "Hello, World!"
---------------------------------------------------------------------

2. Subtraction (-)

Purpose: Subtracts the second operand from the first.

Usage:

Used to perform subtraction between two numbers.

Example:

---------------------------------------------------------------------
int difference = 10 - 5;  // difference becomes 5
---------------------------------------------------------------------

3. Multiplication (*)

Purpose: Multiplies two operands.

Usage:

Used to perform multiplication between two numbers.

Example:

---------------------------------------------------------------------
int product = 10 * 5;  // product becomes 50
---------------------------------------------------------------------

4. Division (/)

Purpose: Divides the first operand by the second.

Usage:

If both operands are integers, the result is an integer, and the fractional part is discarded.

If one or both operands are floating-point numbers (float, double, decimal), the result includes the fractional part.

Example:

---------------------------------------------------------------------
int quotient = 10 / 2;  // quotient becomes 5
double divisionResult = 10.0 / 3.0;  // divisionResult becomes 3.3333...
---------------------------------------------------------------------

Note: Division by zero will throw a DivideByZeroException for integers and result in Infinity or NaN (Not a Number) for floating-point types.

5. Modulus (%)

Purpose: Returns the remainder of the division of the first operand by the second.

Usage:

Often used to determine if a number is even or odd or to find the remainder in a division.

Example:

---------------------------------------------------------------------
int remainder = 10 % 3;  // remainder becomes 1
---------------------------------------------------------------------

6. Unary Plus (+)

Purpose: Indicates a positive value. (This operator is usually redundant as numbers are positive by default.)

Example:

---------------------------------------------------------------------
int positiveValue = +5;  // positiveValue becomes 5
---------------------------------------------------------------------

7. Unary Minus (-)

Purpose: Negates a value (turns a positive number into a negative one and vice versa).

---------------------------------------------------------------------
int negativeValue = -5;  // negativeValue becomes -5
---------------------------------------------------------------------

Example of Arithmetic Operators:

---------------------------------------------------------------------
int a = 15;
int b = 4;

int addResult = a + b;  // 19
int subtractResult = a - b;  // 11
int multiplyResult = a * b;  // 60
int divideResult = a / b;  // 3 (integer division)
int modulusResult = a % b;  // 3
---------------------------------------------------------------------

*/



