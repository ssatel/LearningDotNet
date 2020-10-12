using System;

namespace AbstractClass.Entities
{
    abstract class Account
    {
        public int Number { get; set; }
        public String Holder { get; set; }
        public double Balance { get; set; }
        
        public Account()
        {

        }

        public Account(int number, string holder, double initialAmount)
        {
            Number = number;
            Holder = holder;
            this.DepositAmount(initialAmount);

        }


        public void WithdrawAmount (double amount)
        {
            Balance -= amount;
        }

        public void DepositAmount(double amount)
        {
            Balance += amount;
        }

    }
}
