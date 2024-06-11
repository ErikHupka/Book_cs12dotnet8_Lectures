using Packt.Shared;
using System.Collections;
using System.Diagnostics;

ConfigureConsole();

#region Static methods and overloading operators
WriteLine("Static methods and overloading operators");
WriteLine();

Person harry = new()
{
    Name = "Harry",
    Born = new(
        year: 2001,
        month: 3,
        day: 25,
        hour: 0,
        minute: 0,
        second: 0,
        offset: TimeSpan.Zero)
};

harry.WriteToConsole();
harry.WriteChildrenToConsole();

//Implementing functionality using methods.
Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

//Call the instance method to marry Lamech and Adah.
lamech.Marry(adah);
//Call the static method to marry Lamech and Zillah.
//Person.Marry(lamech, zillah);
if (lamech + zillah)
{
    WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
}

lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();

//Call the instance method to make a baby.
Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

//Call the static method to make a baby
Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

Person baby3 = lamech * adah;
baby3.Name = "Jubal";
Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();

for (int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine($"{lamech.Name}'s child #{i} is named \" {lamech.Children[i].Name}\"");
}

WriteLine();
WriteLine("--------------------------------------------");
WriteLine();
#endregion

#region Making types safely reusable with generics
WriteLine("Making types safely reusable with generics");
WriteLine();

Hashtable lookupObject = [];
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2; //Look up the value that has 2 as its key.
WriteLine($"Key {key} has value: {lookupObject[key]}");

// Look up the value that has harry as its key
WriteLine($"Key {harry} has value: {lookupObject[harry]}");


// Define a generic lookup collection
Dictionary<int, string> lookupIntString = [];
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine($"Key {key} has value: {lookupIntString[key]}");


WriteLine();
WriteLine("--------------------------------------------");
WriteLine();
#endregion

#region Raising and handling events
WriteLine("Raising and handling events");
WriteLine();

//Assign the method to the Shout delegate
harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout_2;

// Call the Poke method that eventually raises the Shout event.
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

WriteLine();
WriteLine("--------------------------------------------");
WriteLine();
#endregion

#region Implementing interfaces
WriteLine("Implementing interfaces");
WriteLine();

Person?[] people =
{
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" },
};

OutputPeopleNames(people, "Initial list of people");
Array.Sort(people);
OutputPeopleNames(people, "After sorting using Person's IComparable implementation");

Array.Sort(people, new PersonComparer());
OutputPeopleNames(people, "After sorting using PersonCOmparer's IComparer implementation.");

WriteLine();
WriteLine("--------------------------------------------");
WriteLine();
#endregion

#region Managing memory with reference and value types
WriteLine("Managing memory with reference and value types");
WriteLine();

int a = 3;
int b = 3;

WriteLine($"a: {a}, b: {b}");
WriteLine($"a == b {a == b}");


Person p1 = new() { Name = "Kevin" };
Person p2 = new() { Name = "Kevin" };
WriteLine($"p1: {p1}, p2: {p2}");
WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
WriteLine($"p1 == p2: {p1 == p2}");

Person p3 = p1;
WriteLine($"p3: {p3}");
WriteLine($"p3.Name: {p3.Name}");
WriteLine($"p1 == p3: {p1 == p3}");

// string is the only class reference type implemented to act like a value type for equality.
WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
WriteLine($"p1.Name == p2.Name: {p1.Name == p2.Name}");

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;
WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

DisplacementVector dv4 = new();
WriteLine($"{dv4.X}, {dv4.Y}");

DisplacementVector dv5 = new(3, 5);
WriteLine($"dv1.Equals(dv5): {dv1.Equals(dv5)}");
WriteLine($"dv1 == dv5: {dv1 == dv5}");

// Inheriting from classes

Employee john = new()
{
    Name = "John Jones",
    Born = new(
        year: 1990,
        month: 7,
        day: 28,
        hour: 0,
        minute: 0,
        second: 0,
        offset: TimeSpan.Zero)
};

john.WriteToConsole();

john.EmployeeCode = "JJ001";
john.HireDate = new(
    year: 2014,
    month: 11,
    day: 23);
WriteLine($"{john.Name} was hired on {john.HireDate:yyyy-MM-dd}");

WriteLine(john.ToString());

Employee aliceInEmployee = new()
{
    Name = "Alice",
    EmployeeCode = "AA123"
};
Person aliceInPerson = aliceInEmployee;
aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();

WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());


if (aliceInPerson is  Employee explicitAlice)
{
    WriteLine($"{nameof(aliceInPerson)} is an Employee.");
    //Employee explicitAlice = (Employee)aliceInPerson;
    // Safely do something with explicitAlice.
}

Employee? aliceAsEmployee = aliceInPerson as Employee;
if (aliceAsEmployee is not null)
{
    WriteLine($"{nameof(aliceInPerson)} as an Eployee.");
    // Safely do something with aliceAsEmployee.
}

try
{
    john.TimeTravel(when: new(1999, 12, 31));
    john.TimeTravel(when: new(1950, 12, 25));
}
catch (PersonException ex)
{
    WriteLine(ex.Message);
}

string email1 = "pamela@test.com";
string email2 = "ian&test.com";

WriteLine($"{email1} is a valid e-mail address: {StringExtensions.IsValidEmail(email1)}");
WriteLine($"{email2} is a valid e-mail address: {StringExtensions.IsValidEmail(email2)}");

WriteLine($"{email1} is a valid e-mail address: {email1.IsValidEmail()}");
WriteLine($"{email2} is a valid e-mail address: {email2.IsValidEmail()}");


C1 c1 = new() { Name = "Bob" };
c1.Name = "Bill";
C2 c2 = new(Name: "Bob");
//c2.Name = "Bill"; // CS8852: Init-only property.
S1 s1 = new() { Name = "Bob" };
s1.Name = "Bill";
S2 s2 = new(Name: "Bob");
s2.Name = "Bill";
S3 s3 = new(Name: "Bob");
//s3.Name = "Bill"; // CS8852: Init-only property.

WriteLine();
WriteLine("--------------------------------------------");
WriteLine();
#endregion