namespace AbstractClass.Entities
{
    class BusinessAccount : Account
    {
        public double loanLimit { get; set; }

        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double initialAmount, double loanlimit)
            :base(number, holder, initialAmount) 
        {
            loanLimit = loanlimit;
        }
        
        public void Loan(double amount)
        {
            if (amount < loanLimit)
            {
                base.DepositAmount(amount);
            }
        }
    }
}
