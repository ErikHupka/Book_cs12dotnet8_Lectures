using System.Xml.Serialization; // To use [XmlAttribute]
namespace Packt.Shared;

public class Person
{
    public Person() { } // A parameterless constructor is required for XML serialization.

    public Person(decimal initialSalary)
    {
        Salary = initialSalary;
    }

    [XmlAttribute(attributeName: "fname")]
    public string? FirstName { get; set; }
    [XmlAttribute(attributeName: "lname")]
    public string? LastName { get; set; }
    [XmlAttribute(attributeName: "dob")]
    public DateTime DateOfBirth { get; set; }
    public HashSet<Person>? Children { get; set; }
    protected decimal Salary { get; set; }
}