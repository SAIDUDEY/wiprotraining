interface IBankAccount
{
    public void Deposit(double number);

    public void WithDraw(double number);

    public void CheckBalance();

}

class SavingsAccount : IBankAccount
{
    public void Deposit(double amount)
    {
        Console.WriteLine($"the deposit amount {amount} rs in ur bank");
    }
    public void WithDraw(double amount)
    {
        Console.WriteLine($"the Withdraw amount  {amount} rs in ur bank");
    }

    public void CheckBalance()
    {

        Console.WriteLine($"the balance in ur bank");
    }

}
class CurrentAccount : IBankAccount
{
    public void Deposit(double amount)
    {
        Console.WriteLine($"the deposit amount {amount} rs in ur bank");
    }
    public void WithDraw(double amount)
    {
        Console.WriteLine($"the Withdraw amount  {amount} rs in ur bank");
    }

    public void CheckBalance()
    {

        Console.WriteLine($"the balance in ur bank");
    }

}

class Program
{ 
    static void Main()
    {
        IBankAccount account;

        account = new SavingsAccount();
        account.Deposit(144);
        account.WithDraw(166);
        account.CheckBalance();

        Console.WriteLine();

        account = new CurrentAccount();
        account.Deposit(133);
        account.WithDraw(551);
        account.CheckBalance();
    }
}