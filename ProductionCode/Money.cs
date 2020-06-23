namespace ProductionCode
{
    public abstract class Money
    {
        protected internal int amount;
        protected string currency;
        
        public override bool Equals(object? obj)
        {
            Money money = (Money) obj;
            return this.amount == money.amount && GetType() == money.GetType();
        }

        public static Money Dollar(int multiplier)
        {
            return new Dollar(multiplier, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }
        
        public string Currency()
        {
            return this.currency;
        }
        
        public abstract Money Times(int multiplier);
    }
}