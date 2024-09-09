using System;

namespace BasicDataTypesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integral Types
            
            byte byteValue = 255;          // 8-bit unsigned integer
            sbyte sbyteValue = -128;       // 8-bit signed integer
            short shortValue = -32768;     // 16-bit signed integer
            ushort ushortValue = 65535;    // 16-bit unsigned integer
            int intValue = 2147483647;     // 32-bit signed integer
            uint uintValue = 4294967295;   // 32-bit unsigned integer
            long longValue = 9223372036854775807;  // 64-bit signed integer
            ulong ulongValue = 18446744073709551615; // 64-bit unsigned integer

            // Floating-Point Types

            float floatValue = 3.402823f;  // 32-bit single-precision floating point
            double doubleValue = 1.7976931348623157; // 64-bit double-precision floating point
            decimal decimalValue = 79228162514264337593543950335m; // 128-bit high-precision decimal

            // Character and Boolean Types

            char charValue = 'A';          // 16-bit Unicode character
            bool boolValue = true;         // Boolean value (true or false)

            // String Type

            string stringValue = "Hello, World!"; // String (sequence of characters)

            // Object Type (can hold any data type)

            object objectValue = 123;       // Boxed integer
            object objectStringValue = "This is a string in an object";

            // Enum Type

            DayOfWeek today = DayOfWeek.Wednesday; // Enum representing days of the week

            // Nullable Types

            int? nullableIntValue = null;  // Nullable integer

            // Output the values
            Console.WriteLine("Byte: " + byteValue);                              // Byte: 255
            Console.WriteLine("SByte: " + sbyteValue);                            // SByte: -128
            Console.WriteLine("Short: " + shortValue);                            // Short: -32768
            Console.WriteLine("UShort: " + ushortValue);                          // UShort: 65535
            Console.WriteLine("Int: " + intValue);                                // Int: 2147483647
            Console.WriteLine("UInt: " + uintValue);                              // UInt: 4294967295
            Console.WriteLine("Long: " + longValue);                              // Long: 9223372036854775807 
            Console.WriteLine("ULong: " + ulongValue);                            // ULong: 18446744073709551615

            Console.WriteLine("Float: " + floatValue);                            // Float: 3.402823
            Console.WriteLine("Double: " + doubleValue);                          // Double: 1.7976931348623157 
            Console.WriteLine("Decimal: " + decimalValue);                        // Decimal: 79228162514264337593543950335

            Console.WriteLine("Char: " + charValue);                              // Char: A
            Console.WriteLine("Boolean: " + boolValue);                           // Boolean: True

            Console.WriteLine("String: " + stringValue);                         // String: Hello, World!

            Console.WriteLine("Object holding an int: " + objectValue);          // Object holding an int: 123 
            Console.WriteLine("Object holding a string: " + objectStringValue);  // Object holding a string: This is a string in an object

            Console.WriteLine("Enum (Day of the Week): " + today);               // Enum (Day of the Week): Wednesday

            Console.WriteLine("Nullable Int: " + nullableIntValue);              // Nullable Int:

            Console.ReadLine(); // Wait for user to press Enter before closing
        }
    }
}
