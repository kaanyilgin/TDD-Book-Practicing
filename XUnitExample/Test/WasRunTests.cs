using System;
using ProductionCode;

namespace Test
{   
    public class WasRunTests
    {
        public void testWasRun()
        {
            var test = new WasRun("TestMethod");
            Console.WriteLine(test.wasRun);
            test.Run();
            Console.WriteLine(test.wasRun);
        }
    }
}