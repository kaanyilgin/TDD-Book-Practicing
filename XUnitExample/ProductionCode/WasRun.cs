using System;

namespace ProductionCode
{
    public class WasRun : TestCase
    {
        public bool wasRun;
        public string log;

        public WasRun(string name) : base(name)
        {
            
        }

        public override void SetUp()
        {
            this.wasRun = false;
            this.log = "SetUp  ";
        }

        public void TestMethod()
        {
            this.wasRun = true;
        }
    }
}