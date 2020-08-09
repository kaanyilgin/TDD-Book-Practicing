using System;
using System.Diagnostics;
using System.Reflection;
using ProductionCode;

namespace Test
{
    public class TestCaseTest : TestCase
    {
        public WasRun test;
        public TestResult result;

        public TestCaseTest(string name) : base(name)
        {
        }

        public override void SetUp()
        {
            result = new TestResult();
        }

        public void TestTemplateMethod()
        {
            test = new WasRun("TestMethod");
            test.Run(result);
            Assert.True("SetUp  TestMethod  TearDown  ", test.log);
        }

        public void TestResult()
        {
            test = new WasRun("TestMethod");
            test.Run(result);
            Assert.True("1 run, 0 failed", result.Summary());
        }

        public void TestFailedResultFormatting()
        {
            var result = new TestResult();
            result.TestStarted();
            result.TestFailed();
            Assert.True("1 run, 1 failed", result.Summary());
        }

        public void TestFailedResult()
        {
            var test = new WasRun("TestBrokenMethod");
            test.Run(result);
            Assert.True("1 run, 1 failed", result.Summary());
        }

        public void TestSetupFailedResult()
        {
            var test = new FakeWasRun("TestMethod");
            test.Run(result);
            Assert.True("1 run, 1 failed", result.Summary());
        }

        public void TestSuite()
        {
            var suit = new TestSuite();
            suit.Add(new WasRun("TestMethod"));
            suit.Add(new WasRun("TestBrokenMethod"));
            suit.Run(result);
            Assert.True("2 run, 1 failed", result.Summary());
        }

        public void TestFailedTest()
        {
            var suit = new TestSuite();
            suit.Add(new FakeFailedTest("TestFailedTest"));
            suit.Run(result);
            Assert.True("1 run, 1 failed", result.Summary());
        }
    }

    public class FakeWasRun : WasRun
    {
        public FakeWasRun(string name) : base(name)
        {
        }

        public override void SetUp()
        {
            throw new Exception();
        }
    }

    public class FakeFailedTest : WasRun
    {
        public FakeFailedTest(string name) : base(name)
        {
        }

        public void TestFailedTest()
        {
            Assert.True(1, 2);
        }
    }
}