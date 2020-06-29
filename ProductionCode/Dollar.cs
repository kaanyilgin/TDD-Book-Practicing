namespace ProductionCode
{
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            this.amount *= multiplier;
            return null;
        }
    }
}