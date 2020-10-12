namespace AbstractClass.Entities
{
    class SavingsAccount : Account
    {
        
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double initialamount, double interestrate) : base(number, holder, initialamount)
        {
            InterestRate = interestrate;

        }


        public void UpdateBalance(double amount)
        {
            base.DepositAmount(amount);
        }

    }
}
