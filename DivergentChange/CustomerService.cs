using System.Text.RegularExpressions;

namespace DivergentChange;

public class CustomerService
{
    private readonly AccountService _accountService = new();
    private readonly EmailValidator _emailValidator = new();

    public bool IsValidEmail(string email)
    {
        return _emailValidator.IsValidEmail(email);
    }

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