using System.Diagnostics;
using StringDictionary = System.Collections.Generic.Dictionary<string, string>;
using System.Collections.Immutable; // To use ImmutableDictionary <T, T>
using System.Collections.Frozen; // To use FrozenDictionary<T, T>

// Simple syntax for creating a list and adding three items.
// Lists
List<string> cities = new();
cities.Add(item: "London");
cities.Add(item: "Paris");
cities.Add(item: "Milan");

OutputCollection(title: "Initial list", cities);
WriteLine($"The first city is {cities[0]}");
WriteLine($"The last city is {cities[cities.Count - 1]}");
cities.Insert(0, item: "Sydney");

OutputCollection("After inseting Sydney at index 0", cities);
cities.RemoveAt(1);
cities.Remove(item: "Milan");
OutputCollection(title: "After removing two cities", cities);


// Dictionary

// Declare a dictionary without the alias.
// Dictionary<string, string> keywords = new();
// Use the alias to declare the dictionary.
StringDictionary keywords = new();
// Add using named parameters.
keywords.Add(key: "int", value: "32-bit integer data type");
// Add using positional parameters.
keywords.Add("long", "64-bit integer data type");
keywords.Add("float", "Single precision floating point number");
/* Alternative syntax; compiler converts this to calls to Add method.
Dictionary<string, string> keywords = new()
{
  { "int", "32-bit integer data type" },
  { "long", "64-bit integer data type" },
  { "float", "Single precision floating point number" },
}; */
/* Alternative syntax; compiler converts this to calls to Add method.
Dictionary<string, string> keywords = new()
{
  ["int"] = "32-bit integer data type",
  ["long"] = "64-bit integer data type",
  ["float"] = "Single precision floating point number",
}; */
OutputCollection("Dictionary keys", keywords.Keys);
OutputCollection("Dictionary values", keywords.Values);
WriteLine("Keywords and their definitions:");
foreach (KeyValuePair<string, string> item in keywords)
{
    WriteLine($"  {item.Key}: {item.Value}");
}
// Look up a value using a key.
string key = "long";
WriteLine($"The definition of {key} is {keywords[key]}.");


// Sets, stacks, and queues
HashSet<string> names = new();
foreach (string name in
  new[] { "Adam", "Barry", "Charlie", "Barry" })
{
    bool added = names.Add(name);
    WriteLine($"{name} was added: {added}.");
}
WriteLine($"names set: {string.Join(',', names)}.");


Queue<string> coffee = new();
coffee.Enqueue("Damir"); // Front of the queue.
coffee.Enqueue("Andrea");
coffee.Enqueue("Ronald");
coffee.Enqueue("Amin");
coffee.Enqueue("Irina"); // Back of the queue.
OutputCollection("Initial queue from front to back", coffee);
// Server handles next person in queue.
string served = coffee.Dequeue();
WriteLine($"Served: {served}.");
// Server handles next person in queue.
served = coffee.Dequeue();
WriteLine($"Served: {served}.");
OutputCollection("Current queue from front to back", coffee);
WriteLine($"{coffee.Peek()} is next in line.");
OutputCollection("Current queue from front to back", coffee);


PriorityQueue<string, int> vaccine = new();
// Add some people.
// 1 = High priority people in their 70s or poor health.
// 2 = Medium priority e.g. middle-aged.
// 3 = Low priority e.g. teens and twenties.
vaccine.Enqueue("Pamela", 1);
vaccine.Enqueue("Rebecca", 3);
vaccine.Enqueue("Juliet", 2);
vaccine.Enqueue("Ian", 1);
OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);
WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);
WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
WriteLine("Adding Mark to queue with priority 2.");
vaccine.Enqueue("Mark", 2);
WriteLine($"{vaccine.Peek()} will be next to be vaccinated.");
OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);


// Dictionary
UseDictionary(keywords);
//UseDictionary(keywords.AsReadOnly());
UseDictionary(keywords.ToImmutableDictionary());

ImmutableDictionary<string, string> immutableKeywords =
    keywords.ToImmutableDictionary();
// Call the Add method with a return value.
ImmutableDictionary<string, string> newDictionary =
    immutableKeywords.Add(
        key: Guid.NewGuid().ToString(),
        value: Guid.NewGuid().ToString());
OutputCollection(title: "Immutable keywords dictionary", immutableKeywords);
OutputCollection(title: "New keywords dictionary", newDictionary);

WriteLine();
// Frozen Collections

//Creating a frozen collection has an overhead to perform the sometimes complex optimizations.
FrozenDictionary<string, string> frozenKeywords =
    keywords.ToFrozenDictionary();
OutputCollection(title: "Frozen keywords dictionary", frozenKeywords);
//Lookups are faster in a frozen dictionary
WriteLine(value: $"Define long: {frozenKeywords[key: "long"]}.");