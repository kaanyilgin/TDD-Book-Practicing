namespace ProductionCode
{
    public interface Expression
    {
        Money Reduce(string to);
    }
}