#region Working with single-dimensional arrays
WriteLine("Working with single-dimensional arrays");


string[] names; // This can reference any size array of strings.
// Allocate memory for four string in an array
names = new string[4];

// Store items at these index positions.
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";
//Loop through the names.

// Alternative syntax for creating and initializing an array.
string[] names2 = { "Kate", "Jack", "Rebecca", "Tom"};

for (int i = 0; i < names2.Length; i++)
{
    WriteLine($"{names2[i]} is at position {i}");
}

WriteLine();
#endregion

#region Working with multi-dimensional arrays
WriteLine("Working with multi-dimensional arrays");

string[,] grid1 =
{
    { "Aplha", "Beta", "Gamma", "Delta" },
    { "Anne", "Ben", "Charlie", "Doug" },
    { "Aardvark", "Bear", "Cat", "Dog" }
};

WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2st dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2st dimension, upper bound: {grid1.GetUpperBound(1)}");

WriteLine();

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int coll = 0; coll <= grid1.GetUpperBound(1); coll++)
    {
        WriteLine($"Row {row}, Column {coll}: {grid1[row, coll]}");
    }
}

WriteLine();
#endregion

#region Working with jagged arrays
WriteLine("Working with jagged arrays");

string[][] jagged = // An arrays of string arrays.
{
    ["Alpha", "Beta", "Gamma"],
    ["Anne", "Ben", "Charlie", "Doug"],
    ["Aardvark", "Bear"]
};

WriteLine("Upper bound of the array of arrays is: {0}", jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
    WriteLine("Upper bound of array {0} is: {1}",
        arg0: array,
        arg1: jagged[array].GetUpperBound(0));
}

WriteLine();

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
    for (int coll = 0; coll <= jagged[row].GetUpperBound(0); coll++)
    {
        WriteLine($"Row {row}, Column {coll}: {jagged[row][coll]}");
    }
}

WriteLine();
#endregion

#region List pattern matching with arrays
WriteLine("List pattern matching with arrays");

int[] sequentialNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] oneTwoNumbers = { 0, 1 };
int[] oneTwoTenNumbers = { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
int[] primerNumbers = { 0, 1, 2 };

WriteLine();
#endregion