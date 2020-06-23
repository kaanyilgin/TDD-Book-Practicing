namespace ProductionCode
{
    public class Dollar : Money
    {
        private string currency;
        
        public Dollar(int amount)
        {
            this.amount = amount;
            this.currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(this.amount * multiplier);
        }

        public override string Currency()
        {
            return this.currency;
        }
    }
}