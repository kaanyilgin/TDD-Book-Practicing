namespace ProductionCode
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(this.amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            Money money = (Money) obj;
            return this.amount == money.amount;
        }
    }
}