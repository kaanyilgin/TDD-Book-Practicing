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
    }
}