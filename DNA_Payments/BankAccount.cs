namespace DNA_Payments;

public enum BankAccountType
{
    Current = 1,
    Savings = 2,
}

public class BankAccount
{
    public Guid Id { get; }
    
    public string AccountNumber { get; }
    
    public BankAccountType BankAccountType { get; }
    
    public string Name { get; }
    
    public bool IsFrozen { get; set; }

    public BankAccount(Guid id, string accountNumber, BankAccountType bankAccountType, string name, bool isFrozen)
    {
        Id = id;
        AccountNumber = accountNumber;
        BankAccountType = bankAccountType;
        Name = name;
        IsFrozen = isFrozen;
    }
}