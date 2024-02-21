namespace pz_19;
using System;

class Program
{
    static void Main(string[] args)
    {
        Account account1 = new Account { AccountNumber = 1, Balance = 1000, Holder = "Джон" };
        Account account2 = new Account { AccountNumber = 2, Balance = 2000, Holder = "Джейн" };
        Account account3 = new Account { AccountNumber = 3, Balance = 3000, Holder = "Джо" };

        DebitAccount debitAccount1 = new DebitAccount { AccountNumber = 4, Balance = 4000, Holder = "Давид" };
        DebitAccount debitAccount2 = new DebitAccount { AccountNumber = 5, Balance = 5000, Holder = "Диана" };

        CreditAccount creditAccount1 = new CreditAccount { AccountNumber = 6, Balance = 6000, Holder = "Крис" };
        CreditAccount creditAccount2 = new CreditAccount { AccountNumber = 7, Balance = 7000, Holder = "Катя" };

        SavingsAccount savingsAccount1 = new SavingsAccount(10000, "Сэм");
        SavingsAccount savingsAccount2 = new SavingsAccount(20000, "Светлана");

        account1.Deposit(500);
        account1.Withdraw(200);

        debitAccount1.Deposit(50); // Minimum deposit amount is 100
        debitAccount1.Deposit(150);
        debitAccount1.Withdraw(100);

        creditAccount1.Deposit(600); // Minimum deposit amount is 6600
        creditAccount1.Deposit(6600);
        creditAccount1.Withdraw(700); // Remaining balance: 5900

        savingsAccount1.Deposit(1000);
        savingsAccount1.Withdraw(500); // Insufficient funds

        Console.WriteLine("Общий остаток сберегательного счета 1: " + savingsAccount1.CalculateInterest());

        if (account1 == account2)
        {
            Console.WriteLine("аккаунт 1 и аккаунт 2 равны");
        }
        else
        {
            Console.WriteLine("аккаунт 1 и аккаунт 2 не равны");
        }

        if (account1 == account1)
        {
            Console.WriteLine("аккаунт 1 и аккаунт 1 равны");
        }
        else
        {
            Console.WriteLine("аккаунт 1 и аккаунт 1 не равны");
        }
    }
}


