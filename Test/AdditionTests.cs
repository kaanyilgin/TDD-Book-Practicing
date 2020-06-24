using NUnit.Framework;
using ProductionCode;

namespace Test
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void testSimpleAddition()
        {
            Money sum = Money.Dollar(5).Plus(Money.Dollar(5));
            Assert.That(sum, Is.EqualTo(Money.Dollar(10)));
        }
    }
}