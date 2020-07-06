using System;
using System.Reflection;

namespace ProductionCode
{
    public class TestCase
    {
        private readonly string name;

        public TestCase(string name)
        {
            this.name = name;
        }

        public TestResult Run()
        {
            Type type = this.GetType();
            this.SetUp();
            MethodInfo toInvoke = type.GetMethod(this.name);
            toInvoke.Invoke(this, null);
            this.TearDown();
            return new TestResult();
        }

        public virtual void TearDown()
        {
        }

        public virtual void SetUp()
        {
        }
    }
}