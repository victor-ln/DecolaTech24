namespace Encapsulation.Models
{
    public class CheckingAccount
    {
        public CheckingAccount(int accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            _balance = initialBalance;
        }

        public int AccountNumber { get; }
        private decimal _balance;

        public void Withdraw(decimal amount)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine("Withdrawal successful");
            }
            else
            {
                Console.WriteLine("Requested amount exceeds the available balance");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Your available balance is: {_balance}");
        }
    }
}