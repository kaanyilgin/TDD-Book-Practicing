using System;

namespace ProductionCode
{
    public class Assert
    {
        public static void True(object expected, object actual)
        {
            if (expected.Equals(actual) == false)
            {
                throw new Exception();
            }
        }
    }
}