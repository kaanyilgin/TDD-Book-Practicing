namespace ProductionCode
{
    public class Franc : Money
    {   
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return new Franc(this.amount * multiplier, currency);
        }
    }
}