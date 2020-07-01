using System.Diagnostics;
using ProductionCode;

namespace Test
{
    public class TestCaseTest : TestCase
    {
        public TestCaseTest(string name) : base(name)
        {
        }
        
        public void TestRunning()
        {
            var test = new WasRun("TestMethod");
            Debug.Assert(test.wasRun == false);
            test.Run();
            Debug.Assert(test.wasRun);
        }
    }
}