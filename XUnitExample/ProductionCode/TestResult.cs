namespace ProductionCode
{
    public class TestResult
    {
        private int runCount;

        public TestResult()
        {
            this.runCount = 0;
        }

        public void TestStarted()
        {
            this.runCount++;
        }

        public string Summary()
        {
            return $"{this.runCount} run, 0 failed";
        }
    }
}