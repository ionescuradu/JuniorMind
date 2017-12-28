using System;

namespace IDictionaryT
{
    internal class Entry<TKey, TValue>
    {
        private TKey key;
        private TValue value;
        private TValue searchedValue;

        public Entry( TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        public TValue FindValue(TKey searchedKey)
        {
            if (key.Equals(searchedKey))
            {
                return searchedValue = value;
            }
            return default(TValue);
        }
    }
}