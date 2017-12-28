using System;
using System.Collections;
using System.Collections.Generic;

namespace IDictionaryT
{
    internal class Entry<TKey, TValue>
    {
        private TKey key;
        private TValue value;
        private TValue searchValue;

        public Entry( TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        public TValue FindValue(TKey searchKey)
        {
            if (key.Equals(searchKey))
            {
                return searchValue = value;
            }
            return default(TValue);
        }
    }
}