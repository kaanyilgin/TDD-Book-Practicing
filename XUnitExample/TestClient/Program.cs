using System;
using Test;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new TestCaseTest("TestTemplateMethod").Run().Summary());
            Console.WriteLine(new TestCaseTest("TestResult").Run().Summary());
            Console.WriteLine(new TestCaseTest("TestFailedResultFormatting").Run().Summary());
            Console.WriteLine(new TestCaseTest("TestFailedResult").Run().Summary());
            Console.WriteLine(new TestCaseTest("TestSetupFailedResult").Run().Summary());
        }
    }
}