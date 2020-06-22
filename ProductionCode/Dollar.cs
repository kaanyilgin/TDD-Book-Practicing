namespace ProductionCode
{
    public class Dollar : Money
    {
        private int amount;

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
            Dollar dollar = (Dollar) obj;
            return this.amount == dollar.amount;
        }
    }
}