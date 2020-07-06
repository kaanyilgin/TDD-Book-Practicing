namespace ProductionCode
{
    public class TestResult
    {
        private int runCount;
        private int errorCount;

        public TestResult()
        {
            this.runCount = 0;
            this.errorCount = 0;
        }

        public void TestStarted()
        {
            this.runCount++;
        }

        public string Summary()
        {
            return $"{this.runCount} run, {this.errorCount} failed";
        }

        public void TestFailed()
        {
            this.errorCount++;
        }
    }
}