using System;
using ProductionCode;
using Test;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var suite = new TestSuite();
            suite.Add(new TestCaseTest("TestTemplateMethod"));
            suite.Add(new TestCaseTest("TestResult"));
            suite.Add(new TestCaseTest("TestFailedResultFormatting"));
            suite.Add(new TestCaseTest("TestFailedResult"));
            suite.Add(new TestCaseTest("TestSetupFailedResult"));
            suite.Add(new TestCaseTest("TestSuite"));
            var result = new TestResult();
            suite.Run(result);
            Console.WriteLine(result.Summary());
        }
    }
}