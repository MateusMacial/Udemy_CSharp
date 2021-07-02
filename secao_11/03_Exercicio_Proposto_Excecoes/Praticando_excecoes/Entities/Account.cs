using Praticando_excecoes.Entities.DomainExceptions;

namespace Praticando_excecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }
        public void Withdraw(double value)
        {
            if(value > WithdrawLimit)
            {
                throw new DomainException("The value to Withdraw is biger than the Withdraw limit!!!");
            }
            else if(value > Balance)
            {
                throw new DomainException("The value is bigger than the balance in you acount!!!");
            }
            Balance -= value;
        }
    }
}
