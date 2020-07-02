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
            Type type = this.GetType();
            this.SetUp();
            MethodInfo toInvoke = type.GetMethod(this.name);
            toInvoke.Invoke(this, null);
        }
        
        public virtual void SetUp()
        {
        }
    }
}