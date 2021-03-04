namespace ConsoleAppExam
{
    public interface IAccount
    {
        decimal Balance { get; }

        void Deposite(decimal ammount);
        decimal withdraw(decimal ammount);
    }
}