using System;
using ProductionCode;

namespace Test
{
    public class WasRunTests
    {
        public void testWasRun()
        {
            var test = new WasRun("testMethod");
            Console.WriteLine(test.wasRun);
            test.testMethod();
            Console.WriteLine(test.wasRun);
        }
    }
}