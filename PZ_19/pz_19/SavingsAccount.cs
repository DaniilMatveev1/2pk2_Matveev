using System;
namespace pz_19
{
    using System;

    public class SavingsAccount : Account
    {
        public const decimal MinimumDepositAmount = 10000;
        public const decimal InterestRate = 0.1m;

        public DateTime StartTime { get; set; }

        public SavingsAccount(decimal balance, string holder)
        {
            if (balance >= MinimumDepositAmount)
            {
                Balance = balance;
            }
            else
            {
                throw new InvalidOperationException("Минимальная сумма депозита составляет " + MinimumDepositAmount);
            }

            Holder = holder;
            StartTime = DateTime.Now;
        }

        public decimal CalculateInterest()
        {
            TimeSpan timeElapsed = DateTime.Now - StartTime;
            int yearsElapsed = timeElapsed.Days / 365;

            decimal interestAmount = Balance * InterestRate * yearsElapsed;
            decimal totalAmount = Balance + interestAmount;

            return totalAmount;
        }

        public override void Withdraw(decimal amount)
        {
            decimal totalAmount = CalculateInterest();

            if (amount <= totalAmount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }
    }
}

