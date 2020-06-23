using System.Threading;

namespace ProductionCode
{
    public class Money
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
            return new Dollar(multiplier, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
        
        public string Currency()
        {
            return this.currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(this.amount * multiplier, currency);
        }

        public override string ToString()
        {
            return this.amount + " " + currency;
        }
    }
}