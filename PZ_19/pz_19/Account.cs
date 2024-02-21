using System;
namespace pz_19
{
    using System;

    public class Account
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Holder { get; set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }

        public static bool operator ==(Account a, Account b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return a.AccountNumber == b.AccountNumber;
        }

        public static bool operator !=(Account a, Account b)
        {
            return !(a == b);
        }
    }
}
    


