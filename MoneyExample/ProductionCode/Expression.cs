namespace ProductionCode
{
    public interface Expression
    {
        Money Reduce(Bank bank, string to);
        Expression Plus(Expression tenFrancs);
        Expression Times(int multiplier);
    }
}