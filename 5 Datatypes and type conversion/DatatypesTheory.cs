/* Datatypes and type conversion

Refer:
1. https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
2. https://www.w3schools.com/cs/cs_data_types.php
3. https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions

C# has a rich set of data types that allow you to store different kinds of data, such as numbers, text, and more. These data types are categorized into two main groups: Value Types and Reference Types.

1. Value Types

Value types store data directly in their own memory space. When you assign a value type variable to another, a copy of the value is made.

Numeric Types

Integral Types:

byte: 8-bit unsigned integer (Range: 0 to 255)
sbyte: 8-bit signed integer (Range: -128 to 127)
short: 16-bit signed integer (Range: -32,768 to 32,767)
ushort: 16-bit unsigned integer (Range: 0 to 65,535)
int: 32-bit signed integer (Range: -2,147,483,648 to 2,147,483,647)
uint: 32-bit unsigned integer (Range: 0 to 4,294,967,295)
long: 64-bit signed integer (Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
ulong: 64-bit unsigned integer (Range: 0 to 18,446,744,073,709,551,615)

Floating-Point Types:

float: 32-bit single-precision floating point (Approximate range: ±1.5e−45 to ±3.4e38, 7 digits precision)

double: 64-bit double-precision floating point (Approximate range: ±5.0e−324 to ±1.7e308, 15-16 digits precision)

decimal: 128-bit high-precision decimal type (Range: ±1.0 × 10^−28 to ±7.9 × 10^28, 28-29 digits precision). Typically used for financial and monetary calculations.

Other Value Types

char: 16-bit Unicode character (e.g., 'A', 'B', '1')
bool: Represents a Boolean value (true or false)

Enumerations (Enums)

enum: A distinct type that consists of a set of named constants. Enums are value types, and by default, the underlying type is int, but you can specify a different integral type.

--------------------------------------------------------------------------------------
enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
--------------------------------------------------------------------------------------

Structs

struct: A value type that can encapsulate data and related functionality. Structs are useful for small data structures.

--------------------------------------------------------------------------------------
struct Point
{
    public int X;
    public int Y;
}
--------------------------------------------------------------------------------------

2. Reference Types

Reference types store references (or addresses) to the actual data rather than the data itself. When you assign a reference type variable to another, both variables point to the same memory location

-> Common Reference Types

i) string: Represents a sequence of characters. Strings are immutable in C#, meaning once created, they cannot be modified.

--------------------------------------------------------------------------------------
string name = "John";
--------------------------------------------------------------------------------------

ii) object: The base type from which all other types, both value and reference types, derive. Any data type can be assigned to an object.

--------------------------------------------------------------------------------------
object obj = 42; // Can hold any type of value
--------------------------------------------------------------------------------------

iii) class: Defines a reference type that can encapsulate data and methods. Classes are the backbone of object-oriented programming in C#.

--------------------------------------------------------------------------------------
class Person
{
    public string Name;
    public int Age;
}
--------------------------------------------------------------------------------------

iv) array: A collection of items of the same type stored in contiguous memory. Arrays in C# are reference types.

--------------------------------------------------------------------------------------s
int[] numbers = new int[5];
--------------------------------------------------------------------------------------

Other Reference Types

interface: Defines a contract that implementing classes or structs must adhere to. Interfaces are reference types.

--------------------------------------------------------------------------------------
interface IAnimal
{
    void MakeSound();
}
--------------------------------------------------------------------------------------

delegate: Represents a reference to a method. Delegates are used to pass methods as arguments to other methods.

--------------------------------------------------------------------------------------
delegate void MyDelegate(string message);
--------------------------------------------------------------------------------------

Nullable Types

C# provides nullable versions of all value types using the syntax T?, where T is a value type. This allows value types to represent null in addition to their normal range of values.

--------------------------------------------------------------------------------------
int? age = null;
--------------------------------------------------------------------------------------

Type Conversion

Implicit Conversion: Automatically performed when there is no risk of data loss.

--------------------------------------------------------------------------------------
int num = 123;
double d = num;  // Implicit conversion from int to double
--------------------------------------------------------------------------------------

Explicit Conversion: Requires a cast operator when there is a possibility of data loss.

--------------------------------------------------------------------------------------
double d = 123.45;
int num = (int)d;  // Explicit conversion from double to int
--------------------------------------------------------------------------------------

In C#, there are two types of casting:

Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double

Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char

*/


/* Value type vs Reference type

In C#, types are categorized into value types and reference types. Understanding the differences between them is fundamental to grasping how memory management works in C#.

1. Memory Allocation:

Value Types:

Stored on the stack.

The actual data is stored directly in the variable.

Reference Types:

Stored on the heap.

The variable holds a reference (or pointer) to the location in memory where the actual data is stored.

2. Default Behavior:

Value Types:

When you assign one value type variable to another, a copy of the data is made. Changes to the new variable do not affect the original variable.

Reference Types:

When you assign one reference type variable to another, both variables refer to the same memory location. Changes made through one variable will reflect in the other.

3. Examples:

Value Types:

Primitive types like int, float, double, bool, char.
Structs (struct).

Enumerations (enum).

Reference Types:

Classes (class), arrays, strings (string), delegates, and interfaces.

4. Nullability:

Value Types:

Cannot be null by default. However, C# supports nullable value types using Nullable<T> or the shorthand T?.

Reference Types:

Can be null, indicating that the variable does not reference any object in memory.

5. Boxing and Unboxing:

Value Types:

Boxing: Converting a value type to a reference type by wrapping the value in an object on the heap.

Unboxing: Extracting the value type from the object.

Reference Types:

No boxing or unboxing is required since they are already stored on the heap.

6. Performance:

Value Types:

Generally faster to allocate and deallocate because they are stored on the stack and have a shorter lifetime.

Reference Types:

Slower to allocate since they involve heap allocation. They also require garbage collection for memory management, which can add overhead.

7. Passing to Methods:
Value Types:

Passed by value by default. A copy of the variable is passed to the method.

Reference Types:

Passed by reference by default. The reference (or pointer) to the actual object is passed to the method, allowing changes to the object inside the method to affect the original object.

Example Illustrations:

Value Type Example:

----------------------------------------------------------------
int a = 5;
int b = a;  // b is a copy of a
b = 10;

Console.WriteLine(a);  // Output: 5
Console.WriteLine(b);  // Output: 10
----------------------------------------------------------------

Reference Type Example:

----------------------------------------------------------------
class MyClass
{
    public int Value;
}

MyClass obj1 = new MyClass();
obj1.Value = 5;

MyClass obj2 = obj1;  // obj2 references the same object as obj1
obj2.Value = 10;

Console.WriteLine(obj1.Value);  // Output: 10
Console.WriteLine(obj2.Value);  // Output: 10
----------------------------------------------------------------

In the value type example, a and b are independent variables. Changing b does not affect a. In the reference type example, both obj1 and obj2 refer to the same object, so changing the Value property through obj2 also changes it for obj1.

Summary:

Value Types are stored directly, are usually faster to access, and are copied when assigned or passed to methods.

Reference Types store a reference to the data, allow for more complex data structures, and involve reference semantics when assigning or passing to methods.

*/