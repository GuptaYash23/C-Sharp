/* Enumeration (Enum)

Enum is a set of Constants.

An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).

Enum is short for "enumerations", which means "specifically listed".

To create an enum, use the enum keywor
(instead of class or interface), and seperate the enum items with a comma.

There  are built in enums and user defined enums

Example - Changing the console color of the output using Enum (ConsoleColor.Color_name) [ ConsoleColor Enum is provided by default ]

Code:

---------------------------------------------------------------------------------------------------------------------
static void Main(string[] args)
{
 Console.BackgroundColor = ConsoleColor.Yellow;
 Console.ForegroundColor = ConsoleColor.Red;
 Console.WriteLine("This is a customized output using ConsoleColor Enum");
}
---------------------------------------------------------------------------------------------------------------------

Example - Making an Custom Enum

Code:

---------------------------------------------------------------------------------------------------------------------
enum Days
{
 // Enum members are allocated Enum values

//  To start with a custom Enum value
// Sunday = 2, (Values will start from 2 and keep on incrementing by 1)
 
 Sunday,   // Value assigned = 0
 Monday,   // Value assigned = 1
 Tuesday,   // Value assigned = 2
 Wednesday,   // Value assigned = 3
 Thursday,   // Value assigned = 4
 Friday,   // Value assigned = 5
 Saturday   // Value assigned = 6
}

static void Main(string[] args)
{
 Console.WriteLine(Days.Sunday);  // Sunday

 Days birthday = Days.Monday;

 Console.WriteLine(birthday);  // Monday
}
---------------------------------------------------------------------------------------------------------------------

In C#, an enum (or enumaration type) is used to assign constant names to a group of numeric integer values.

It makes constand values more readable, for example, WeekDays.Monday is more readable then number 0 when referring to the day in a week.

An enum is defined using the enum keyword, directly instide a namespace, class, or structures. All the constant names can be declared inside the curly brackets and separated by a comma.

The default underlying type of an enum is int.

The default value for first element is ZERO and gets incremented by 1.

Enums are value types.

Enums are more readable and maintainable.

Enum is converted into abstract class behind the scenes.

If values are not assigned to enum members, then the compiler will assign integer values to each member starting with zero by default.

The first members of an enum will be 0, and the value of each successive enum members is increased by 1.

You can assign different values to enum member.

A change in the default value of an enum member will automatically assign incremental values to the other members sequentially.

If we assign a custom value to Enum members in between then the start values will start from 0 only and there will be difference from custom Enum member afterwhich value will be asssigned incrementally

For ex)

---------------------------------------------------------------------------------------------------------------------
enum Days
{
 Sunday,  // 0
 Monday,  // 1
 Tuesday = 5, // 5
 Wednesday, // 6
 Thursday, // 7
 Friday, // 8
 Saturday // 9
}
---------------------------------------------------------------------------------------------------------------------

-> Enum Conversion

Explicit casting is required to convert from an enum type to its underlying integral type.

For ex)

---------------------------------------------------------------------------------------------------------------------
enum Days
{
 Sunday,  
 Monday,  
 Tuesday = 5, 
 Wednesday, 
 Thursday, 
 Friday, 
 Saturday 
}

static void Main(string[] args)
{
  Days myDay = 1;  // C# won't be able to implicitly type cast Enum to int

  Days myDay = (Days)1;   // Explicitly converting 1 to Enum type

  Console.WriteLine(myDay);  // Monday

  myDay = (Days)0;

  Console.WriteLine(myDay);  // Sunday

  myDay = (Days)5;

  Console.WriteLine(myDay);  // Tuesday

  int value = (int) Days.Saturday;

  Console.WriteLine(value);  // 9

}
---------------------------------------------------------------------------------------------------------------------

Example: To Get Enum Names and Enum values into a string array

Code:

---------------------------------------------------------------------------------------------------------------------
enum Days
{
 Sunday,  
 Monday,  
 Tuesday, 
 Wednesday, 
 Thursday, 
 Friday, 
 Saturday 
}

static void Main(string[] args)
{
 string[] members = (string[])Enum.GetNames(typeof(Days));

 int[] values = (int[])Enum.GetValues(typeof(Days));

 foreach(string member in members)
 {
   Console.WriteLine(member);  // Sunday Monday ... Saturday
 }

 foreach(int value in values)
 {
   Console.WriteLine(value); // 0 1 ... 6
 }
}
---------------------------------------------------------------------------------------------------------------------

-> Why and when to use Enums?

Use enums when you have values that you know aren't going to change, like month days, days, colors etc.

-> Using Enum with switch

In C# switch can act upon enum values.

Example - Using Enums with Switch

Code:

---------------------------------------------------------------------------------------------------------------------
enum Days
{
 Sunday,  
 Monday,  
 Tuesday, 
 Wednesday, 
 Thursday, 
 Friday, 
 Saturday 
}

static void Main(string[] args)
{
 Days myDay = Days.Friday;

 switch(myDay)
 {
   case Days.Sunday:
        Console.WriteLine("This is Sunday");
        break;
    case Days.Monday:
        Console.WriteLine("This is Monday");
        break;
    case Days.Tuesday:
        Console.WriteLine("This is Tuesday");
        break;
    case Days.Wednesday:
        Console.WriteLine("This is Wednesday");
        break;
    case Days.Thursay:
        Console.WriteLine("This is Thursday");
        break;
    case Days.Friday:
        Console.WriteLine("This is Friday");
        break;
    case Days.Saturday:
        Console.WriteLine("This is Saturday");
        break;
    default:
        Console.WriteLine("This is an invalid day");
        break;
 }
}
---------------------------------------------------------------------------------------------------------------------

Output: 

This is Friday

---------------------------------------------------------------------------------------------------------------------


*/