using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; // For Binary Serialization
using System.Text.Json; // For JSON Serialization
using System.Xml.Serialization; // For XML Serialization

[Serializable] // Required for Binary and XML serialization
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Parameterless constructor required for XML serialization
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
        Person person = new Person("John Doe", 30);

        // Binary Serialization
        BinarySerialize(person);
        Person binaryDeserializedPerson = BinaryDeserialize();
        Console.WriteLine($"Binary Deserialized Person: Name = {binaryDeserializedPerson.Name}, Age = {binaryDeserializedPerson.Age}\n");

        // JSON Serialization
        string jsonString = JsonSerialize(person);
        Person jsonDeserializedPerson = JsonDeserialize(jsonString);
        Console.WriteLine($"JSON Deserialized Person: Name = {jsonDeserializedPerson.Name}, Age = {jsonDeserializedPerson.Age}\n");

        // XML Serialization
        XmlSerialize(person);
        Person xmlDeserializedPerson = XmlDeserialize();
        Console.WriteLine($"XML Deserialized Person: Name = {xmlDeserializedPerson.Name}, Age = {xmlDeserializedPerson.Age}");
    }

    // Binary Serialization Methods
    static void BinarySerialize(Person person)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream("person.dat", FileMode.Create))
        {
            formatter.Serialize(stream, person);
        }
        Console.WriteLine("Person object serialized to person.dat (Binary format)");
    }

    static Person BinaryDeserialize()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream("person.dat", FileMode.Open))
        {
            return (Person)formatter.Deserialize(stream);
        }
    }

    // JSON Serialization Methods
    static string JsonSerialize(Person person)
    {
        string jsonString = JsonSerializer.Serialize(person);
        Console.WriteLine($"Person object serialized to JSON: {jsonString}");
        return jsonString;
    }

    static Person JsonDeserialize(string jsonString)
    {
        return JsonSerializer.Deserialize<Person>(jsonString);
    }

    // XML Serialization Methods
    static void XmlSerialize(Person person)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
        using (StreamWriter writer = new StreamWriter("person.xml"))
        {
            xmlSerializer.Serialize(writer, person);
        }
        Console.WriteLine("Person object serialized to person.xml (XML format)");
    }

    static Person XmlDeserialize()
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
        using (StreamReader reader = new StreamReader("person.xml"))
        {
            return (Person)xmlSerializer.Deserialize(reader);
        }
    }
}
