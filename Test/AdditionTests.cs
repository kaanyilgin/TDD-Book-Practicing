using System.Diagnostics.CodeAnalysis;
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
            Money five = Money.Dollar(5);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.That(reduced, Is.EqualTo(Money.Dollar(10)));
        }
        
        [Test]
        public void testPlusReturnsValue()
        {
            Money five = Money.Dollar(5);
            Expression result = five.Plus(five);
            Sum sum = (Sum) result;
            Assert.That(sum.augend, Is.EqualTo(five));
            Assert.That(sum.addend, Is.EqualTo(five));
        }
        
        [Test]
        public void testReduceSum()
        {
            Expression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.That(result, Is.EqualTo(Money.Dollar(7)));
        }
    }
}