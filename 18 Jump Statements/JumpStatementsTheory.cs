/* Jump Statements

In C#, jump statements allow you to control the flow of execution by transferring control from one part of the program to another. These are useful for breaking out of loops, skipping iterations, or exiting functions early. The key jump statements in C# are:

1. break

Purpose: Terminates the closest enclosing loop (for, while, do-while, foreach) or switch statement and transfers control to the statement following the loop or switch.

Example:

--------------------------------------------------------------
for (int i = 0; i < 10; i++) {
    if (i == 5) {
        break; // Exits the loop when i is 5
    }
    Console.WriteLine(i);
}
--------------------------------------------------------------

2. continue

Purpose: Skips the remaining part of the current iteration of the closest enclosing loop and jumps to the next iteration.

Example:

--------------------------------------------------------------
for (int i = 0; i < 10; i++) {
    if (i % 2 == 0) {
        continue; // Skips even numbers and moves to the next iteration
    }
    Console.WriteLine(i);
}
--------------------------------------------------------------

3. return

Purpose: Exits the current method and returns a value (if the method has a return type) or nothing (void methods).

Example:

--------------------------------------------------------------
int Add(int a, int b) {
    return a + b; // Returns the sum of a and b
}

void Display() {
    return; // Exits the method with no return value
}
--------------------------------------------------------------

4. goto

Purpose: Transfers control to a labeled statement in the same method. This can make code harder to follow, so it’s generally advised to use structured control flow statements instead.

Example:

(i)

--------------------------------------------------------------
int i = 0;
start:
    if (i < 5) {
        Console.WriteLine(i);
        i++;
        goto start; // Jumps back to the label 'start'
    }
--------------------------------------------------------------

(ii)

--------------------------------------------------------------
for (int i = 0; i <= 10; i++)
        {
            if (i == 5)
            {
                goto stop;
            }
            Console.WriteLine(i);
        }
        Console.WriteLine("Loop Terminates ...");

    stop:
        Console.WriteLine("Program Terminates ...");
--------------------------------------------------------------



5. throw

Purpose: Used to signal an exception has occurred, and it transfers control to the nearest catch block that can handle the exception.

Example:

--------------------------------------------------------------
void CheckValue(int value) {
    if (value < 0) {
        throw new ArgumentException("Value cannot be negative"); // Throws an exception
    }
}
--------------------------------------------------------------

Each of these jump statements allows you to control how and when code is executed based on specific conditions or scenarios.

*/


