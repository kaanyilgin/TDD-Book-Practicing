namespace ProductionCode
{
    public class Money
    {
        protected internal int amount;

        public override bool Equals(object? obj)
        {
            Money money = (Money) obj;
            return this.amount == money.amount;
        }
    }
}