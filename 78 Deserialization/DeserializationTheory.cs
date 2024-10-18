/* Deserialization in C# 

-> What is stream of bytes?

Byte streams are sequence of bytes used by program to input and output information

-> What is Deserialization in C#?

As the name suggests, deserializtion in C# is the reverse process of serialization.

Deserialization is the opposing process which takes data from a file, stream or network and rebuilds it into an object.

It resurrects the state of the object by setting properties, fields etc.

---------------------------------------------------------------------------------------------------------------------

Deserialization in C#

Deserialization is the process of converting serialized data (such as a string, file, or byte stream) back into an object. It is the reverse of serialization, where an object is converted into a format suitable for storage or transmission. In C#, deserialization allows you to reconstruct an object that was previously serialized, whether it's in binary, JSON, or XML format.

Types of Deserialization:

Binary Deserialization: Reconstructs an object from binary data.

JSON Deserialization: Reconstructs an object from a JSON string.

XML Deserialization: Reconstructs an object from XML data.

1. Binary Deserialization

For binary deserialization, the serialized binary data (such as a file or memory stream) is converted back into the original object. The BinaryFormatter class is used for binary deserialization.

Example:

---------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable] // Class must be marked as serializable
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Deserializing a person object from a binary file
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream("person.dat", FileMode.Open))
        {
            Person deserializedPerson = (Person)formatter.Deserialize(stream);
            Console.WriteLine($"Deserialized Person: Name = {deserializedPerson.Name}, Age = {deserializedPerson.Age}");
        }
    }
}
---------------------------------------------------------------------------------------------------------------------

Explanation:

The BinaryFormatter.Deserialize method reads from the person.dat file and reconstructs the Person object.

The object is then accessed as it was before serialization.

2. JSON Deserialization

In modern C#, JSON is commonly used for data exchange in web applications, APIs, and other network communication.

The System.Text.Json library allows easy deserialization from JSON strings into objects.

Example:

---------------------------------------------------------------------------------------------------------------------
using System;
using System.Text.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        string jsonString = "{\"Name\":\"John Doe\", \"Age\":30}";

        // Deserializing JSON string to Person object
        Person person = JsonSerializer.Deserialize<Person>(jsonString);

        Console.WriteLine($"Deserialized Person: Name = {person.Name}, Age = {person.Age}");
    }
}
---------------------------------------------------------------------------------------------------------------------

Explanation:

The JsonSerializer.Deserialize<T> method converts the JSON string into a Person object. The object is fully reconstructed and its properties can be accessed normally.

3. XML Deserialization

The System.Xml.Serialization.XmlSerializer class is used to deserialize XML data into an object. This is particularly useful in applications that work with XML for configuration, data storage, or data exchange.

Example:

}
---------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Xml.Serialization;

[Serializable]  // Required for serialization and deserialization
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person() { } // Parameterless constructor required for XML deserialization
}

class Program
{
    static void Main()
    {
        string xmlData = @"<Person><Name>John Doe</Name><Age>30</Age></Person>";

        // Deserializing XML string to Person object
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
        using (StringReader reader = new StringReader(xmlData))
        {
            Person person = (Person)xmlSerializer.Deserialize(reader);
            Console.WriteLine($"Deserialized Person: Name = {person.Name}, Age = {person.Age}");
        }
    }
}
}
---------------------------------------------------------------------------------------------------------------------

Explanation:

The XmlSerializer.Deserialize method reads the XML data and reconstructs the Person object.

The object can then be used like any normal instance.

Key Differences Between Serialization Formats

Binary: More compact and faster but not human-readable. Best for storing object state internally or across trusted environments.

JSON: Human-readable, widely used for web APIs and network communication. Ideal for interoperability.

XML: Human-readable, schema-friendly, and often used in configuration files or enterprise applications where strict data formats are required.

Common Use Cases for Deserialization:

Reading Data: Deserialization is often used to read data stored in files (e.g., configuration, state persistence) and reconstruct objects from that data.

Data Exchange: When communicating between services (e.g., via JSON or XML web services), deserialization is used to convert received data into usable objects.

State Restoration: Deserialization can be used to restore an application's state after it was previously saved (e.g., in a game or long-running process).

Summary:

Deserialization is the process of converting a serialized format (binary, JSON, XML) back into a usable object.

It is commonly used in scenarios involving data persistence, web services, and state restoration.

C# provides easy-to-use libraries for deserialization: BinaryFormatter for binary, JsonSerializer for JSON, and XmlSerializer for XML.

*/