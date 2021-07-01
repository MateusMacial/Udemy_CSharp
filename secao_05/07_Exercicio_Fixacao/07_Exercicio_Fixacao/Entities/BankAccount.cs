using System.Globalization;

namespace _07_Exercicio_Fixacao.Entities
{
    class BankAccount
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public BankAccount(int number, string holder)
        {
            Number = number;
            Holder = holder;
            Balance = 0.0;
        }

        public void Withdraw(double amount)
        {
            Balance -= (amount + 5);
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return "Conta "
                + Number
                + ", Titular: "
                + Holder
                + ", Saldo: $"
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
