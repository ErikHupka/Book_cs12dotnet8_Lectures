using Packt.Shared;
using Packts.Shared;
using System.Diagnostics;
using Fruit = (string Name, int Number);

ConfigureConsole();

Person bob = new();
WriteLine(bob);

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965,
    month: 12,
    day: 22,
    hour: 16,
    minute: 28,
    second: 0,
    offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time.

WriteLine(format: "{0} was born on {1:D}.",
    arg0: bob.Name,
    arg1: bob.Born);

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0, TimeSpan.Zero)
};

WriteLine(format: "{0} was born on {1:d}.",
    arg0: alice.Name,
    arg1: alice.Born);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine($"{bob.Name}'s favorite wonder is {bob.FavoriteAncientWonder}. Its integer is {(int)bob.FavoriteAncientWonder}");

bob.BucketList =
    WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

bob.Children.Add(new() { Name = "Alfred" });
bob.Children.Add(new() { Name = "Bella" });
bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children.");
foreach (Person child in bob.Children)
{
    WriteLine($"> {child.Name}");
}

BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest");

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerries";
gerrierAccount.Balance = 98;
WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:C} interest");

WriteLine($"{bob.Name} is a {Person.Species}");

WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

//Book book = new()
//{
//    Isbn = "978-1803237800",
//    Title = "C# 12 and .Net 8 - Modern Cross-Platform Development Fundamentals"
//};

Book book = new(
    isbn: "978-1803237800",
    title: "C# 12 and .Net 8 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine($"{book.Isbn}: {book.Title} written by {book.Author} has {book.PageCount:N0} pages.");

Person blankPerson = new();
WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on a {blankPerson.Instantiated:dddd}");

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine($"{gunny.Name} of {gunny.HomePlanet} was created at {gunny.Instantiated:hh:mm:ss} on a {gunny.Instantiated:dddd}");


bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));

WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3, "Jump", 98.5));

WriteLine(bob.OptionalParameters(3, number: 52.7, command: "Hide"));

int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After a={a}, b={b}, c={c}, d={d}");

int e = 50;
int f = 60;
int g = 70;
WriteLine($"Before e={e}, f={f}, g={g}, h doesn't exist yet!");
bob.PassingParameters(e, f, ref g, out int h);
WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1},{fruit.Item2} there are.");

Fruit fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Name} {fruitNamed.Number}");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed tuple: {fruitName}, {fruitNumber}");

var (name1, dob1) = bob;
WriteLine($"Deconstructed person: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

int number = -1;

try
{
    WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}");
}

Person sam = new()
{
    Name = "Sam",
    Born = new(
        year: 1969,
        month: 6, 
        day: 25, 
        hour: 0, 
        minute: 0,
        second: 0, TimeSpan.Zero)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}");

string color = "blue";
try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's faovrite primary color is {sam.FavoritePrimaryColor}.");
}
catch (Exception ex)
{
    WriteLine($"Tried to set {nameof(sam.FavoritePrimaryColor)} to {color}: {ex.Message}");
}

try
{
    bob.FavoriteAncientWonder =
    WondersOfTheAncientWorld.StatueOfZeusAtOlympia |
    WondersOfTheAncientWorld.GreatPyramidOfGiza;
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} : {ex.Message}");
}

sam.Children.Add(new(){ Name = "Charlie", Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero)});
sam.Children.Add(new() { Name = "Ella", Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero) });

WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");

WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old");

// An array containing a mix of passenger types.
Passenger[] passengers = {
  new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
  new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
  new BusinessClassPassenger { Name = "Janice" },
  new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
  new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" },
};
foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        // C# 8 syntax
        //FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
        //FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
        //FirstClassPassenger _ => 2_000M,

        //C# 9 or later syntax
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35_000 => 1_500M,
            > 15_000 => 1_750M,
            _ => 2_000M
        },
        BusinessClassPassenger _ => 1_000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};
WriteLine($"{jeff.FirstName} {jeff.LastName}");


ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
};