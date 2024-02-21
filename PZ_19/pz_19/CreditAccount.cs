using System;
namespace pz_19
{
    using System;

    public class CreditAccount : Account
    {
        public override void Deposit(decimal amount)
        {
            decimal minimumDepositAmount = Balance + (Balance * 0.1m);

            if (amount >= minimumDepositAmount)
            {
                base.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Минимальная сумма депозита составляет" + minimumDepositAmount);
            }
        }

        public override void Withdraw(decimal amount)
        {
            decimal withdrawalAmount = amount + (amount * 0.1m);

            if (withdrawalAmount <= Balance)
            {
                Balance -= withdrawalAmount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }
    }
}

