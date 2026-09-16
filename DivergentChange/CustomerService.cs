namespace DivergentChange;

using System;
using System.Text.RegularExpressions;

public class CustomerService
{
    private readonly AccountService accountService = new AccountService();
    public EmailValidator EmailValidator { get; } = new EmailValidator();

    public string FormatDisplayName(string firstName, string lastName)
    {
        return firstName.Trim() + " " + lastName.Trim().ToUpper();
    }

    public int CalculateLoyaltyPoints(int numberOfPurchases)
    {
        return accountService.CalculateLoyaltyPoints(numberOfPurchases);
    }

    public string DetermineAccountStatus(int daysSinceLastLogin)
    {
        return accountService.DetermineAccountStatus(daysSinceLastLogin);
    }
}