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

        public void Run()
        {
            Type WasRun = typeof(WasRun);
            MethodInfo toInvoke = WasRun.GetMethod(this.name);
            toInvoke.Invoke(this, null);
        }
    }
}