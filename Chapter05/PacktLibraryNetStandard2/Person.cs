namespace Packt.Shared;

public partial class Person : object
{
    #region Fields: Data or state for this person.
    public string? Name; // ? means it can be null
    public DateTimeOffset Born;

    //public WondersOfTheAncientWorld FavoriteAncientWonder;   ---- Moved to the PersonAutoGen.cs

    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = [];
    public const string Species = "Homo Sapiens";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    #endregion

    #region Constructors: Called when using new to instantiate a type.
    public Person()
    {
        // Constructors can set default values for fields
        // including any readonly fields like Instantiated
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    #endregion

    #region Methods: Actions the type can perform.
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello'!";
    }

    public string SayHello(string name)
    {
        return $"{Name} says 'Hello, {name}";
    }

    public string OptionalParameters(
        int count,
        string command = "Run",
        double number = 0.0,
        bool active = true)
    {
        return $"command is {command}, number is {number}, active is {active}";
    }

    public void PassingParameters(int w, int x, ref int y, out int z)
    {
        z = 100;
        w++;
        y++;
        z++;
        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }

    // A method that returns a tuple: (string, int)
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    //Deconstructors: Break down this object into parts.
    public void Deconstruct(
        out string? name,
        out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(
        out string? name,
        out DateTimeOffset dob,
        out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }

    // Method with a local function.
    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(
                $"{nameof(number)} cannot be less than zero.");
        }

        return localFactorial(number);

        int localFactorial(int localNumber)
        {
            if (localNumber == 0) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }

    #endregion
}