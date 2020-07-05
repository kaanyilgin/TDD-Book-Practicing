using System;

namespace ProductionCode
{
    public class WasRun : TestCase
    {
        public bool wasRun;
        public bool wasSetUp;

        public WasRun(string name) : base(name)
        {
            
        }

        public override void SetUp()
        {
            this.wasRun = false;
            this.wasSetUp = true;
        }

        public void TestMethod()
        {
            this.wasRun = true;
        }
    }
}