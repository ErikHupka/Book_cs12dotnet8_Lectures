using System.Xml;

#region Storing any type of object

object height = 1.88; //Storing a double in an object.
object name = "Amir"; //Storing a string in an object.

Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length(); //Thsi give a compile error!
int length2 = ((string)name).Length; // Cast name to a string.

Console.WriteLine($"{name} has {length2} characters.");

Console.WriteLine();

#endregion

#region Storing dynamic types

dynamic something;
// Storing an array of int values in a dynamics object.
// An array of any type has a Length property.
something = new[] { 3, 5, 7 };
// Storing an int in a dynamic object.
// int does not have a Length property.
something = 12;
something = "Ahmed";
Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"something is a {something.GetType()}");

Console.WriteLine();

#endregion

#region Declaring local variables

var population = 67_000_000;
var weight = 1.88;
var price = 4.99M;
var fruit = "Apples";
var letter = "Z";
var happy = true;

// Good use of var because it avoid the repeated type as shown in the more verbose second statement.
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

//Bad use of var because we cannot tell the type, so we should use a specific type declaration as shown in the second statement.
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

Console.WriteLine();

#endregion

#region Getting and setting the default values for types

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number set to: {number}");

number = default;
Console.WriteLine($"number reset to its default: {number}");

#endregion