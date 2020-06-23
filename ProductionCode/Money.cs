namespace ProductionCode
{
    public abstract class Money
    {
        protected internal int amount;
        
        public abstract Money Times(int multiplier);
        
        public override bool Equals(object? obj)
        {
            Money money = (Money) obj;
            return this.amount == money.amount && GetType() == money.GetType();
        }

        public static Money Dollar(int multiplier)
        {
            return new Dollar(multiplier);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }
    }
}