using NUnit.Framework;
using ProductionCode;

namespace Test
{
    public class DifferentCurrencyTests
    {
        [Test]
        public void testReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.That(result, Is.EqualTo(Money.Dollar(1)));
        }
    }
}