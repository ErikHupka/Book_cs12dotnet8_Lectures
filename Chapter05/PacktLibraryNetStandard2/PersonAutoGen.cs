﻿namespace Packt.Shared;

public partial class Person
{
    #region Properties: Methods to get and/or set data or state.

    // A readonly property defined using C# 1 to 5 syntax
    public string Origin => $"{Name} was born on {HomePlanet}";

    // Two readonly properties defined using C# 6 or later
    // lambda expression body syntax

    public string Greeting => $"{Name} says 'Hello'";
    public int Age => DateTime.Today.Year - Born.Year;

    public string? FavoriteIceCream {  get; set; }
    //A private backing field to store the property value.
    private string? _favoritePrimaryColor;

    public string? FavoritePrimaryColor
    {
        get
        {
            return _favoritePrimaryColor;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    _favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, green, blue");
            }
        }
    }

    private WondersOfTheAncientWorld _favoriteAncientWonder;
    public WondersOfTheAncientWorld FavoriteAncientWonder
    {
        get { return _favoriteAncientWonder; }
        set
        {
            string wonderName = value.ToString();
            if (wonderName.Contains(","))
            {
                throw new ArgumentException(
                    message: "Favorite ancient wonder can onlz have a single enum value",
                    paramName: nameof(FavoriteAncientWonder));
            }

            if (!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value))
            {
                throw new ArgumentException(
                    $"{value} is not a member of the WondersOfTheAncientWorld enum.",
                    paramName: nameof(FavoriteAncientWonder));
            }
            _favoriteAncientWonder = value;

        }
    }

    #endregion

    #region Indexers: Properties that use array syntax to access them.

    public Person this[int index]
    {
        get
        {
            return Children[index];
        }
        set
        {
            Children[index] = value;
        }
    }

    public Person this[string name]
    {
        get
        {
            return Children.Find(p => p.Name == name);
        }
    }

    #endregion
}