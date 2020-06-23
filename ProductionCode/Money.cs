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
            return this.amount == money.amount && GetType() == money.GetType();
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

        public virtual Money Times(int multiplier)
        {
            return null;
        }

        public override string ToString()
        {
            return this.amount + " " + currency;
        }
    }
}