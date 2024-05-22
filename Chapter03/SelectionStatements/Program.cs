﻿#region Branching with the if statement
WriteLine("Branching with the if statement");

string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 chars.");
}
else
{
    WriteLine($"Your password is strong");
}

WriteLine();
#endregion

#region Pattern matching with the if statement
WriteLine("Pattern matching with the if statement");

object o = 3;
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i*j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}

WriteLine();
#endregion

#region Branching with the switch statement
WriteLine("Branching with the switch statement");

// Inclusive lower bound but exclusive upper bound.
int number = Random.Shared.Next(minValue: 1, maxValue: 7);
WriteLine($"My random number is {number}");

switch(number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
} // End of switch statement

WriteLine("After end of switch");
A_label:
    WriteLine("After A_label");

WriteLine();
#endregion