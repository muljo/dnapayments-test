namespace DNA_Payments;

public enum BankAccountType
{
    Current = 1,
    Savings = 2,
}

public class BankAccount
{
    public Guid Id { get;}
    
    public BankAccountType BankAccountType { get; }
    
    public string Name { get; }
    
    public bool IsFrozen { get; }

    public BankAccount(Guid id, BankAccountType bankAccountType, string name, bool isFrozen)
    {
        Id = id;
        BankAccountType = bankAccountType;
        Name = name;
        IsFrozen = isFrozen;
    }
}