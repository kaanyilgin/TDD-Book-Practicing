using System.Collections.Generic;

namespace ProductionCode
{
    public class TestSuite
    {
        private IList<TestCase> test;

        public TestSuite()
        {
            this.test = new List<TestCase>();
        }

        public void Add(TestCase test)
        {
            this.test.Add(test);
        }

        public void Run(TestResult result)
        {
            foreach (var test in this.test)
            {
                test.Run(result);
            }
        }
    }
}