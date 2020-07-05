using System;

namespace ProductionCode
{
    public class WasRun : TestCase
    {
        public string log;

        public WasRun(string name) : base(name)
        {
            
        }

        public override void SetUp()
        {
            this.log = "SetUp  ";
        }

        public override void TearDown()
        {
            this.log += "TearDown  ";
        }

        public void TestMethod()
        {
            this.log += "TestMethod  ";
        }
    }
}