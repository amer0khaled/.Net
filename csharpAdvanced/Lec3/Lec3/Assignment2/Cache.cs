using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec3.Assignment2
{
    public class Cache<TKey, TValue>
    {
        public Dictionary<TKey, TValue> cache;

        public Cache() 
        {
            cache = new Dictionary<TKey, TValue>();
        }

        public void add(TKey key, TValue value) => cache[key] = value;

        public TValue Retrieve(TKey key)
        {
            if (cache.TryGetValue(key, out var value)) return value;
            throw new KeyNotFoundException($"this key {key} not found in the dictionary");
        }

        public void remove(TKey key) 
        {
            if (!cache.Remove(key))
                throw new KeyNotFoundException($"this key {key} not found in the dictionary");
        }

        public void PrintCache()
        {
            foreach (var i in cache)
            {
                Console.WriteLine($"key[{i.Key}] = {i.Value}");
            }

            
        }

    }
}
