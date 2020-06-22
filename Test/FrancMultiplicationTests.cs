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
            Franc five = new Franc(5);
            Assert.That(five.Times(2), Is.EqualTo(new Franc(10)));
            Assert.That(five.Times(3) , Is.EqualTo(new Franc(15)));
        }
    }
}