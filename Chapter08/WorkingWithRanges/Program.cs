string name = "Samantha Jones";
//Getting the lengths of the first and last names
int lengthOfFirst = name.IndexOf(value: ' ');
int lengthOfLast = name.Length - lengthOfFirst - 1;

// Using Substring
string firstName = name.Substring(
    startIndex: 0,
    length: lengthOfFirst);
string lastName = name.Substring(
    startIndex: name.Length - lengthOfLast,
    length: lengthOfLast);
WriteLine(value: $"First: {firstName}, Last: {lastName}");
//Using Spans
ReadOnlySpan<char> nameAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = nameAsSpan[0..lengthOfFirst];
ReadOnlySpan<char> lastNameSpan = nameAsSpan[^lengthOfLast..];
WriteLine(value: $"First: {firstNameSpan}, Last: {lastNameSpan}");