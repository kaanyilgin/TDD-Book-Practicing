namespace ProductionCode
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(this.amount * multiplier);
        }
    }
}