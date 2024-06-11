namespace Packt.Shared;

public class PersonComparer : IComparer<Person?>
{
    public int Compare(Person? x, Person? y)
    {
        int position;
        if ((x is not null) && (y.Name is not null))
        {
            if ((x.Name is not null) && (y.Name is not null))
            {
                // If both Name values are not null then comapre the Name lengths
                int result = x.Name.Length.CompareTo(y.Name.Length);
                // ...and in they are equal
                if (result == 0)
                {
                    return x.Name.CompareTo(y.Name);
                }
                else
                {
                    position = result;
                }
            }
            else if ((x.Name is not null) && (y.Name is null))
            {
                position = -1;
            }
            else if ((x.Name is null) && (y.Name is not null))
            {
                position = 1;
            }
            else //x.Name and y.Name are both null
            {
                position = 0;
            }
        }
        else if ((x is not null) && (y is null))
        {
            position = -1; // x Person precedes y Person
        }
        else if ((x is null) && (y is not null))
        {
            position = 1;
        }
        else // x and y are both null
        {
            position = 0;
        }
        return position;
    }
}