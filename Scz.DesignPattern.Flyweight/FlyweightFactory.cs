using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.Flyweight
{
    public class FlyweightFactory
    {
        Dictionary<string, Flyweight> dic;

        public FlyweightFactory()
        {
            dic = new Dictionary<string, Flyweight>
            {
                { "A", new ConcreteFlyweight("A") },
                { "B", new ConcreteFlyweight("B") },
                { "C", new ConcreteFlyweight("C") }
            };
        }

        public Flyweight GetFlyweight(string key)
        {
            return dic.GetValueOrDefault(key);
        }

        public void Add(string key,Flyweight flyweight)
        {
            if(!dic.ContainsKey(key))
            {
                dic.Add(key, flyweight);
            }
        }
    }
}
