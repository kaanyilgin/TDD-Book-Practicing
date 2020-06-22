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
            Assert.That(10, Is.EqualTo(five.amount));
        }
        
        [Test]
        public void TestMultiplicationTwoTimes()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            product = five.Times(3);
            Assert.That(15, Is.EqualTo(five.amount));
        }
    }
}