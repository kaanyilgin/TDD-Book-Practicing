namespace ProductionCode
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            Sum sum = (Sum) source;
            return sum.Reduce(to);
        }
    }
}