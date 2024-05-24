#region Looping with the while statement
WriteLine("Looping with the while statement");

int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

WriteLine();
#endregion

#region Looping with the do statement
WriteLine("Looping with the do statement");

string? actualPassword = "Pa$$w0rd";
string? password;
//do
//{
//    Write("Enter your password: ");
//    password = ReadLine();
//}
//while (password != actualPassword);
//WriteLine("Correct");


WriteLine();
#endregion

#region Looping with the for statement
WriteLine("Looping with the for statement");

for (int y = 1; y <= 10; y++)
{
    Write($"{y} ");
}

WriteLine();

for (int y = 0; y <= 10; y += 3)
{
    Write($"{y} ");
}

WriteLine();
WriteLine();
#endregion

#region Looping with the foreach statement
WriteLine("Looping with the foreach statement");

string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters");
}

WriteLine();
#endregion