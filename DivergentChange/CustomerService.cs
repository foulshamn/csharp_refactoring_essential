using System.Text.RegularExpressions;

namespace DivergentChange;

public class CustomerService
{
    private readonly AccountService _accountService = new AccountService();

    public bool IsValidEmail(string email)
    {
        if (email == null)
        {
            return false;
        }

        return Regex.IsMatch(
            email,
            @"^[A-Za-z0-9+_.-]+@[A-Za-z0-9.-]+$");
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