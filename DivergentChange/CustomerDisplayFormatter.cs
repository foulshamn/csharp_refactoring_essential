namespace DivergentChange;

public class CustomerDisplayFormatter
{
    public string FormatDisplayName(string firstName, string lastName)
    {
        return firstName.Trim() + " " + lastName.Trim().ToUpper();
    }
}