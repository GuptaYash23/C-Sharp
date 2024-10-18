using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; // For Binary Deserialization
using System.Text.Json; // For JSON Deserialization
using System.Xml.Serialization; // For XML Deserialization

[Serializable]  // Required for Binary and XML serialization/deserialization
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Parameterless constructor required for XML deserialization
    public Person() { }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        // Deserialization from Binary
        Person binaryDeserializedPerson = BinaryDeserialize("person.dat");
        Console.WriteLine($"Binary Deserialized Person: Name = {binaryDeserializedPerson.Name}, Age = {binaryDeserializedPerson.Age}\n");

        // Deserialization from JSON
        string jsonString = "{\"Name\":\"John Doe\", \"Age\":30}"; // Example JSON string
        Person jsonDeserializedPerson = JsonDeserialize(jsonString);
        Console.WriteLine($"JSON Deserialized Person: Name = {jsonDeserializedPerson.Name}, Age = {jsonDeserializedPerson.Age}\n");

        // Deserialization from XML
        string xmlString = @"<Person><Name>Jane Doe</Name><Age>28</Age></Person>"; // Example XML string
        Person xmlDeserializedPerson = XmlDeserialize(xmlString);
        Console.WriteLine($"XML Deserialized Person: Name = {xmlDeserializedPerson.Name}, Age = {xmlDeserializedPerson.Age}");
    }

    // Binary Deserialization Method
    static Person BinaryDeserialize(string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream(filePath, FileMode.Open))
        {
            return (Person)formatter.Deserialize(stream);
        }
    }

    // JSON Deserialization Method
    static Person JsonDeserialize(string jsonString)
    {
        return JsonSerializer.Deserialize<Person>(jsonString);
    }

    // XML Deserialization Method
    static Person XmlDeserialize(string xmlString)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
        using (StringReader reader = new StringReader(xmlString))
        {
            return (Person)xmlSerializer.Deserialize(reader);
        }
    }
}
