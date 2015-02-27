using System;

class CheckingAccount : BankAccountProtected
{
    protected override void ApplyPenalties()
    {
        Console.WriteLine("Checking Account Applying Penalties");
    }

    protected override void CalculateFinalInterest()
    {
        Console.WriteLine("Checking Account Calculating Final Interest");
    }

    protected override void DeleteAccountFromDB()
    {
        base.DeleteAccountFromDB();
        Console.WriteLine("Checking Account Deleting Account from DB");
    }
}