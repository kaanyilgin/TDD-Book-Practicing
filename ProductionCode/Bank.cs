using System;
using System.Collections;
using System.Net;
using System.Reflection.Metadata;

namespace ProductionCode
{
    public class Bank
    {
        private Hashtable rates = new Hashtable();
        
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to))
            {
                return 1;
            }
            
            var rate = (int) rates[new Pair(from, to)];
            return rate;
        }

        public void AddRate(string @from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }
    }
}