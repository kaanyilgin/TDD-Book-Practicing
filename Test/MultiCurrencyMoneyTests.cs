using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class MultiCurrencyMoneyTests
    {
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.That(10, five.amount);
        }
    }
}