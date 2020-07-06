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

        public void TestTemplateMethod()
        {
            test.Run();
            Debug.Assert("SetUp  TestMethod  TearDown  " == test.log);
        }

        public void TestResult()
        {
            var result = test.Run();
            Debug.Assert("1 run, 0 failed" == result.Summary());
        }

        public void TestFailedResult()
        {
            var test = new WasRun("TestBrokenMethod");
            var testResult = test.Run();
            Debug.Assert("1 run, 1 failed" == testResult.Summary());
        }
    }
}