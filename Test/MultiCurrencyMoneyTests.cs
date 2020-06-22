using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using NUnit.Framework;
using ProductionCode;

namespace Test
{
    [TestFixture]
    public class MultiCurrencyMoneyTests
    {
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.That(five.amount, Is.EqualTo(10));
        }

        [Test]
        public void TestMultiplicationTwoTimes()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.That(product.amount, Is.EqualTo(10));
            product.Times(3);
            Assert.That(five.amount, Is.EqualTo(15));
        }
    }
}