/* Boxing and Unboxing

1) Boxing  

Implicit convesion of a value type to a reference type is called boxing

Example:

---------------------------------------------------------------------------------------------------------------------
int num1 = 10; // int is a value type

object obj1 = num1; // Implicit conversion of value type into reference type
---------------------------------------------------------------------------------------------------------------------

--> In Boxing process, a value type is being allocated on the heap rather than the stack.

2) Unboxing

Explicit conversion of the same reference type (which is being created by boxing), back to a value type.

Example:

---------------------------------------------------------------------------------------------------------------------
int num1 = 10;       // int is value type

object obj1 = num1;  // Implicit conversion of value type into reference types (Boxing)

int num2 = (int) obj1;   // Explicit conversion of reference type into value type (Unboxing)
---------------------------------------------------------------------------------------------------------------------

--> In unboxing process, an unboxed value is begin allocated to a variable on the stack rather than the heap.


---------------------------------------------------------------------------------------------------------------------

-> Boxing and Unboxing in C#

Boxing and unboxing are concepts in C# related to how value types and reference types are handled by the runtime. Since value types (like int, double, and structs) and reference types (like object, string, and classes) are stored differently in memory, C# provides mechanisms to convert between them when needed.

1. Boxing:

Boxing is the process of converting a value type (stored on the stack) into a reference type (stored on the heap). In C#, value types are automatically "boxed" when they are assigned to variables of type object or any interface they implement.

During boxing:

- A new object is allocated on the heap.

- The value of the value type is copied into this object.

- The reference to this object is returned.

Example of Boxing:

---------------------------------------------------------------------------------------------------------------------
int num = 42;           // Value type (stored on the stack)
object obj = num;        // Boxing: 'num' is converted to a reference type (stored on the heap)
Console.WriteLine(obj);  // Output: 42
---------------------------------------------------------------------------------------------------------------------

In this example, the value type int is boxed into the reference type object. The value 42 is placed in a new object on the heap, and the variable obj holds a reference to that object.


2. Unboxing:

Unboxing is the reverse process of boxing. It converts a reference type (stored on the heap) back into its corresponding value type (stored on the stack). When unboxing occurs, the runtime checks that the reference type actually holds a boxed value of the desired value type. If it does, the value is extracted and placed back on the stack.

During unboxing:

T- he reference type is checked to ensure it holds a boxed value of the correct value type.

- The value is copied from the object (on the heap) to the value type variable (on the stack).

Example of Unboxing:

---------------------------------------------------------------------------------------------------------------------
int num = 42;           // Value type (stored on the stack)
object obj = num;        // Boxing: 'num' is boxed into an object
int unboxedNum = (int)obj; // Unboxing: 'obj' is unboxed back to an 'int'
Console.WriteLine(unboxedNum);  // Output: 42
---------------------------------------------------------------------------------------------------------------------

In this case, the object obj is unboxed back into an int. The value is extracted from the heap and placed on the stack.

-> Key Points:

Boxing:

Involves converting a value type to an object or reference type.

Value types (like int, double, struct, etc.) are boxed when assigned to an object or passed as object parameters.

A new object is created on the heap, and the value type is copied into it.

Unboxing:

Involves converting a reference type (an object) back into a value type.

The runtime ensures the object is actually a boxed value of the correct value type before unboxing.

If the type is incorrect, an InvalidCastException is thrown.

-> Performance Implications:

Boxing and unboxing are relatively expensive operations because they involve heap memory allocation (for boxing) and type-checking (for unboxing).

Excessive boxing and unboxing can impact performance, particularly in performance-critical applications or tight loops.

Avoid boxing and unboxing where possible by using generic types (e.g., List<int> instead of List<object>) and value types efficiently.

-> When Does Boxing and Unboxing Occur?

Boxing occurs when:

A value type is assigned to a variable of type object or an interface.

A value type is passed as a parameter to a method that accepts object.

Unboxing occurs when:

An object is cast back to its original value type.

-> Summary:

Boxing: Converts a value type to a reference type by allocating heap memory and storing the value type in it.

Unboxing: Extracts the value type from a reference type by copying it back to the stack.

While boxing/unboxing simplifies operations between value types and reference types, they can affect performance, and minimizing their use is recommended.
*/