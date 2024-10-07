/* Console.WriteLine() and Console.ReadLine()

In C#, the Console class provides methods for interacting with the console (or terminal). Two commonly used methods for this purpose are Console.WriteLine for printing output and Console.ReadLine for reading user input. Let's break down how each of these works:

1. Printing Output to the Console using Console.WriteLine

The Console.WriteLine method is used to display text or other output on the console. It prints the specified data followed by a newline, meaning the cursor moves to the next line after printing.

Syntax:

-----------------------------------------------------------------------
Console.WriteLine("Your text here");
-----------------------------------------------------------------------

Example:

-----------------------------------------------------------------------
Console.WriteLine("Hello, World!");        // Hello, World!
-----------------------------------------------------------------------

Newline: After printing "Hello, World!", the cursor moves to the next line.

Placeholders: You can also use placeholders to format strings:

Example:

-----------------------------------------------------------------------
Console.WriteLine("The sum of {0} and {1} is {2}", 5, 10, 5 + 10);
-----------------------------------------------------------------------

Output:

-----------------------------------------------------------------------
The sum of 5 and 10 is 15
-----------------------------------------------------------------------

2. Reading User Input from the Console using Console.ReadLine

The Console.ReadLine method reads a line of input from the console. It waits for the user to enter text and press Enter, then returns that text as a string.

Syntax:

-----------------------------------------------------------------------
string userInput = Console.ReadLine();
-----------------------------------------------------------------------

Example:

-----------------------------------------------------------------------
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!");
-----------------------------------------------------------------------

Console Interaction:

-----------------------------------------------------------------------
Enter your name:
[User types: John]
Hello, John!
-----------------------------------------------------------------------

User Prompt: The first Console.WriteLine asks the user to enter their name.

User Input: Console.ReadLine captures the input provided by the user (e.g., "John").

Display Output: The final Console.WriteLine prints a greeting using the captured input.

-> Using Them Together:

Combining Console.WriteLine and Console.ReadLine is common when you need to interact with users, such as asking questions and responding to their answers.

Example:

-----------------------------------------------------------------------
Console.WriteLine("Enter the first number:");
string input1 = Console.ReadLine();

Console.WriteLine("Enter the second number:");
string input2 = Console.ReadLine();

int number1 = int.Parse(input1);
int number2 = int.Parse(input2);

int sum = number1 + number2;

Console.WriteLine("The sum of the two numbers is: " + sum);
-----------------------------------------------------------------------

Console Interaction:

-----------------------------------------------------------------------
Enter the first number:
[User types: 5]
Enter the second number:
[User types: 7]
The sum of the two numbers is: 12
-----------------------------------------------------------------------

*/

/* References in C#

When your compiler or integrated development environment (IDE) shows "0 references" on top of some classes and functions, it means that those classes or functions are not being used anywhere else in your code.

Explanation:

References: In a programming context, a "reference" is a link or usage of a particular class, method, or variable from another part of your code. For instance, if you define a method and then call it elsewhere in your code, that call is considered a reference to the method.

0 References: If you see "0 references," it indicates that the class, method, or variable is defined but not used or called from any other part of the code. This might suggest that the code is unnecessary or that you've forgotten to use it where intended.

Common Scenarios:

Unused Code: If a class or method was written but never used, the "0 references" alert will help you identify it. You may want to remove this unused code if it's not needed.

Still in Development: You might see "0 references" if you have defined a class or method but haven't yet written the code that uses it. This is common during development when the code structure is still being built.

Refactoring: During refactoring, you may move or remove certain parts of your code, leading to unused methods or classes that now show "0 references."

*/

/* Escape Sequences

In C#, escape sequences are special character combinations that allow you to represent characters that are difficult or impossible to include directly in a string. They are typically used to insert characters like newlines, tabs, or quotes into strings. Escape sequences begin with a backslash (\), followed by a specific character that indicates the type of escape sequence.

Here are some common escape sequences in C#:

1. Newline: \n
Inserts a new line in the string.

--------------------------------------------------------------------------------------------
string text = "Hello,\nWorld!";
// Output: 
// Hello,
// World!
--------------------------------------------------------------------------------------------

2. Tab: \t
Inserts a horizontal tab in the string.

--------------------------------------------------------------------------------------------
string text = "Hello,\tWorld!";
// Output: "Hello,    World!" (with a tab space)
--------------------------------------------------------------------------------------------

3. Backslash: \\
Inserts a backslash character.

--------------------------------------------------------------------------------------------
string text = "This is a backslash: \\";
--------------------------------------------------------------------------------------------

4. Single Quote: \'
Inserts a single quote character.

--------------------------------------------------------------------------------------------
string text = "It\'s a sunny day.";
--------------------------------------------------------------------------------------------

5. Double Quote: \"
Inserts a double quote character.

--------------------------------------------------------------------------------------------
string text = "He said, \"Hello!\"";
--------------------------------------------------------------------------------------------

6. Carriage Return: \r
Moves the cursor to the beginning of the line without advancing to the next line.

--------------------------------------------------------------------------------------------
string text = "Hello,\rWorld!";
// Output: "World!" (overwrites "Hello,")
--------------------------------------------------------------------------------------------

7. Form Feed: \f
Advances the cursor to the next page (not commonly used in modern applications).

8. Vertical Tab: \v
Inserts a vertical tab (not commonly used).

9. Unicode Character: \uXXXX
Inserts a Unicode character, where XXXX is the hexadecimal code for the character.

10. Octal Value: \0 (and other octal values)
Represents a character based on its octal value (not commonly used in C#).

Escape sequences are essential for formatting strings and including special characters in your output. When using escape sequences, it's important to remember that they only work in regular string literals (enclosed in double quotes) and not in verbatim string literals (which use the @ symbol). In verbatim strings, you would need to double the backslashes for them to be recognized, as shown below:

--------------------------------------------------------------------------------------------
string path = @"C:\Users\Example\Documents\file.txt"; // No need to escape backslashes
--------------------------------------------------------------------------------------------

*/

/* Verbatim literal

In C#, a verbatim string literal is a string that is prefixed with the @ symbol. This allows the string to span multiple lines and to include special characters, such as backslashes (\), without needing to escape them. Verbatim string literals are particularly useful for file paths, regular expressions, or any other scenario where you want to include characters that would normally require escaping in a regular string.

Here’s an example of a verbatim string literal:

--------------------------------------------------------------------------------------------
string filePath = @"C:\Users\Example\Documents\file.txt";
--------------------------------------------------------------------------------------------

In this example, the backslashes in the file path do not need to be escaped, making the string easier to read and write.

You can also use verbatim string literals to create multi-line strings:

--------------------------------------------------------------------------------------------
string multiLineString = @"This is a string
that spans multiple lines
without needing to use escape characters.";
--------------------------------------------------------------------------------------------

In this case, the line breaks are preserved in the string.

However, if you want to include a double quote (") in a verbatim string, you need to escape it by using two double quotes:

--------------------------------------------------------------------------------------------
string quote = @"He said, ""Hello, World!""";
--------------------------------------------------------------------------------------------

This will result in the string: He said, "Hello, World!".
*/

