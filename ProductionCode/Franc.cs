namespace ProductionCode
{
    public class Franc
    {
        private int amount;

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
            Franc franc = (Franc) obj;
            return this.amount == franc.amount;
        }
    }
}