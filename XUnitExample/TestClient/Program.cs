using Test;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            new TestCaseTest("TestTemplateMethod").Run();
            new TestCaseTest("TestResult").Run();
            new TestCaseTest("TestFailedResultFormatting").Run();
        }
    }
}