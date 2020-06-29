using NUnit.Framework;
using ProductionCode;

namespace Test
{
    [TestFixture]
    public class FrancMultiplicationTests
    {
        [Test]
        public void testFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.That(five.Times(2), Is.EqualTo(Money.Franc(10)));
            Assert.That(five.Times(3) , Is.EqualTo(Money.Franc(15)));
        }
    }
}