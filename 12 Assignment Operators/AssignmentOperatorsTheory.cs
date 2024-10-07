/* Assignment Operators

In C#, assignment operators are used to assign values to variables. The most common assignment operator is the equals sign (=), but there are several other compound assignment operators that combine assignment with arithmetic or bitwise operations. Here’s a breakdown of the assignment operators in C#:

1. Basic Assignment Operator

=: This operator assigns the value on the right to the variable on the left.

-------------------------------------------------------------------------------
int a = 5; // Assigns 5 to variable a
-------------------------------------------------------------------------------

2. Compound Assignment Operators

These operators perform an operation and then assign the result to the variable.

+=: Adds the right operand to the left operand and assigns the result to the left operand.

-------------------------------------------------------------------------------
int a = 5;
a += 3; // Equivalent to a = a + 3; a is now 
-------------------------------------------------------------------------------

-=: Subtracts the right operand from the left operand and assigns the result to the left operand.

-------------------------------------------------------------------------------
int a = 5;
a -= 2; // Equivalent to a = a - 2; a is now 3
-------------------------------------------------------------------------------

*=: Multiplies the left operand by the right operand and assigns the result to the left operand.

-------------------------------------------------------------------------------
int a = 5;
a *= 2; // Equivalent to a = a * 2; a is now 10
-------------------------------------------------------------------------------

/=: Divides the left operand by the right operand and assigns the result to the left operand.

-------------------------------------------------------------------------------
int a = 10;
a /= 2; // Equivalent to a = a / 2; a is now 5
-------------------------------------------------------------------------------

%=: Takes the modulus using the left operand and the right operand and assigns the result to the left operand.

-------------------------------------------------------------------------------
int a = 10;
a %= 3; // Equivalent to a = a % 3; a is now 1
-------------------------------------------------------------------------------

&=: Performs a bitwise AND operation and assigns the result to the left operand

-------------------------------------------------------------------------------
int a = 5; // (binary: 0101)
a &= 3;    // (binary: 0011) a is now 1 (binary: 0001)
-------------------------------------------------------------------------------

|=: Performs a bitwise OR operation and assigns the result to the left operand.

-------------------------------------------------------------------------------
int a = 5; // (binary: 0101)
a |= 3;    // (binary: 0011) a is now 7 (binary: 0111)
-------------------------------------------------------------------------------

^=: Performs a bitwise XOR operation and assigns the result to the left operand

-------------------------------------------------------------------------------
int a = 5; // (binary: 0101)
a ^= 3;    // (binary: 0011) a is now 6 (binary: 0110)
-------------------------------------------------------------------------------

<<=: Left shifts the bits of the left operand and assigns the result to the left operand

-------------------------------------------------------------------------------
int a = 5; // (binary: 0101)
a <<= 1;   // a is now 10 (binary: 1010)
-------------------------------------------------------------------------------

>>=: Right shifts the bits of the left operand and assigns the result to the left operand

-------------------------------------------------------------------------------
int a = 5; // (binary: 0101)
a >>= 1;   // a is now 2 (binary: 0010)
-------------------------------------------------------------------------------

Summary

Assignment operators in C# allow you to assign values to variables and perform operations in a concise manner. The basic assignment operator (=) is used for simple assignments, while compound assignment operators combine arithmetic or bitwise operations with assignment, making your code more efficient and easier to read.

*/