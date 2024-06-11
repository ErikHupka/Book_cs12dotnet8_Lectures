

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
