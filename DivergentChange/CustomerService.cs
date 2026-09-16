namespace DivergentChange;

public class CustomerService
{
    private readonly AccountService _accountService = new AccountService();
    public EmailValidator EmailValidator { get; } = new();

    public string FormatDisplayName(string firstName, string lastName)
    {
        return firstName.Trim() + " " + lastName.Trim().ToUpper();
    }

    public int CalculateLoyaltyPoints(int numberOfPurchases)
    {
        return _accountService.CalculateLoyaltyPoints(numberOfPurchases);
    }

    public string DetermineAccountStatus(int daysSinceLastLogin)
    {
        return _accountService.DetermineAccountStatus(daysSinceLastLogin);
    }
}