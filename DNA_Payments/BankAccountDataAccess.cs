namespace DNA_Payments;

public static class BankAccountRepository
{
    public static List<BankAccount> AccountRepository { get; } = new List<BankAccount>();
}

public class BankAccountDataAccess
{
    public BankAccount GetAccount(string accountNumber)
    {
        return BankAccountRepository.AccountRepository.FirstOrDefault(x => x.AccountNumber == accountNumber);
    }
    
    public void AddAccount(BankAccount account)
    {
        BankAccountRepository.AccountRepository.Add(account);
    }

    public void UpdateBankAccount(BankAccount account)
    {
        int index = BankAccountRepository.AccountRepository.FindIndex(x => x.AccountNumber == account.AccountNumber);
        if (index < 0)
            return;
        BankAccountRepository.AccountRepository[index] = account;
    }
}