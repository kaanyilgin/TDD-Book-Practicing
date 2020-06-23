namespace ProductionCode
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(this.amount * multiplier);
        }

        public override string Currency()
        {
            return "CHF";
        }
    }
}