using Packt.Shared;
using System.Collections;

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