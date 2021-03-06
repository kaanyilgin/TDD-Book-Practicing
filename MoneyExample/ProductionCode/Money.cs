using System.Threading;

namespace ProductionCode
{
    public class Money : Expression
    {
        protected internal int amount;
        protected string currency;
        
        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }
        
        public override bool Equals(object? obj)
        {
            Money money = (Money) obj;
            return this.amount == money.amount && 
                   this.Currency().Equals(money.Currency());
        }

        public static Money Dollar(int multiplier)
        {
            return new Money(multiplier, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }
        
        public string Currency()
        {
            return this.currency;
        }

        public Expression Times(int multiplier)
        {
            return new Money(this.amount * multiplier, currency);
        }

        public override string ToString()
        {
            return this.amount + " " + currency;
        }

        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            var rate = bank.Rate(currency, to);
            return new Money(amount / rate, to);
        }
    }
}