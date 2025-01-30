namespace DNA_Payments;

public class BankAccountLogic
{
    public BankAccountDataAccess BankAccountDataAccess { get; }

    public BankAccountLogic()
    {
        BankAccountDataAccess = new BankAccountDataAccess();
    }
    public BankAccount GetAccount(string accountNumber)
    {
        return BankAccountDataAccess.GetAccount(accountNumber);
    }

    public BankAccount CreateAccount(string name, BankAccountType bankAccountType)
    {
        BankAccount bankAccount = new BankAccount(Guid.NewGuid(), CreateAccountNumber(), bankAccountType, name, false);
        BankAccountDataAccess.AddAccount(bankAccount);
        return bankAccount;
    }

    public BankAccount FreezeAccount(string accountNumber)
    {
        BankAccount bankAccount = BankAccountDataAccess.GetAccount(accountNumber);
        bankAccount.IsFrozen = true;
        BankAccountDataAccess.UpdateBankAccount(bankAccount);
        return bankAccount;
    }

    public BankAccount UnfreezeAccount(string accountNumber)
    {
        BankAccount bankAccount = BankAccountDataAccess.GetAccount(accountNumber);
        bankAccount.IsFrozen = false;
        BankAccountDataAccess.UpdateBankAccount(bankAccount);
        return bankAccount;
    }
    private string CreateAccountNumber()
    {
        return Guid.NewGuid().ToString();
    }
}