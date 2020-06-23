using NUnit.Framework;
using ProductionCode;

namespace Test
{
    [TestFixture]
    public class CurrencyTests
    {
        [Test]
        public void testCurrency()
        {
            Assert.That(Money.Dollar(1).Currency(), Is.EqualTo("USD"));
            Assert.That(Money.Franc(1).Currency(), Is.EqualTo("CHF"));
        }
    }
}