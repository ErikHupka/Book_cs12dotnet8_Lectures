class Animal // This is the base type for all animals.
{
    public string? Name;
    public DateTime Born;
    public byte Legs;
}

class Cat:Animal
{
    public bool isDomestic;
}

class Spider:Animal
{
    public bool IsPoisonous;
}