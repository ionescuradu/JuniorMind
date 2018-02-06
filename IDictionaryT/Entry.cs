using System;

namespace IDictionaryT
{
    internal class Entry<TKey, TValue>
    {
        private TKey key;
        private TValue value;

        public Entry( TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        public TValue FindValue(TKey searchedKey)
        {
            var searchedValue = default(TValue);
            if (key.Equals(searchedKey))
            {
                return searchedValue = value;
            }
            return default(TValue);
        }       

        public bool FindKey(TKey searchedkey)
        {
            return key.Equals(searchedkey);
        }

        public void ReplaceValue(TValue replaceValue)
        {
            value = replaceValue;
        }

    }
}