using NUnit.Framework;
using ProductionCode;

namespace Test
{
    [TestFixture]
    public class EqualityTests
    {
        [Test]
        public void testEqualtity5to5()
        {
            Assert.That(Money.Dollar(5).Equals(Money.Dollar(5)), Is.True);
            Assert.That(Money.Dollar(5).Equals(Money.Dollar(6)), Is.False);
            Assert.That(Money.Franc(5).Equals(Money.Franc(5)), Is.True);
            Assert.That(Money.Franc(5).Equals(Money.Franc(6)), Is.False);
            Assert.That(Money.Dollar(5).Equals(Money.Franc(5)), Is.False);
        }

        [Test]
        public void testDifferentClassEquality()
        {
            Assert.That(new Money(10, "CHF"), Is.EqualTo(new Franc(10, "CHF")));
        }
    }
}