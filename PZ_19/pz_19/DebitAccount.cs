using System;
namespace pz_19
{
    using System;

    public class DebitAccount : Account
    {
        public override void Deposit(decimal amount)
        {
            if (amount >= 100)
            {
                base.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Минимальная сумма депозита 100");
            }
        }
    }
}
