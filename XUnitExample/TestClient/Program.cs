using System;
using ProductionCode;
using Test;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            new WasRunTests().testWasRun();
            new TestCaseTest("TestRunning").Run();
        }
    }
}