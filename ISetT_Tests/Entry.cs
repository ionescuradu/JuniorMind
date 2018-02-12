using System;

namespace ISetT_Tests
{
    internal class Entry<TKey>
    {
        private TKey key;

        public Entry( TKey key)
        {
            this.key = key; 
        }

        public bool CompareKey(Entry<TKey> item)
        {
            return key.Equals(item.key);
        }

        public int Next { get; internal set; }
    }
}