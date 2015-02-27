using System;

class SavingsAccount : BankAccountProtected
{
    protected override void ApplyPenalties()
    {
        Console.WriteLine("Savings Account Applying Penalties");
    }

    protected override void CalculateFinalInterest()
    {
        Console.WriteLine("Savings Account Calculating Final Interest");
    }

    protected override void DeleteAccountFromDB()
    {
        base.DeleteAccountFromDB();
        Console.WriteLine("Savings Account Deleting from DB");
    }
}