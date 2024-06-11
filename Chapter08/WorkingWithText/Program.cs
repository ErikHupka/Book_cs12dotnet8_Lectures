using System.Globalization;

OutputEncoding = System.Text.Encoding.UTF8;

string city = "London";
WriteLine($"{city} is {city.Length} characters long.");
WriteLine($"First char is {city[0]} and fourth is {city[3]}");

string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellin";
string[] citiesArray = cities.Split(',');
WriteLine($"There are {citiesArray.Length} items in the array:");
foreach (string item in citiesArray)
{
    WriteLine($"{item}");
}

string fullName = "Alan Shore";
int indexOfTheSpace = fullName.IndexOf(" ");
string firstName = fullName.Substring(
    startIndex: 0,
    indexOfTheSpace);
string lastName = fullName.Substring(
    startIndex: indexOfTheSpace + 1
    );
WriteLine($"Origina: {fullName}");
WriteLine($"Swapped: {lastName}, {firstName}");

string company = "Microsoft";
WriteLine($"Text: {company}");
WriteLine($"Starts with M: {company.StartsWith(value: 'M')}, contains an N: {company.Contains(value: 'N')}");

WriteLine();
// Comparing strings
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(name: "en-Us");
string text1 = "Mark";
string text2 = "MARK";
WriteLine($"text1: {text1}, text2: {text2}");
WriteLine($"Compare: {string.Compare(text1, text2)}");
WriteLine($"Compare (ignore case): {string.Compare(text1, text2, ignoreCase: true)}");
WriteLine($"Compare (InvariantCultureIgnoreCase): {string.Compare(text1, text2, StringComparison.InvariantCultureIgnoreCase)}");


WriteLine();

// Joining, formatting, and other string members
string recombined = string.Join(separator: " => ", citiesArray);
WriteLine(recombined);