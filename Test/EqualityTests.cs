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
            Assert.That(new Dollar(5).Equals(new Dollar(5)), Is.True);
        }
    }
}