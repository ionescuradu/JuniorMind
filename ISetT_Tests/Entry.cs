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

        public int next { get; internal set; }
    }
}