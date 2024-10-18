/* Serialization 

-> What is stream of bytes?

Byte streams are a sequence of bytes used by programs to input and output information.

Serializable class cannot be inherited

Serialization is the process of converting an object into a stream of bytes to store the object or transmit it to memory, a database, or a file

It's main purpose is to save the state of an object in order to be able to recreate it when needed.

The reverse process is called "De-Serialization"

-> The general steps for serializing are

(i) Create an instance of File that will store the serialized object.

Create a stream from the file object.

Create an instance of Binary Formatter.

Call serialize method of the instance passing it stream and object to serialize.

- > How serialization works?

The object is serialized to a stream that carries the data.

The stream may also have information about the object's type, such as it's version, culture, and assembly name.

From the strea, the object can be stored in a database, a file, or memory.

-> Uses for Serialization

Serialization allows the developers to save the state of an object and re-create it as needed, providing storage of objects as well as data exchange.

Through serialization, a developer cna perform actions such as:

- Sending the object to a remote application by using a web service

- Passing an object form one domain to another

- Passing an object through a firewall as a JSON or XML string

- Maintaining securtiy or user-specific information across applications

-> Important points

If you want to make a class Serialize then you have to use [Serializable] attribute on top of your class.

If you have applied [Serializable] attribute to the class then taht class will not be inherited.

Namespace used for this purpose System.Runtime.Serialization.Formatters.Binary

We can serialize data in XML and JSON as well

-> Types of serialization

Serialization in Binary

Serialization in XML

Serialization in JSON

--------------------------------------------------------------------------------------------------------------------------

Serialization in C#

Serialization is the process of converting an object into a format that can be easily stored (like in a file or database) or transmitted (over a network). The serialized object can then be deserialized back into the original object. In C#, serialization is commonly used to save the state of an object, transmit data between different layers of an application, or communicate across services or networks.

-> Common Serialization Formats:

Binary Serialization: Converts objects into a binary format.

XML Serialization: Converts objects into XML format.

JSON Serialization: Converts objects into JSON format (common for web applications and APIs).

-> Key Concepts:

Serializable Class: For an object to be serializable, the class of the object must be marked with the [Serializable] attribute.

Deserialization: The process of converting the serialized data back into an object.

Non-Serializable Fields: If a field within a class should not be serialized, it can be marked with the [NonSerialized] attribute.

(i) Basic Example: Binary Serialization

Code:

---------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]  // This attribute makes the class serializable
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a new Person object
        Person person = new Person { Name = "John Doe", Age = 30 };

        // Serialize the object to a file
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream("person.dat", FileMode.Create))
        {
            formatter.Serialize(stream, person);
        }

        Console.WriteLine("Person object serialized to person.dat");

        // Deserialize the object from the file
        using (FileStream stream = new FileStream("person.dat", FileMode.Open))
        {
            Person deserializedPerson = (Person)formatter.Deserialize(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }
    }
}
---------------------------------------------------------------------------------------------------------------------

Explanation:

Serialization: The object person is serialized and written to a file person.dat. The BinaryFormatter.Serialize method performs the conversion of the object to a binary format.

Deserialization: The object is read from person.dat and deserialized back into a Person object. The BinaryFormatter.Deserialize method reconstructs the object from the file.

Output:

--------------------------------------------------------------------------------------------------------------------
Person object serialized to person.dat
Name: John Doe, Age: 30
--------------------------------------------------------------------------------------------------------------------

(ii) JSON Serialization Example (with System.Text.Json)

In modern C#, JSON serialization is very common, particularly for web APIs. Here's how you can use the System.Text.Json library to serialize and deserialize an object:

Code:

--------------------------------------------------------------------------------------------------------------------
using System;
using System.Text.Json;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a new Person object
        Person person = new Person { Name = "John Doe", Age = 30 };

        // Serialize the object to a JSON string
        string jsonString = JsonSerializer.Serialize(person);
        Console.WriteLine($"Serialized JSON: {jsonString}");

        // Deserialize the JSON string back into a Person object
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);
        Console.WriteLine($"Deserialized Person: Name = {deserializedPerson.Name}, Age = {deserializedPerson.Age}");
    }
}
---------------------------------------------------------------------------------------------------------------------

Explanation:

Serialization: JsonSerializer.Serialize(person) converts the Person object to a JSON string.

Deserialization: JsonSerializer.Deserialize<Person>(jsonString) converts the JSON string back into a Person object.

Output:

---------------------------------------------------------------------------------------------------------------------
Serialized JSON: {"Name":"John Doe","Age":30}
Deserialized Person: Name = John Doe, Age = 30
---------------------------------------------------------------------------------------------------------------------

(iii) XML Serialization Example (with System.Xml.Serialization)

XML serialization is also supported in C# for applications where XML is required.

Code:

---------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Person person = new Person { Name = "John Doe", Age = 30 };

        // Serialize to XML
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
        using (StringWriter textWriter = new StringWriter())
        {
            xmlSerializer.Serialize(textWriter, person);
            Console.WriteLine($"Serialized XML: {textWriter.ToString()}");
        }

        // Deserialize from XML
        string xmlData = @"<Person><Name>John Doe</Name><Age>30</Age></Person>";
        using (StringReader textReader = new StringReader(xmlData))
        {
            Person deserializedPerson = (Person)xmlSerializer.Deserialize(textReader);
            Console.WriteLine($"Deserialized Person: Name = {deserializedPerson.Name}, Age = {deserializedPerson.Age}");
        }
    }
}
---------------------------------------------------------------------------------------------------------------------

Explanation:

Serialization: The XmlSerializer.Serialize method converts the Person object into XML format.

Deserialization: The XmlSerializer.Deserialize method converts the XML string back into a Person object.

Output:

Serialized XML: <Person>
  <Name>John Doe</Name>
  <Age>30</Age>
</Person>
Deserialized Person: Name = John Doe, Age = 30

Summary:

Serialization: Converting an object to a format (binary, JSON, XML) for storage or transmission.

Deserialization: Converting the stored/transmitted format back into the original object.

C# supports binary, XML, and JSON serialization, with the JSON format being popular in web development.
Attributes like [Serializable] and [NonSerialized] control serialization behavior.

*/