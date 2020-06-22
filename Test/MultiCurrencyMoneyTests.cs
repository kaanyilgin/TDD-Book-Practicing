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
            Assert.That(five.Times(2), Is.EqualTo(new Dollar(10)));
            Assert.That(five.Times(3) , Is.EqualTo(new Dollar(15)));
        }
    }
}