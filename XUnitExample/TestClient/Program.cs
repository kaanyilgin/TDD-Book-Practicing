using Test;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            new WasRunTests().testWasRun();
            new TestCaseTest("TestRunning").Run();
            new TestCaseTest("TestSetUp").Run();
        }
    }
}