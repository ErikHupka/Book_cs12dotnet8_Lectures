﻿using System.Diagnostics;
using System.Text.RegularExpressions; // To use Regex.

Write(value: "Enter your age: ");
//string input = ReadLine()!; // Null-forgiving operator.
Regex ageChecker = new(pattern: DigitsOnlyText);
//WriteLine(ageChecker.IsMatch(input) ? "Thank you!" : $"This is not a valid age: {input}");


// Splitting a complex comma-separated string
// C# 1 to 10: Use escaped double-quote characters \"
// string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
// C# 11 or later: Use """ to start and end a raw string literal
string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";
WriteLine($"Films to split: {films}");
string[] filmsDumb = films.Split(',');
WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
    WriteLine($"  {film}");
}

Regex csv = new(pattern: CommaSeparatorText);
MatchCollection filmsSmart = csv.Matches(films);
WriteLine("Splitting with regular expression:");
foreach (Match film in filmsSmart)
{
    WriteLine(value: $"{film}");
}