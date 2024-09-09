/* Increment Decrement Operators

In C#, increment and decrement operators are used to increase or decrease the value of a variable by one. These operators are particularly useful for loop control and simple arithmetic operations. There are two types of increment and decrement operators: the prefix and postfix operators.

1. Increment Operator (++)

The increment operator increases the value of a variable by one.

Prefix Increment (++variable): Increments the variable's value by one and then returns the new value.

-------------------------------------------------------------------------------
int a = 5;
int b = ++a; // a is now 6, b is 6
-------------------------------------------------------------------------------

Postfix Increment (variable++): Returns the current value of the variable and then increments it by one.

-------------------------------------------------------------------------------
int a = 5;
int b = a++; // b is 5, a is now 6
-------------------------------------------------------------------------------

2. Decrement Operator (--)

The decrement operator decreases the value of a variable by one.

Prefix Decrement (--variable): Decrements the variable's value by one and then returns the new value.

-------------------------------------------------------------------------------
int a = 5;
int b = --a; // a is now 4, b is 4
-------------------------------------------------------------------------------

Postfix Decrement (variable--): Returns the current value of the variable and then decrements it by one.

Summary of Behavior

Prefix (++ or --): The operation is performed first, and then the new value is used in the expression.

Postfix (++ or --): The current value is used in the expression first, and then the operation is performed.

*/