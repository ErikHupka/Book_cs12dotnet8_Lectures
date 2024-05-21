#region Exploring unary operators
Console.WriteLine("Exploring unary operators");

int a = 3;
int b = a++;

WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c;

WriteLine($"a is {c}, b is {d}");

WriteLine();
#endregion

#region Exploring binary arithmetic operators
Console.WriteLine("Exploring binary arithmetic operators");

int e = 11;
int f = 3;

WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

WriteLine();
#endregion


#region Exploring logical operators
Console.WriteLine("Exploring logical operators");

bool p = true;
bool q = false;
WriteLine($"AND    | p    | q    ");
WriteLine($"p      | { p & p, -5}| { p & q, -5}");
WriteLine($"q      | { q & p, -5}| { q & q, -5}");
WriteLine($"OR     | p    | q    ");
WriteLine($"p      | {p | p,-5}| {p | q,-5}");
WriteLine($"q      | {q | p,-5}| {q | q,-5}"); 
WriteLine($"XOR    | p    | q    ");
WriteLine($"p      | {p ^ p,-5}| {p ^ q,-5}");
WriteLine($"q      | {q ^ p,-5}| {q ^ q,-5}");


WriteLine();
#endregion

#region Exploring conditional logical operators
Console.WriteLine("Exploring conditional logical operators");

static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;
}

WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");

WriteLine();
WriteLine($"p & DoStuff() = {p && DoStuff()}");
WriteLine($"q & DoStuff() = {q && DoStuff()}");

WriteLine();
#endregion

#region Exploring bitwise and binary shift operators
Console.WriteLine("Exploring bitwise and binary shift operators");

int x = 10;
int y = 6;
WriteLine($"Expression | Decimal |    Binary");
WriteLine($"----------------------------------");
WriteLine($"x          | {x,7} |  {x:B8}");
WriteLine($"y          | {y,7} |  {y:B8}");
WriteLine($"x & y      | {x & y,7} |  {x & y:B8}");
WriteLine($"x | y      | {x | y,7} |  {x | y:B8}");
WriteLine($"x ^ y      | {x ^ y,7} |  {x ^ y:B8}");

WriteLine();
// Left-shift x by three bit columns.
WriteLine($"x << 3     | {x << 3,7} | {x << 3:B8}");
WriteLine($"x * 3      | {x * 3,7} | {x * 3:B8}");
WriteLine($"x >> 3     | {x >> 3,7} | {x >> 3:B8}");

WriteLine();
#endregion