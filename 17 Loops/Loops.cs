/*

Loops in C# are control structures that allow you to repeatedly execute a block of code as long as a specified condition remains true. They are useful when you need to execute a code block multiple times without manually writing the same code over and over.

C# provides several types of loops:

1. for Loop

The for loop is typically used when the number of iterations is known beforehand. It consists of three parts: initialization, condition, and iteration.

Syntax:

-------------------------------------------------------------
for (initialization; condition; iteration)
{
    // Code to be executed
}
-------------------------------------------------------------

Example:

-------------------------------------------------------------
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}
-------------------------------------------------------------

Logic:

Initialization: int i = 0 (starts the loop variable i).
Condition: i < 5 (the loop runs as long as i is less than 5).
Iteration: i++ (increments i after each loop iteration).

2. while Loop

The while loop is used when the number of iterations is not known beforehand, and the loop should continue running as long as a condition is true.

Syntax:

-------------------------------------------------------------
while (condition)
{
    // Code to be executed
}
-------------------------------------------------------------

Example:

-------------------------------------------------------------
int i = 0;
while (i < 5)
{
    Console.WriteLine("Iteration: " + i);
    i++;
}
-------------------------------------------------------------

3. do-while Loop

The do-while loop is similar to the while loop, but it guarantees that the code block runs at least once, regardless of whether the condition is true initially.


Syntax:

-------------------------------------------------------------
do
{
    // Code to be executed
} while (condition);
-------------------------------------------------------------

Example:

-------------------------------------------------------------
int i = 0;
do
{
    Console.WriteLine("Iteration: " + i);
    i++;
} while (i < 5);
-------------------------------------------------------------

4. foreach Loop

The foreach loop is used to iterate over collections (like arrays, lists, etc.). It does not require a counter variable and is mainly used when you want to iterate through all elements of a collection.

Syntax:

-------------------------------------------------------------
foreach (type variable in collection)
{
    // Code to be executed
}
-------------------------------------------------------------





