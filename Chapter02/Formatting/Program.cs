#region Formatting using numbered positional arguments

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple);
//WriteToFile(formatted);

WriteLine("{0} {1} lived in {2}.",
    arg0: "Roger",
    arg1: "Cevung",
    arg2: "Stockhold");

WriteLine(
    "{0} {1} lived in {2} and worked in the {3} team at {4}.",
    "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

WriteLine();

#endregion

#region Formatting using interpolated strings

WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

#endregion

#region Understanding format strings

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
WriteLine();
WriteLine(
    format: "{0, -10} {1, 6}",
    arg0: "Name",
    arg1: "Count");
WriteLine(
    format: "{0, -10} {1, 6:N0}",
    arg0: applesText,
    arg1: applesCount);
WriteLine(
    format: "{0, -10} {1, 6:N0}",
    arg0: bananasText,
    arg1: bananasCount);

WriteLine();

#endregion

#region Getting text input from the user

Write("Type your first name and press ENTER: ");
string ? firstName = ReadLine();

Write("Type eyour age and press ENTER: ");
string age = ReadLine()!;

WriteLine($"Hello {firstName}, you look good for {age}."); 

#endregion