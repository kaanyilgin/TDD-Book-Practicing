namespace ProductionCode
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(this.amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            Money money = (Money) obj;
            return this.amount == money.amount;
        }
    }
}