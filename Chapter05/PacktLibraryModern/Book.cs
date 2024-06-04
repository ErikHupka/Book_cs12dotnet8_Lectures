using System.Diagnostics.CodeAnalysis; // To use SetsRequiredMembers
namespace Packt.Shared;

public class Book
{
    public required string? Isbn;
    public required string? Title;
    public string? Author;
    public int PageCount;

    /// <summary>
    /// Constructor for use with object initializer syntax.
    /// </summary>
    public Book() { }

    /// <summary>
    /// Constructor with parameters to set required fields.
    /// </summary>
    /// <param name="isbn"></param>
    /// <param name="title"></param>
    [SetsRequiredMembers]
    public Book(string? isbn, string? title)
    {
        Isbn = isbn;
        Title = title;
    }
}