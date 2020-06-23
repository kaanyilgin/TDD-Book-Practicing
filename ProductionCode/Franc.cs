namespace ProductionCode
{
    public class Franc : Money
    {   
        public Franc(int amount)
        {
            this.amount = amount;
            this.currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            return new Franc(this.amount * multiplier);
        }
    }
}