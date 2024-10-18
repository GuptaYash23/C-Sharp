/* IS vs AS keyword

1) IS keyword

'is' keyword is used to check the data type of an object.

'is' keyword checks whether the conversion from one object type to another object type is compatible or not.

It returns boolean

It returns true if the conversion is compatible, else returns false

Code:

---------------------------------------------------------------------------------------------------------------------
object a = "Yash";
object b = 23;

bool check = a is string; 
bool check2 = b is string;

Console.WriteLine(check); // true
Console.WriteLine(check2); // false
---------------------------------------------------------------------------------------------------------------------

2) AS keyword

In the development of the software, typecasting is a common thing. In many cases, developer need to convert a Type into another Type and sometimes he/she may get InvalidCastException. So, to overcome such types of exception C# provides "as" operator keyword.

'as' is a keyword used for conversion from one type to another. The type can be a reference or nullable.

'as' keyword checks the compatibility of one object type with another object type. In case of compatible, it will return the value of the new object type otherwise, null will be returned.

If the conversion from one type to another type fails, then it will return a null value instead of raising an exception. So, the return value can be null also.

Code:

---------------------------------------------------------------------------------------------------------------------
object a = "Yash";
object b = 23;

string str = a as string;
string str2 = b as string;  // Conversion failed so as will return null

Console.WriteLine(str);   // Yash
Console.WriteLine(str2);  // null
---------------------------------------------------------------------------------------------------------------------

-> Difference between IS and AS

The "is" operator is used to check if the run-time type of an object is compatible with the given type or not whereas "as" operator is used to perform conversion between compatible reference types or Nullable types.

The "is" operator is of boolean type whereas "as" operator is not of boolean type.

The "is" operator returns true if the given object is of the same type whereas "as" operator returns the object when they are compatible with the given type.

The "is" operators returns false if the given object is not of the same type whereas "as" operator return null if the conversion is not possible.

The "is" operator is used for only reference, boxing and unboxing conversions whereas "as" operator is used only for nullable, reference and boxing conversions.

*/