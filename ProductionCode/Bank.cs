namespace ProductionCode
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public int Rate(string from, string to)
        {
            return from.Equals("CHF") && to.Equals("USD") ? 2 : 1;
        }

        public void addRate(string chf, string usd, int i)
        {
        }
    }
}