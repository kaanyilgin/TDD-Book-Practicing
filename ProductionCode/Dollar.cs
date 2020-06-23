namespace ProductionCode
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
        {
            this.amount = amount;
            this.currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(this.amount * multiplier, null);
        }
    }
}