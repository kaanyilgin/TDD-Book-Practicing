using System.Diagnostics;
using System.Reflection;
using ProductionCode;

namespace Test
{
    public class TestCaseTest : TestCase
    {
        public WasRun test;
        
        public TestCaseTest(string name) : base(name)
        {
        }

        public override void SetUp()
        {
            test = new WasRun("TestMethod");
        }

        public void TestRunning()
        {
            Debug.Assert(test.wasRun == false);
            test.Run();
            Debug.Assert(test.wasRun);
        }

        public void TestSetUp()
        {
            test.Run();
            Debug.Assert("SetUp  " == test.log);
        }
    }
}